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
	/// FinancialSettings
	/// </summary>
	[DataContract]
	public partial class FinancialSettings : Entity
	{
		/// <summary>
		/// Gets or Sets BillSeparately
		/// </summary>
		[DataMember(Name = "BillSeparately", EmitDefaultValue = false)]
		public BooleanValue BillSeparately { get; set; }

		/// <summary>
		/// Gets or Sets Branch
		/// </summary>
		[DataMember(Name = "Branch", EmitDefaultValue = false)]
		public StringValue Branch { get; set; }

		/// <summary>
		/// Gets or Sets CashDiscountDate
		/// </summary>
		[DataMember(Name = "CashDiscountDate", EmitDefaultValue = false)]
		public DateTimeValue CashDiscountDate { get; set; }

		/// <summary>
		/// Gets or Sets CustomerTaxZone
		/// </summary>
		[DataMember(Name = "CustomerTaxZone", EmitDefaultValue = false)]
		public StringValue CustomerTaxZone { get; set; }

		/// <summary>
		/// Gets or Sets DueDate
		/// </summary>
		[DataMember(Name = "DueDate", EmitDefaultValue = false)]
		public DateTimeValue DueDate { get; set; }

		/// <summary>
		/// Gets or Sets EntityUsageType
		/// </summary>
		[DataMember(Name = "EntityUsageType", EmitDefaultValue = false)]
		public StringValue EntityUsageType { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceDate
		/// </summary>
		[DataMember(Name = "InvoiceDate", EmitDefaultValue = false)]
		public DateTimeValue InvoiceDate { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceNbr
		/// </summary>
		[DataMember(Name = "InvoiceNbr", EmitDefaultValue = false)]
		public StringValue InvoiceNbr { get; set; }

		/// <summary>
		/// Gets or Sets OriginalOrderNbr
		/// </summary>
		[DataMember(Name = "OriginalOrderNbr", EmitDefaultValue = false)]
		public StringValue OriginalOrderNbr { get; set; }

		/// <summary>
		/// Gets or Sets OriginalOrderType
		/// </summary>
		[DataMember(Name = "OriginalOrderType", EmitDefaultValue = false)]
		public StringValue OriginalOrderType { get; set; }

		/// <summary>
		/// Gets or Sets OverrideTaxZone
		/// </summary>
		[DataMember(Name = "OverrideTaxZone", EmitDefaultValue = false)]
		public BooleanValue OverrideTaxZone { get; set; }

		/// <summary>
		/// Gets or Sets Owner
		/// </summary>
		[DataMember(Name = "Owner", EmitDefaultValue = false)]
		public StringValue Owner { get; set; }

		/// <summary>
		/// Gets or Sets PostPeriod
		/// </summary>
		[DataMember(Name = "PostPeriod", EmitDefaultValue = false)]
		public StringValue PostPeriod { get; set; }

		/// <summary>
		/// Gets or Sets Terms
		/// </summary>
		[DataMember(Name = "Terms", EmitDefaultValue = false)]
		public StringValue Terms { get; set; }
	}
}
