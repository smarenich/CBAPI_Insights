using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using PX.Api.ContractBased;
using PX.Api.ContractBased.Models;
using PX.Common;
using PX.Data;

namespace CBAPI_Insights
{
	public static class APIHelper
	{
		public static EntityImpl ConvertImpl(CBAPI_Insights.API.Entity entity)
		{
			Type parentEntityType = typeof(CBAPI_Insights.API.Entity);

			EntityImpl ret = new EntityImpl();
			ret.ObjectName = entity.GetType().Name;
			ret.Delete = entity.Delete;
			ret.ID = entity.Id;
			//ret.NoteID = entity.SyncID;
			ret.ReturnBehavior = (ReturnBehavior)Enum.Parse(typeof(ReturnBehavior), entity.ReturnBehavior.ToString());
			ret.CustomFields = entity.Custom?.Select(f => ConvertCustomField(f)).ToArray();

			ret.Fields = new EntityField[0];
			foreach (PropertyInfo pi in entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
			{
				if (pi == null) continue;

				Type t = pi.PropertyType;
				object v = pi.GetValue(entity);
				if (v != null && !t.IsArray && t.IsClass && !parentEntityType.IsAssignableFrom(t))
				{
					string sv = null;
					object value = t.InvokeMember("Value", BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, v, new object[] { });

					switch (t.Name)
					{
						case "StringValue":
							sv = value?.ToString();
							break;
						case "IntValue":
						case "DecimalValue":
						case "ShortValue":
						case "BooleanValue":
						case "ByteValue":
						case "DoubleValue":
						case "DateTimeValue":
						case "LongValue":
							sv = value == null ? null : Convert.ToString(value, CultureInfo.InvariantCulture);
							break;
						case "GuidValue":
							sv = value == null ? null : ((Guid?)value)?.ToString("", CultureInfo.InvariantCulture);
							break;
					}

					if (v.GetType().Name.EndsWith("Return"))
						ret.AddField(new EntityReturnField { Name = pi.Name });
					if (v.GetType().Name.EndsWith("Skip"))
						ret.AddField(new EntitySkipField { Name = pi.Name });
					if (v.GetType().Name.EndsWith("Value"))
						ret.AddField(new EntityValueField { Name = pi.Name, Value = sv });
					if (v.GetType().Name.EndsWith("Search"))
					{
						object condition = v.GetType().InvokeMember("Condition", BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, v, new object[] { });

						ret.AddField(new EntitySearchField { Name = pi.Name, Value = sv, Condition = Enum.GetName(condition.GetType(), condition) });
					}
				}
				else if (t.IsArray)
				{
					Array a = pi.GetValue(entity) as Array;
					if (a != null && a.Length > 0)
					{
						EntityListField l = new EntityListField();
						l.Name = pi.Name;
						l.Value = new EntityImpl[a.Length];
						for (int i = 0; i < a.Length; i++)
						{
							l.Value[i] = ConvertImpl((CBAPI_Insights.API.Entity)a.GetValue(i));
						}
						ret.AddField(l);
					}
				}
				else if (t.IsPrimitive || t.IsEnum)
				{
					PropertyInfo dest = ret.GetType().GetProperties().FirstOrDefault(p => p.Name == t.Name);
					if (dest != null) dest.SetValue(ret, pi.GetValue(entity));
				}
				else if (t.IsClass)
				{
					object e = pi.GetValue(entity);
					if (e != null)
					{
						ret.AddField(new EntityObjectField { Name = pi.Name, Value = ConvertImpl((CBAPI_Insights.API.Entity)e) });
					}
				}
			}
			return ret;
		}
		public static CBAPI_Insights.API.Entity ConvertImpl(EntityImpl entity, string nameSpace)
		{
			CBAPI_Insights.API.Entity ret = (CBAPI_Insights.API.Entity)Activator.CreateInstance(System.Web.Compilation.BuildManager.GetType(nameSpace + "." + entity.ObjectName, true));
			ret.Delete = entity.Delete;
			ret.Id = entity.ID;
			ret.ReturnBehavior = (CBAPI_Insights.API.ReturnBehavior)Enum.Parse(typeof(CBAPI_Insights.API.ReturnBehavior), entity.ReturnBehavior.ToString());
			ret.Custom = entity?.CustomFields.Select(f => ConvertCustomField(f)).ToList();


			foreach (EntityField ef in entity.Fields)
			{
				PropertyInfo pi = ret.GetType().GetProperty(ef.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
				if (pi == null) continue;

				if (ef is EntityObjectField)
				{
					EntityObjectField eof = (EntityObjectField)ef;
					if (eof.Value is EntityImpl)
					{
						pi.SetValue(ret, ConvertImpl((EntityImpl)eof.Value, nameSpace));
					}
				}
				else if (ef is EntityListField)
				{
					EntityListField elf = (EntityListField)ef;
					if (elf.Value != null && elf.Value.Length > 0)
					{
						Type arrType = System.Web.Compilation.BuildManager.GetType(nameSpace + "." + elf.Value[0].ObjectName, true);
						Array arr = (Array)Activator.CreateInstance(arrType.MakeArrayType(1), new object[] { elf.Value.Length });
						for (int i = 0; i < elf.Value.Length; i++)
						{
							arr.SetValue(ConvertImpl(elf.Value[i], nameSpace), i);
						}

						MethodInfo convertMethod = typeof(APIHelper).GetMethod("ConvertArray", BindingFlags.Public | BindingFlags.Static);
						MethodInfo generic = convertMethod.MakeGenericMethod(new[] { arrType });


						pi.SetValue(ret, generic.Invoke(null, new object[] { arr }));
					}
				}
				else if (ef is EntityValueField)
				{
					EntityValueField evf = (EntityValueField)ef;
					if (evf.Value != null)
					{
						Type t = pi.PropertyType;

						object value = null;
						object po = Activator.CreateInstance(t);
						switch (t.Name)
						{
							case "StringValue":
								value = evf.Value;
								break;
							case "IntValue":
								value = int.Parse(evf.Value, CultureInfo.InvariantCulture);
								break;
							case "DecimalValue":
								value = decimal.Parse(evf.Value, CultureInfo.InvariantCulture);
								break;
							case "ShortValue":
								value = short.Parse(evf.Value, CultureInfo.InvariantCulture);
								break;
							case "BooleanValue":
								value = bool.Parse(evf.Value);
								break;
							case "ByteValue":
								value = byte.Parse(evf.Value, CultureInfo.InvariantCulture);
								break;
							case "DoubleValue":
								value = double.Parse(evf.Value, CultureInfo.InvariantCulture);
								break;
							case "DateTimeValue":
								value = DateTime.Parse(evf.Value, CultureInfo.InvariantCulture);
								break;
							case "GuidValue":
								value = Guid.Parse(evf.Value);
								break;
							case "LongValue":
								value = long.Parse(evf.Value, CultureInfo.InvariantCulture);
								break;
						}
						t.InvokeMember("Value", BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty, null, po, new object[] { value });

						pi.SetValue(ret, po);
					}
				}
			}
			return ret;
		}
		public static CustomField ConvertCustomField(CBAPI_Insights.API.CustomField field)
		{
			Type t = field.GetType();
			switch (t.Name)
			{
				case "StringValue":
					return new CustomStringField() { Value = new StringValue() { Value = ((CBAPI_Insights.API.CustomStringField)field).Value }, FieldName = field.FieldName, ViewName = field.ViewName };
				case "IntValue":
					return new CustomIntField() { Value = new IntValue() { Value = ((CBAPI_Insights.API.CustomIntField)field).Value }, FieldName = field.FieldName, ViewName = field.ViewName };
				case "DecimalValue":
					return new CustomDecimalField() { Value = new DecimalValue() { Value = ((CBAPI_Insights.API.CustomDecimalField)field).Value }, FieldName = field.FieldName, ViewName = field.ViewName };
				case "ShortValue":
					return new CustomStringField() { Value = new StringValue() { Value = ((CBAPI_Insights.API.CustomStringField)field).Value }, FieldName = field.FieldName, ViewName = field.ViewName };
				case "BooleanValue":
					return new CustomBooleanField() { Value = new BooleanValue() { Value = ((CBAPI_Insights.API.CustomBooleanField)field).Value }, FieldName = field.FieldName, ViewName = field.ViewName };
				case "ByteValue":
					return new CustomByteField() { Value = new ByteValue() { Value = ((CBAPI_Insights.API.CustomByteField)field).Value }, FieldName = field.FieldName, ViewName = field.ViewName };
				case "DoubleValue":
					return new CustomDoubleField() { Value = new DoubleValue() { Value = ((CBAPI_Insights.API.CustomDoubleField)field).Value }, FieldName = field.FieldName, ViewName = field.ViewName };
				case "DateTimeValue":
					return new CustomDateTimeField() { Value = new DateTimeValue() { Value = ((CBAPI_Insights.API.CustomDateTimeField)field).Value }, FieldName = field.FieldName, ViewName = field.ViewName };
				case "LongValue":
					return new CustomLongField() { Value = new LongValue() { Value = ((CBAPI_Insights.API.CustomLongField)field).Value }, FieldName = field.FieldName, ViewName = field.ViewName };
				case "GuidValue":
					return new CustomGuidField() { Value = new GuidValue() { Value = ((CBAPI_Insights.API.CustomGuidField)field).Value }, FieldName = field.FieldName, ViewName = field.ViewName };
			}
			return null;
		}
		public static CBAPI_Insights.API.CustomField ConvertCustomField(CustomField field)
		{
			Type t = field.GetType();
			switch (t.Name)
			{
				case "StringValue":
					return new CBAPI_Insights.API.CustomStringField() { Value = ((CustomStringField)field).Value.Value, FieldName = field.FieldName, ViewName = field.ViewName };
				case "IntValue":
					return new CBAPI_Insights.API.CustomIntField() { Value = ((CustomIntField)field).Value.Value.Value, FieldName = field.FieldName, ViewName = field.ViewName };
				case "DecimalValue":
					return new CBAPI_Insights.API.CustomDecimalField() { Value = ((CustomDecimalField)field).Value.Value, FieldName = field.FieldName, ViewName = field.ViewName };
				case "ShortValue":
					return new CBAPI_Insights.API.CustomStringField() { Value = ((CustomStringField)field).Value.Value, FieldName = field.FieldName, ViewName = field.ViewName };
				case "BooleanValue":
					return new CBAPI_Insights.API.CustomBooleanField() { Value = ((CustomBooleanField)field).Value.Value, FieldName = field.FieldName, ViewName = field.ViewName };
				case "ByteValue":
					return new CBAPI_Insights.API.CustomByteField() { Value = ((CustomByteField)field).Value.Value, FieldName = field.FieldName, ViewName = field.ViewName };
				case "DoubleValue":
					return new CBAPI_Insights.API.CustomDoubleField() { Value = ((CustomDoubleField)field).Value.Value, FieldName = field.FieldName, ViewName = field.ViewName };
				case "DateTimeValue":
					return new CBAPI_Insights.API.CustomDateTimeField() { Value = ((CustomDateTimeField)field).Value.Value, FieldName = field.FieldName, ViewName = field.ViewName };
				case "LongValue":
					return new CBAPI_Insights.API.CustomLongField() { Value = ((CustomLongField)field).Value.Value, FieldName = field.FieldName, ViewName = field.ViewName };
				case "GuidValue":
					return new CBAPI_Insights.API.CustomGuidField() { Value = ((CustomGuidField)field).Value.Value, FieldName = field.FieldName, ViewName = field.ViewName };
			}
			return null;
		}
		public static List<T> ConvertArray<T>(Array input)
		{
			return input.Cast<T>().ToList();
		}

		public static void AddField(this EntityImpl entity, EntityField field)
		{
			if (entity.Fields == null)
				entity.Fields = new[] { field };
			else
				entity.Fields = entity.Fields.Concat(new[] { field }).ToArray();
		}
		public static void AddValueField(this EntityImpl entity, string name, object value)
		{

			entity.AddField(new EntityValueField() { Name = name, Value = value == null ? null : Convert.ToString(value, CultureInfo.InvariantCulture) });
		}
		public static void AddSearchField(this EntityImpl entity, string name, string value, CBAPI_Insights.API.GeneralCondition condition)
		{
			entity.AddField(new EntitySearchField() { Name = name, Value = value, Condition = condition.ToInvariantString(), /*Force = true*/ });
		}
		public static void AddReturnField(this EntityImpl entity, string name)
		{
			entity.AddField(new EntityReturnField() { Name = name });
		}
		public static EntityImpl AddObjectField(String type)
		{
			EntityImpl obj = new EntityImpl() { ObjectName = type };
			return obj;
		}

		#region Conversion

		//Value Fields
		public static API.StringValue ValueField(this string val)
		{
			return val == null ? null : new API.StringValue() { Value = val };
		}
		public static API.IntValue ValueField(this int val)
		{
			return new API.IntValue() { Value = val };
		}
		public static API.IntValue ValueField(this int? val)
		{
			return val == null ? null : new API.IntValue() { Value = val };
		}
		public static API.DecimalValue ValueField(this decimal val)
		{
			return new API.DecimalValue() { Value = val };
		}
		public static API.DecimalValue ValueField(this decimal? val)
		{
			return val == null ? null : new API.DecimalValue() { Value = val };
		}
		public static API.ShortValue ValueField(this short val)
		{
			return new API.ShortValue() { Value = val };
		}
		public static API.ShortValue ValueField(this short? val)
		{
			return val == null ? null : new API.ShortValue() { Value = val };
		}
		public static API.BooleanValue ValueField(this bool val)
		{
			return new API.BooleanValue() { Value = val };
		}
		public static API.BooleanValue ValueField(this bool? val)
		{
			return val == null ? null : new API.BooleanValue() { Value = val };
		}
		public static API.ByteValue ValueField(this byte val)
		{
			return new API.ByteValue() { Value = val };
		}
		public static API.ByteValue ValueField(this byte? val)
		{
			return val == null ? null : new API.ByteValue() { Value = val };
		}
		public static API.DoubleValue ValueField(this double val)
		{
			return new API.DoubleValue() { Value = val };
		}
		public static API.DoubleValue ValueField(this double? val)
		{
			return val == null ? null : new API.DoubleValue() { Value = val };
		}
		public static API.DateTimeValue ValueField(this DateTime val)
		{
			return new API.DateTimeValue() { Value = val };
		}
		public static API.DateTimeValue ValueField(this DateTime? val)
		{
			return val == null ? null : new API.DateTimeValue() { Value = val };
		}
		public static API.LongValue ValueField(this long val)
		{
			return new API.LongValue() { Value = val };
		}
		public static API.LongValue ValueField(this long? val)
		{
			return val == null ? null : new API.LongValue() { Value = val };
		}
		public static API.GuidValue ValueField(this Guid val)
		{
			return new API.GuidValue() { Value = val };
		}
		public static API.GuidValue ValueField(this Guid? val)
		{
			return val == null ? null : new API.GuidValue() { Value = val };
		}

		public static API.StringSearch SearchField(this string val, API.StringCondition condition = API.StringCondition.Equal)
		{
			return val == null ? null : new API.StringSearch() { Value = val, Condition = condition };
		}
		public static API.IntSearch SearchField(this int val, API.IntCondition condition = API.IntCondition.Equal)
		{
			return new API.IntSearch() { Value = val, Condition = condition };
		}
		public static API.IntSearch SearchField(this int? val, API.IntCondition condition = API.IntCondition.Equal)
		{
			return val == null ? null : new API.IntSearch() { Value = val, Condition = condition };
		}
		public static API.DecimalSearch SearchField(this decimal val, API.DecimalCondition condition = API.DecimalCondition.Equal)
		{
			return new API.DecimalSearch() { Value = val, Condition = condition };
		}
		public static API.DecimalSearch SearchField(this decimal? val, API.DecimalCondition condition = API.DecimalCondition.Equal)
		{
			return val == null ? null : new API.DecimalSearch() { Value = val, Condition = condition };
		}
		public static API.ShortSearch SearchField(this short val, API.ShortCondition condition = API.ShortCondition.Equal)
		{
			return new API.ShortSearch() { Value = val, Condition = condition };
		}
		public static API.ShortSearch SearchField(this short? val, API.ShortCondition condition = API.ShortCondition.Equal)
		{
			return val == null ? null : new API.ShortSearch() { Value = val, Condition = condition };
		}
		public static API.BooleanSearch SearchField(this bool val, API.BooleanCondition condition = API.BooleanCondition.Equal)
		{
			return new API.BooleanSearch() { Value = val, Condition = condition };
		}
		public static API.BooleanSearch SearchField(this bool? val, API.BooleanCondition condition = API.BooleanCondition.Equal)
		{
			return val == null ? null : new API.BooleanSearch() { Value = val, Condition = condition };
		}
		public static API.ByteSearch SearchField(this byte val, API.ByteCondition condition = API.ByteCondition.Equal)
		{
			return new API.ByteSearch() { Value = val, Condition = condition };
		}
		public static API.ByteSearch SearchField(this byte? val, API.ByteCondition condition = API.ByteCondition.Equal)
		{
			return val == null ? null : new API.ByteSearch() { Value = val, Condition = condition };
		}
		public static API.DoubleSearch SearchField(this double val, API.DoubleCondition condition = API.DoubleCondition.Equal)
		{
			return new API.DoubleSearch() { Value = val, Condition = condition };
		}
		public static API.DoubleSearch SearchField(this double? val, API.DoubleCondition condition = API.DoubleCondition.Equal)
		{
			return val == null ? null : new API.DoubleSearch() { Value = val, Condition = condition };
		}
		public static API.DateTimeSearch SearchField(this DateTime val, API.DateTimeCondition condition = API.DateTimeCondition.Equal)
		{
			return new API.DateTimeSearch() { Value = val, Condition = condition };
		}
		public static API.DateTimeSearch SearchField(this DateTime? val, API.DateTimeCondition condition = API.DateTimeCondition.Equal)
		{
			return val == null ? null : new API.DateTimeSearch() { Value = val, Condition = condition };
		}
		public static API.LongSearch SearchField(this long val, API.LongCondition condition = API.LongCondition.Equal)
		{
			return new API.LongSearch() { Value = val, Condition = condition };
		}
		public static API.LongSearch SearchField(this long? val, API.LongCondition condition = API.LongCondition.Equal)
		{
			return val == null ? null : new API.LongSearch() { Value = val, Condition = condition };
		}
		public static API.GuidSearch SearchField(this Guid val, API.GuidCondition condition = API.GuidCondition.Equal)
		{
			return new API.GuidSearch() { Value = val, Condition = condition };
		}
		public static API.GuidSearch SearchField(this Guid? val, API.GuidCondition condition = API.GuidCondition.Equal)
		{
			return val == null ? null : new API.GuidSearch() { Value = val, Condition = condition };
		}

		public static DateTime? ToDate(this string value)
		{
			DateTime? result = null;
			if (DateTime.TryParse(value, null, System.Globalization.DateTimeStyles.AssumeUniversal, out DateTime date))
				result = date;
			else
			{
				if (Int32.TryParse(value, out Int32 seconds))
				{
					//Unix style timestamp 
					result = new DateTime(1970, 1, 1).AddSeconds(seconds);
				}
			}
			return result;
		}
		public static Decimal? ToDecimal(this string value)
		{
			Decimal result;
			if (!Decimal.TryParse(value, NumberStyles.None, CultureInfo.InvariantCulture, out result))
			{
				return null;
			}
			return result;
		}
		public static Int32? ToInt(this string value)
		{
			Int32 result;
			if (!Int32.TryParse(value, NumberStyles.None, CultureInfo.InvariantCulture, out result))
			{
				return null;
			}
			return result;
		}
		public static Boolean? ToBolean(this string value)
		{
			Boolean result;
			if (!Boolean.TryParse(value, out result))
			{
				return null;
			}
			return result;
		}
		#endregion
	}
}
