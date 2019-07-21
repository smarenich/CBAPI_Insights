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
	/// AttributeValue
	/// </summary>
	[DataContract]
	public partial class AttributeValue : Entity
	{
		/// <summary>
		/// Gets or Sets AttributeID
		/// </summary>
		[DataMember(Name = "AttributeID", EmitDefaultValue = false)]
		public StringValue AttributeID { get; set; }

		/// <summary>
		/// Gets or Sets Required
		/// </summary>
		[DataMember(Name = "Required", EmitDefaultValue = false)]
		public BooleanValue Required { get; set; }

		/// <summary>
		/// Gets or Sets Value
		/// </summary>
		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public StringValue Value { get; set; }
	}
}
