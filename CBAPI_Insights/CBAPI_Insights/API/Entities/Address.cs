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
	/// Address
	/// </summary>
	[DataContract]
	public partial class Address : Entity
	{
		/// <summary>
		/// Gets or Sets AddressLine1
		/// </summary>
		[DataMember(Name = "AddressLine1", EmitDefaultValue = false)]
		public StringValue AddressLine1 { get; set; }

		/// <summary>
		/// Gets or Sets AddressLine2
		/// </summary>
		[DataMember(Name = "AddressLine2", EmitDefaultValue = false)]
		public StringValue AddressLine2 { get; set; }

		/// <summary>
		/// Gets or Sets City
		/// </summary>
		[DataMember(Name = "City", EmitDefaultValue = false)]
		public StringValue City { get; set; }

		/// <summary>
		/// Gets or Sets Country
		/// </summary>
		[DataMember(Name = "Country", EmitDefaultValue = false)]
		public StringValue Country { get; set; }

		/// <summary>
		/// Gets or Sets PostalCode
		/// </summary>
		[DataMember(Name = "PostalCode", EmitDefaultValue = false)]
		public StringValue PostalCode { get; set; }

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "State", EmitDefaultValue = false)]
		public StringValue State { get; set; }

		/// <summary>
		/// Gets or Sets Validated
		/// </summary>
		[DataMember(Name = "Validated", EmitDefaultValue = false)]
		public BooleanValue Validated { get; set; }
	}

}
