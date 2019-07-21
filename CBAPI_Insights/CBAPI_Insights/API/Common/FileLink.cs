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
	/// FileLink
	/// </summary>
	[DataContract]
	public partial class FileLink
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public Guid? Id { get; set; }

		/// <summary>
		/// Gets or Sets Filename
		/// </summary>
		[DataMember(Name = "filename", EmitDefaultValue = false)]
		public string Filename { get; set; }

		/// <summary>
		/// Gets or Sets Href
		/// </summary>
		[DataMember(Name = "href", EmitDefaultValue = false)]
		public string Href { get; set; }
	}
}
