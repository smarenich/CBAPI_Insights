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
	/// Contact
	/// </summary>
	[DataContract]
	public partial class Contact : Entity
	{
		/// <summary>
		/// Gets or Sets FullName
		/// </summary>
		[DataMember(Name = "FullName", EmitDefaultValue = false)]
		public StringValue FullName { get; set; }

		/// <summary>
		/// Gets or Sets Active
		/// </summary>
		[DataMember(Name = "Active", EmitDefaultValue = false)]
		public BooleanValue Active { get; set; }

		/// <summary>
		/// Gets or Sets Address
		/// </summary>
		[DataMember(Name = "Address", EmitDefaultValue = false)]
		public Address Address { get; set; }

		/// <summary>
		/// Gets or Sets AddressIsSameAsInAccount
		/// </summary>
		[DataMember(Name = "AddressIsSameAsInAccount", EmitDefaultValue = false)]
		public BooleanValue AddressIsSameAsInAccount { get; set; }

		/// <summary>
		/// Gets or Sets AddressValidated
		/// </summary>
		[DataMember(Name = "AddressValidated", EmitDefaultValue = false)]
		public BooleanValue AddressValidated { get; set; }

		/// <summary>
		/// Gets or Sets Attention
		/// </summary>
		[DataMember(Name = "Attention", EmitDefaultValue = false)]
		public StringValue Attention { get; set; }

		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name = "Attributes", EmitDefaultValue = false)]
		public List<AttributeDetail> Attributes { get; set; }

		/// <summary>
		/// Gets or Sets BusinessAccount
		/// </summary>
		[DataMember(Name = "BusinessAccount", EmitDefaultValue = false)]
		public StringValue BusinessAccount { get; set; }

		/// <summary>
		/// Gets or Sets Cases
		/// </summary>
		[DataMember(Name = "Cases", EmitDefaultValue = false)]
		public List<CaseDetail> Cases { get; set; }

		/// <summary>
		/// Gets or Sets CompanyName
		/// </summary>
		[DataMember(Name = "CompanyName", EmitDefaultValue = false)]
		public StringValue CompanyName { get; set; }

		/// <summary>
		/// Gets or Sets ContactClass
		/// </summary>
		[DataMember(Name = "ContactClass", EmitDefaultValue = false)]
		public StringValue ContactClass { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public IntValue ContactID { get; set; }

		/// <summary>
		/// Gets or Sets ContactMethod
		/// </summary>
		[DataMember(Name = "ContactMethod", EmitDefaultValue = false)]
		public StringValue ContactMethod { get; set; }

		/// <summary>
		/// Gets or Sets ConvertedBy
		/// </summary>
		[DataMember(Name = "ConvertedBy", EmitDefaultValue = false)]
		public StringValue ConvertedBy { get; set; }

		/// <summary>
		/// Gets or Sets DateOfBirth
		/// </summary>
		[DataMember(Name = "DateOfBirth", EmitDefaultValue = false)]
		public DateTimeValue DateOfBirth { get; set; }

		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name = "DisplayName", EmitDefaultValue = false)]
		public StringValue DisplayName { get; set; }

		/// <summary>
		/// Gets or Sets DoNotCall
		/// </summary>
		[DataMember(Name = "DoNotCall", EmitDefaultValue = false)]
		public BooleanValue DoNotCall { get; set; }

		/// <summary>
		/// Gets or Sets DoNotEmail
		/// </summary>
		[DataMember(Name = "DoNotEmail", EmitDefaultValue = false)]
		public BooleanValue DoNotEmail { get; set; }

		/// <summary>
		/// Gets or Sets DoNotFax
		/// </summary>
		[DataMember(Name = "DoNotFax", EmitDefaultValue = false)]
		public BooleanValue DoNotFax { get; set; }

		/// <summary>
		/// Gets or Sets DoNotMail
		/// </summary>
		[DataMember(Name = "DoNotMail", EmitDefaultValue = false)]
		public BooleanValue DoNotMail { get; set; }

		/// <summary>
		/// Gets or Sets Duplicate
		/// </summary>
		[DataMember(Name = "Duplicate", EmitDefaultValue = false)]
		public StringValue Duplicate { get; set; }

		/// <summary>
		/// Gets or Sets DuplicateFound
		/// </summary>
		[DataMember(Name = "DuplicateFound", EmitDefaultValue = false)]
		public BooleanValue DuplicateFound { get; set; }

		/// <summary>
		/// Gets or Sets Email
		/// </summary>
		[DataMember(Name = "Email", EmitDefaultValue = false)]
		public StringValue Email { get; set; }

		/// <summary>
		/// Gets or Sets Fax
		/// </summary>
		[DataMember(Name = "Fax", EmitDefaultValue = false)]
		public StringValue Fax { get; set; }

		/// <summary>
		/// Gets or Sets FaxType
		/// </summary>
		[DataMember(Name = "FaxType", EmitDefaultValue = false)]
		public StringValue FaxType { get; set; }

		/// <summary>
		/// Gets or Sets FirstName
		/// </summary>
		[DataMember(Name = "FirstName", EmitDefaultValue = false)]
		public StringValue FirstName { get; set; }

		/// <summary>
		/// Gets or Sets Gender
		/// </summary>
		[DataMember(Name = "Gender", EmitDefaultValue = false)]
		public StringValue Gender { get; set; }

		/// <summary>
		/// Gets or Sets Image
		/// </summary>
		[DataMember(Name = "Image", EmitDefaultValue = false)]
		public StringValue Image { get; set; }

		/// <summary>
		/// Gets or Sets JobTitle
		/// </summary>
		[DataMember(Name = "JobTitle", EmitDefaultValue = false)]
		public StringValue JobTitle { get; set; }

		/// <summary>
		/// Gets or Sets LanguageOrLocale
		/// </summary>
		[DataMember(Name = "LanguageOrLocale", EmitDefaultValue = false)]
		public StringValue LanguageOrLocale { get; set; }

		/// <summary>
		/// Gets or Sets LastIncomingActivity
		/// </summary>
		[DataMember(Name = "LastIncomingActivity", EmitDefaultValue = false)]
		public DateTimeValue LastIncomingActivity { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDateTime
		/// </summary>
		[DataMember(Name = "LastModifiedDateTime", EmitDefaultValue = false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets LastName
		/// </summary>
		[DataMember(Name = "LastName", EmitDefaultValue = false)]
		public StringValue LastName { get; set; }

		/// <summary>
		/// Gets or Sets LastOutgoingActivity
		/// </summary>
		[DataMember(Name = "LastOutgoingActivity", EmitDefaultValue = false)]
		public DateTimeValue LastOutgoingActivity { get; set; }

		/// <summary>
		/// Gets or Sets MaritalStatus
		/// </summary>
		[DataMember(Name = "MaritalStatus", EmitDefaultValue = false)]
		public StringValue MaritalStatus { get; set; }

		/// <summary>
		/// Gets or Sets MiddleName
		/// </summary>
		[DataMember(Name = "MiddleName", EmitDefaultValue = false)]
		public StringValue MiddleName { get; set; }

		/// <summary>
		/// Gets or Sets NoMarketing
		/// </summary>
		[DataMember(Name = "NoMarketing", EmitDefaultValue = false)]
		public BooleanValue NoMarketing { get; set; }

		/// <summary>
		/// Gets or Sets NoMassMail
		/// </summary>
		[DataMember(Name = "NoMassMail", EmitDefaultValue = false)]
		public BooleanValue NoMassMail { get; set; }

		/// <summary>
		/// Gets or Sets Owner
		/// </summary>
		[DataMember(Name = "Owner", EmitDefaultValue = false)]
		public StringValue Owner { get; set; }

		/// <summary>
		/// Gets or Sets OwnerEmployeeName
		/// </summary>
		[DataMember(Name = "OwnerEmployeeName", EmitDefaultValue = false)]
		public StringValue OwnerEmployeeName { get; set; }

		/// <summary>
		/// Gets or Sets ParentAccount
		/// </summary>
		[DataMember(Name = "ParentAccount", EmitDefaultValue = false)]
		public StringValue ParentAccount { get; set; }

		/// <summary>
		/// Gets or Sets Phone1
		/// </summary>
		[DataMember(Name = "Phone1", EmitDefaultValue = false)]
		public StringValue Phone1 { get; set; }

		/// <summary>
		/// Gets or Sets Phone1Type
		/// </summary>
		[DataMember(Name = "Phone1Type", EmitDefaultValue = false)]
		public StringValue Phone1Type { get; set; }

		/// <summary>
		/// Gets or Sets Phone2
		/// </summary>
		[DataMember(Name = "Phone2", EmitDefaultValue = false)]
		public StringValue Phone2 { get; set; }

		/// <summary>
		/// Gets or Sets Phone2Type
		/// </summary>
		[DataMember(Name = "Phone2Type", EmitDefaultValue = false)]
		public StringValue Phone2Type { get; set; }

		/// <summary>
		/// Gets or Sets Phone3
		/// </summary>
		[DataMember(Name = "Phone3", EmitDefaultValue = false)]
		public StringValue Phone3 { get; set; }

		/// <summary>
		/// Gets or Sets Phone3Type
		/// </summary>
		[DataMember(Name = "Phone3Type", EmitDefaultValue = false)]
		public StringValue Phone3Type { get; set; }

		/// <summary>
		/// Gets or Sets QualificationDate
		/// </summary>
		[DataMember(Name = "QualificationDate", EmitDefaultValue = false)]
		public DateTimeValue QualificationDate { get; set; }

		/// <summary>
		/// Gets or Sets Reason
		/// </summary>
		[DataMember(Name = "Reason", EmitDefaultValue = false)]
		public StringValue Reason { get; set; }

		/// <summary>
		/// Gets or Sets Source
		/// </summary>
		[DataMember(Name = "Source", EmitDefaultValue = false)]
		public StringValue Source { get; set; }

		/// <summary>
		/// Gets or Sets SourceCampaign
		/// </summary>
		[DataMember(Name = "SourceCampaign", EmitDefaultValue = false)]
		public StringValue SourceCampaign { get; set; }

		/// <summary>
		/// Gets or Sets SpouseOrPartnerName
		/// </summary>
		[DataMember(Name = "SpouseOrPartnerName", EmitDefaultValue = false)]
		public StringValue SpouseOrPartnerName { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public StringValue Status { get; set; }

		/// <summary>
		/// Gets or Sets Synchronize
		/// </summary>
		[DataMember(Name = "Synchronize", EmitDefaultValue = false)]
		public BooleanValue Synchronize { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public StringValue Title { get; set; }

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "Type", EmitDefaultValue = false)]
		public StringValue Type { get; set; }

		/// <summary>
		/// Gets or Sets WebSite
		/// </summary>
		[DataMember(Name = "WebSite", EmitDefaultValue = false)]
		public StringValue WebSite { get; set; }

		/// <summary>
		/// Gets or Sets Workgroup
		/// </summary>
		[DataMember(Name = "Workgroup", EmitDefaultValue = false)]
		public StringValue Workgroup { get; set; }

		/// <summary>
		/// Gets or Sets WorkgroupDescription
		/// </summary>
		[DataMember(Name = "WorkgroupDescription", EmitDefaultValue = false)]
		public StringValue WorkgroupDescription { get; set; }
	}

}
