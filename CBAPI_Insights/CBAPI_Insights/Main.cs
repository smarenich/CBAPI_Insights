using CBAPI_Insights.API;
using PX.Api.ContractBased;
using PX.Api.ContractBased.Models;
using PX.Common;
using PX.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PX.Objects.GL;

namespace CBAPI_Insights
{
	public class CBAPIJournalEntryExt : PXGraphExtension<JournalEntry>
	{
		public PXAction<Batch> Test;
		[PXButton]
		[PXUIField(DisplayName = "Test CB API Insights")]
		public void test()
		{
			using (CBAPIService service = new CBAPIService("Default", "18.200.001"))
			{
				Customer customer = new Customer()
				{
					CustomerID = "TESTC".ValueField(),
					CustomerName = "Test Customer".ValueField(),
					CustomerClass = "LOCAL".ValueField(),
					MainContact = new Contact()
					{
						Email = "a@b.c".ValueField(),
						Address = new Address()
						{
							City = "Singapore".ValueField(),
						}
					}
				};

				customer = service.Put(customer);

				customer = service.Get(new Customer() { CustomerID = "TESTC".SearchField() });
			}
		}
	}
}
