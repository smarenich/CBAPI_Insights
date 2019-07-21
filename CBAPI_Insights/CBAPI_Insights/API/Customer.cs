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
	/// Customer
	/// </summary>
	[DataContract]
	public partial class Customer : Entity
	{
		/// <summary>
		/// Gets or Sets NoteID
		/// </summary>
		[DataMember(Name = "NoteID", EmitDefaultValue = false)]
		public GuidValue NoteID { get; set; }

		/// <summary>
		/// Gets or Sets CreditLimit
		/// </summary>
		[DataMember(Name = "CreditLimit", EmitDefaultValue = false)]
		public DecimalValue CreditLimit { get; set; }

		/// <summary>
		/// Gets or Sets AccountRef
		/// </summary>
		[DataMember(Name = "AccountRef", EmitDefaultValue = false)]
		public StringValue AccountRef { get; set; }

		/// <summary>
		/// Gets or Sets ApplyOverdueCharges
		/// </summary>
		[DataMember(Name = "ApplyOverdueCharges", EmitDefaultValue = false)]
		public BooleanValue ApplyOverdueCharges { get; set; }

		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name = "Attributes", EmitDefaultValue = false)]
		public List<AttributeDetail> Attributes { get; set; }

		/// <summary>
		/// Gets or Sets AutoApplyPayments
		/// </summary>
		[DataMember(Name = "AutoApplyPayments", EmitDefaultValue = false)]
		public BooleanValue AutoApplyPayments { get; set; }

		/// <summary>
		/// Gets or Sets BillingAddressSameAsMain
		/// </summary>
		[DataMember(Name = "BillingAddressSameAsMain", EmitDefaultValue = false)]
		public BooleanValue BillingAddressSameAsMain { get; set; }

		/// <summary>
		/// Gets or Sets BillingContact
		/// </summary>
		[DataMember(Name = "BillingContact", EmitDefaultValue = false)]
		public Contact BillingContact { get; set; }

		/// <summary>
		/// Gets or Sets BillingContactSameAsMain
		/// </summary>
		[DataMember(Name = "BillingContactSameAsMain", EmitDefaultValue = false)]
		public BooleanValue BillingContactSameAsMain { get; set; }

		/// <summary>
		/// Gets or Sets Contacts
		/// </summary>
		[DataMember(Name = "Contacts", EmitDefaultValue = false)]
		public List<CustomerContact> Contacts { get; set; }

		/// <summary>
		/// Gets or Sets CreatedDateTime
		/// </summary>
		[DataMember(Name = "CreatedDateTime", EmitDefaultValue = false)]
		public DateTimeValue CreatedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CreditVerificationRules
		/// </summary>
		[DataMember(Name = "CreditVerificationRules", EmitDefaultValue = false)]
		public CreditVerificationRules CreditVerificationRules { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyID
		/// </summary>
		[DataMember(Name = "CurrencyID", EmitDefaultValue = false)]
		public StringValue CurrencyID { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyRateType
		/// </summary>
		[DataMember(Name = "CurrencyRateType", EmitDefaultValue = false)]
		public StringValue CurrencyRateType { get; set; }

		/// <summary>
		/// Gets or Sets CustomerClass
		/// </summary>
		[DataMember(Name = "CustomerClass", EmitDefaultValue = false)]
		public StringValue CustomerClass { get; set; }

		/// <summary>
		/// Gets or Sets CustomerID
		/// </summary>
		[DataMember(Name = "CustomerID", EmitDefaultValue = false)]
		public StringValue CustomerID { get; set; }

		/// <summary>
		/// Gets or Sets CustomerName
		/// </summary>
		[DataMember(Name = "CustomerName", EmitDefaultValue = false)]
		public StringValue CustomerName { get; set; }

		/// <summary>
		/// Gets or Sets EnableCurrencyOverride
		/// </summary>
		[DataMember(Name = "EnableCurrencyOverride", EmitDefaultValue = false)]
		public BooleanValue EnableCurrencyOverride { get; set; }

		/// <summary>
		/// Gets or Sets EnableRateOverride
		/// </summary>
		[DataMember(Name = "EnableRateOverride", EmitDefaultValue = false)]
		public BooleanValue EnableRateOverride { get; set; }

		/// <summary>
		/// Gets or Sets EnableWriteOffs
		/// </summary>
		[DataMember(Name = "EnableWriteOffs", EmitDefaultValue = false)]
		public BooleanValue EnableWriteOffs { get; set; }

		/// <summary>
		/// Gets or Sets FOBPoint
		/// </summary>
		[DataMember(Name = "FOBPoint", EmitDefaultValue = false)]
		public StringValue FOBPoint { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDateTime
		/// </summary>
		[DataMember(Name = "LastModifiedDateTime", EmitDefaultValue = false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets LeadTimedays
		/// </summary>
		[DataMember(Name = "LeadTimedays", EmitDefaultValue = false)]
		public ShortValue LeadTimedays { get; set; }

		/// <summary>
		/// Gets or Sets LocationName
		/// </summary>
		[DataMember(Name = "LocationName", EmitDefaultValue = false)]
		public StringValue LocationName { get; set; }

		/// <summary>
		/// Gets or Sets MainContact
		/// </summary>
		[DataMember(Name = "MainContact", EmitDefaultValue = false)]
		public Contact MainContact { get; set; }

		/// <summary>
		/// Gets or Sets MultiCurrencyStatements
		/// </summary>
		[DataMember(Name = "MultiCurrencyStatements", EmitDefaultValue = false)]
		public BooleanValue MultiCurrencyStatements { get; set; }

		/// <summary>
		/// Gets or Sets OrderPriority
		/// </summary>
		[DataMember(Name = "OrderPriority", EmitDefaultValue = false)]
		public ShortValue OrderPriority { get; set; }

		/// <summary>
		/// Gets or Sets ParentRecord
		/// </summary>
		[DataMember(Name = "ParentRecord", EmitDefaultValue = false)]
		public StringValue ParentRecord { get; set; }

		/// <summary>
		/// Gets or Sets PriceClassID
		/// </summary>
		[DataMember(Name = "PriceClassID", EmitDefaultValue = false)]
		public StringValue PriceClassID { get; set; }

		/// <summary>
		/// Gets or Sets PrintDunningLetters
		/// </summary>
		[DataMember(Name = "PrintDunningLetters", EmitDefaultValue = false)]
		public BooleanValue PrintDunningLetters { get; set; }

		/// <summary>
		/// Gets or Sets PrintInvoices
		/// </summary>
		[DataMember(Name = "PrintInvoices", EmitDefaultValue = false)]
		public BooleanValue PrintInvoices { get; set; }

		/// <summary>
		/// Gets or Sets PrintStatements
		/// </summary>
		[DataMember(Name = "PrintStatements", EmitDefaultValue = false)]
		public BooleanValue PrintStatements { get; set; }

		/// <summary>
		/// Gets or Sets ResidentialDelivery
		/// </summary>
		[DataMember(Name = "ResidentialDelivery", EmitDefaultValue = false)]
		public BooleanValue ResidentialDelivery { get; set; }

		/// <summary>
		/// Gets or Sets SaturdayDelivery
		/// </summary>
		[DataMember(Name = "SaturdayDelivery", EmitDefaultValue = false)]
		public BooleanValue SaturdayDelivery { get; set; }

		/// <summary>
		/// Gets or Sets SendDunningLettersbyEmail
		/// </summary>
		[DataMember(Name = "SendDunningLettersbyEmail", EmitDefaultValue = false)]
		public BooleanValue SendDunningLettersbyEmail { get; set; }

		/// <summary>
		/// Gets or Sets SendInvoicesbyEmail
		/// </summary>
		[DataMember(Name = "SendInvoicesbyEmail", EmitDefaultValue = false)]
		public BooleanValue SendInvoicesbyEmail { get; set; }

		/// <summary>
		/// Gets or Sets SendStatementsbyEmail
		/// </summary>
		[DataMember(Name = "SendStatementsbyEmail", EmitDefaultValue = false)]
		public BooleanValue SendStatementsbyEmail { get; set; }

		/// <summary>
		/// Gets or Sets ShippingAddressSameAsMain
		/// </summary>
		[DataMember(Name = "ShippingAddressSameAsMain", EmitDefaultValue = false)]
		public BooleanValue ShippingAddressSameAsMain { get; set; }

		/// <summary>
		/// Gets or Sets ShippingBranch
		/// </summary>
		[DataMember(Name = "ShippingBranch", EmitDefaultValue = false)]
		public StringValue ShippingBranch { get; set; }

		/// <summary>
		/// Gets or Sets ShippingContact
		/// </summary>
		[DataMember(Name = "ShippingContact", EmitDefaultValue = false)]
		public Contact ShippingContact { get; set; }

		/// <summary>
		/// Gets or Sets ShippingContactSameAsMain
		/// </summary>
		[DataMember(Name = "ShippingContactSameAsMain", EmitDefaultValue = false)]
		public BooleanValue ShippingContactSameAsMain { get; set; }

		/// <summary>
		/// Gets or Sets ShippingRule
		/// </summary>
		[DataMember(Name = "ShippingRule", EmitDefaultValue = false)]
		public StringValue ShippingRule { get; set; }

		/// <summary>
		/// Gets or Sets ShippingTerms
		/// </summary>
		[DataMember(Name = "ShippingTerms", EmitDefaultValue = false)]
		public StringValue ShippingTerms { get; set; }

		/// <summary>
		/// Gets or Sets ShippingZoneID
		/// </summary>
		[DataMember(Name = "ShippingZoneID", EmitDefaultValue = false)]
		public StringValue ShippingZoneID { get; set; }

		/// <summary>
		/// Gets or Sets ShipVia
		/// </summary>
		[DataMember(Name = "ShipVia", EmitDefaultValue = false)]
		public StringValue ShipVia { get; set; }

		/// <summary>
		/// Gets or Sets StatementCycleID
		/// </summary>
		[DataMember(Name = "StatementCycleID", EmitDefaultValue = false)]
		public StringValue StatementCycleID { get; set; }

		/// <summary>
		/// Gets or Sets StatementType
		/// </summary>
		[DataMember(Name = "StatementType", EmitDefaultValue = false)]
		public StringValue StatementType { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public StringValue Status { get; set; }

		/// <summary>
		/// Gets or Sets TaxRegistrationID
		/// </summary>
		[DataMember(Name = "TaxRegistrationID", EmitDefaultValue = false)]
		public StringValue TaxRegistrationID { get; set; }

		/// <summary>
		/// Gets or Sets TaxZone
		/// </summary>
		[DataMember(Name = "TaxZone", EmitDefaultValue = false)]
		public StringValue TaxZone { get; set; }

		/// <summary>
		/// Gets or Sets Terms
		/// </summary>
		[DataMember(Name = "Terms", EmitDefaultValue = false)]
		public StringValue Terms { get; set; }

		/// <summary>
		/// Gets or Sets WarehouseID
		/// </summary>
		[DataMember(Name = "WarehouseID", EmitDefaultValue = false)]
		public StringValue WarehouseID { get; set; }

		/// <summary>
		/// Gets or Sets WriteOffLimit
		/// </summary>
		[DataMember(Name = "WriteOffLimit", EmitDefaultValue = false)]
		public DecimalValue WriteOffLimit { get; set; }
	}

}
