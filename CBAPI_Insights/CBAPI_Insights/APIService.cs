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
	public class CBAPIService : IDisposable
	{
		protected IEntityHelper EntityHelper;
		protected PXLoginScope LoginScope;
		protected PXInvariantCultureScope CultureScope;

		public CBAPIService(String endpoint, string version)
		{
			EntityHelper = ServiceLocator.Current.GetInstance<Func<string, string, IEntityHelper>>()(endpoint, version);

			string userName = "admin";
			if (PXDatabase.Companies.Length > 0)
			{
				var company = PXAccess.GetCompanyName();
				if (string.IsNullOrEmpty(company)) company = PXDatabase.Companies[0];
				userName = userName + "@" + company;
			}
			LoginScope = new PXLoginScope(userName, PXAccess.GetAdministratorRoles());
			CultureScope = new PX.Common.PXInvariantCultureScope();

			if (PXContext.GetSlot<System.Web.SessionState.ISessionStateItemCollection>() == null)
				PXContext.SetSlot<System.Web.SessionState.ISessionStateItemCollection>(new System.Web.SessionState.SessionStateItemCollection());
		}
		public void Dispose()
		{
			CultureScope.Dispose();
			((IDisposable)LoginScope).Dispose();
		}

		public T[] GetAll<T>(T impl, DateTime? lastModifiedDateTime = null)
			where T : CBAPI_Insights.API.Entity
		{
			EntityImpl converted = impl == null ? APIHelper.AddObjectField(typeof(T).Name) : APIHelper.ConvertImpl(impl);
			converted.ReturnBehavior = ReturnBehavior.OnlySpecified;
			if (lastModifiedDateTime == null) converted.AddReturnField("LastModifiedDateTime");
			else converted.AddSearchField("LastModifiedDateTime", lastModifiedDateTime?.ToString(CultureInfo.InvariantCulture), CBAPI_Insights.API.GeneralCondition.IsGreaterThanOrEqualsTo);
			converted.AddReturnField("NoteID");

			EntityImpl[] response = EntityHelper.GetList(converted);

			IEnumerable<T> results = response.Select(r => (T)APIHelper.ConvertImpl(r, typeof(T).Namespace));

			return results.ToArray();
		}
		public T GetByID<T>(Guid? noteID)
			where T : CBAPI_Insights.API.Entity
		{
			EntityImpl converted = APIHelper.AddObjectField(typeof(T).Name);
			converted.ReturnBehavior = ReturnBehavior.All;
			converted.AddSearchField("NoteID", noteID?.ToString(), CBAPI_Insights.API.GeneralCondition.Equal);

			EntityImpl response = EntityHelper.Get(converted);

			T result = (T)APIHelper.ConvertImpl(response, typeof(T).Namespace);

			return result;
		}
		public T Get<T>(T impl)
			where T : CBAPI_Insights.API.Entity
		{
			EntityImpl converted = APIHelper.ConvertImpl(impl);
			converted.ReturnBehavior = ReturnBehavior.All;

			EntityImpl response = EntityHelper.Get(converted);

			T result = (T)APIHelper.ConvertImpl(response, typeof(T).Namespace);

			return result;
		}
		public T Put<T>(T impl, Guid? noteID = null)
			where T : CBAPI_Insights.API.Entity
		{
			EntityImpl converted = APIHelper.ConvertImpl(impl);
			converted.ReturnBehavior = ReturnBehavior.All;
			if (noteID != null) converted.AddSearchField("NoteID", noteID?.ToString(), CBAPI_Insights.API.GeneralCondition.Equal);

			EntityImpl response = EntityHelper.Put(converted);

			T result = (T)APIHelper.ConvertImpl(response, typeof(T).Namespace);

			return result;
		}
	}
}
