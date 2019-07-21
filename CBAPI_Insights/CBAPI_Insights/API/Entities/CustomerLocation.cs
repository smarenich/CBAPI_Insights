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
	/// CustomerLocation
	/// </summary>
	[DataContract]
	public partial class CustomerLocation : Entity
	{
		/// <summary>
		/// Gets or Sets NoteID
		/// </summary>
		[DataMember(Name = "NoteID", EmitDefaultValue = false)]
		public GuidValue NoteID { get; set; }

		/// <summary>
		/// Gets or Sets Active
		/// </summary>
		[DataMember(Name = "Active", EmitDefaultValue = false)]
		public BooleanValue Active { get; set; }

		/// <summary>
		/// Gets or Sets AddressSameAsMain
		/// </summary>
		[DataMember(Name = "AddressSameAsMain", EmitDefaultValue = false)]
		public BooleanValue AddressSameAsMain { get; set; }

		/// <summary>
		/// Gets or Sets Calendar
		/// </summary>
		[DataMember(Name = "Calendar", EmitDefaultValue = false)]
		public StringValue Calendar { get; set; }

		/// <summary>
		/// Gets or Sets ContactSameAsMain
		/// </summary>
		[DataMember(Name = "ContactSameAsMain", EmitDefaultValue = false)]
		public BooleanValue ContactSameAsMain { get; set; }

		/// <summary>
		/// Gets or Sets CreatedDateTime
		/// </summary>
		[DataMember(Name = "CreatedDateTime", EmitDefaultValue = false)]
		public DateTimeValue CreatedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets Customer
		/// </summary>
		[DataMember(Name = "Customer", EmitDefaultValue = false)]
		public StringValue Customer { get; set; }

		/// <summary>
		/// Gets or Sets DefaultProject
		/// </summary>
		[DataMember(Name = "DefaultProject", EmitDefaultValue = false)]
		public StringValue DefaultProject { get; set; }

		/// <summary>
		/// Gets or Sets EntityUsageType
		/// </summary>
		[DataMember(Name = "EntityUsageType", EmitDefaultValue = false)]
		public StringValue EntityUsageType { get; set; }

		/// <summary>
		/// Gets or Sets FedExGroundCollect
		/// </summary>
		[DataMember(Name = "FedExGroundCollect", EmitDefaultValue = false)]
		public BooleanValue FedExGroundCollect { get; set; }

		/// <summary>
		/// Gets or Sets FOBPoint
		/// </summary>
		[DataMember(Name = "FOBPoint", EmitDefaultValue = false)]
		public StringValue FOBPoint { get; set; }

		/// <summary>
		/// Gets or Sets Insurance
		/// </summary>
		[DataMember(Name = "Insurance", EmitDefaultValue = false)]
		public BooleanValue Insurance { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDateTime
		/// </summary>
		[DataMember(Name = "LastModifiedDateTime", EmitDefaultValue = false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets LeadTimeDays
		/// </summary>
		[DataMember(Name = "LeadTimeDays", EmitDefaultValue = false)]
		public ShortValue LeadTimeDays { get; set; }

		/// <summary>
		/// Gets or Sets LocationContact
		/// </summary>
		[DataMember(Name = "LocationContact", EmitDefaultValue = false)]
		public Contact LocationContact { get; set; }

		/// <summary>
		/// Gets or Sets LocationID
		/// </summary>
		[DataMember(Name = "LocationID", EmitDefaultValue = false)]
		public StringValue LocationID { get; set; }

		/// <summary>
		/// Gets or Sets LocationName
		/// </summary>
		[DataMember(Name = "LocationName", EmitDefaultValue = false)]
		public StringValue LocationName { get; set; }

		/// <summary>
		/// Gets or Sets OrderPriority
		/// </summary>
		[DataMember(Name = "OrderPriority", EmitDefaultValue = false)]
		public ShortValue OrderPriority { get; set; }

		/// <summary>
		/// Gets or Sets PriceClass
		/// </summary>
		[DataMember(Name = "PriceClass", EmitDefaultValue = false)]
		public StringValue PriceClass { get; set; }

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
		/// Gets or Sets ShippingBranch
		/// </summary>
		[DataMember(Name = "ShippingBranch", EmitDefaultValue = false)]
		public StringValue ShippingBranch { get; set; }

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
		/// Gets or Sets ShippingZone
		/// </summary>
		[DataMember(Name = "ShippingZone", EmitDefaultValue = false)]
		public StringValue ShippingZone { get; set; }

		/// <summary>
		/// Gets or Sets ShipVia
		/// </summary>
		[DataMember(Name = "ShipVia", EmitDefaultValue = false)]
		public StringValue ShipVia { get; set; }

		/// <summary>
		/// Gets or Sets TaxExemptionNbr
		/// </summary>
		[DataMember(Name = "TaxExemptionNbr", EmitDefaultValue = false)]
		public StringValue TaxExemptionNbr { get; set; }

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
		/// Gets or Sets Warehouse
		/// </summary>
		[DataMember(Name = "Warehouse", EmitDefaultValue = false)]
		public StringValue Warehouse { get; set; }
	}
}
