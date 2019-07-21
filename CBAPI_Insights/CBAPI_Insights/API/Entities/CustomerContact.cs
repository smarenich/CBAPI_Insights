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
	/// CustomerContact
	/// </summary>
	[DataContract]
	public partial class CustomerContact : Entity
	{
		/// <summary>
		/// Gets or Sets Contact
		/// </summary>
		[DataMember(Name = "Contact", EmitDefaultValue = false)]
		public Contact Contact { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public IntValue ContactID { get; set; }
	}
}
