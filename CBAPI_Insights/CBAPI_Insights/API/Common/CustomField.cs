using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace CBAPI_Insights.API
{
	/// <summary>
	/// CustomField
	/// </summary>
	[DataContract]
	public partial class CustomField
	{
		[DataMember(Name = "viewName", EmitDefaultValue = false)]
		public string ViewName { get; set; }

		[DataMember(Name = "fieldName", EmitDefaultValue = false)]
		public string FieldName { get; set; }
	}
	[DataContract]
	public partial class CustomIntField : CustomField
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public int? Value { get; set; }
	}
	[DataContract]
	public partial class CustomStringField : CustomField
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }
	}
	[DataContract]
	public partial class CustomByteField : CustomField
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public byte? Value { get; set; }
	}
	[DataContract]
	public partial class CustomBooleanField : CustomField
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public bool? Value { get; set; }
	}
	[DataContract]
	public partial class CustomDateTimeField : CustomField
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public DateTime? Value { get; set; }
	}
	[DataContract]
	public partial class CustomDoubleField : CustomField
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public double? Value { get; set; }
	}
	[DataContract]
	public partial class CustomShortField : CustomField
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public short? Value { get; set; }
	}
	[DataContract]
	public partial class CustomLongField : CustomField
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public long? Value { get; set; }
	}
	[DataContract]
	public partial class CustomDecimalField : CustomField
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public decimal? Value { get; set; }
	}
	[DataContract]
	public partial class CustomGuidField : CustomField
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public Guid? Value { get; set; }
	}
}
