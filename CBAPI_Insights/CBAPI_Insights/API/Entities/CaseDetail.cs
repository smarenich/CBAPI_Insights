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
	/// CaseDetail
	/// </summary>
	[DataContract]
	public partial class CaseDetail : Entity
	{
		/// <summary>
		/// Gets or Sets CaseID
		/// </summary>
		[DataMember(Name = "CaseID", EmitDefaultValue = false)]
		public StringValue CaseID { get; set; }

		/// <summary>
		/// Gets or Sets ClassID
		/// </summary>
		[DataMember(Name = "ClassID", EmitDefaultValue = false)]
		public StringValue ClassID { get; set; }

		/// <summary>
		/// Gets or Sets ClosingDate
		/// </summary>
		[DataMember(Name = "ClosingDate", EmitDefaultValue = false)]
		public DateTimeValue ClosingDate { get; set; }

		/// <summary>
		/// Gets or Sets DateReported
		/// </summary>
		[DataMember(Name = "DateReported", EmitDefaultValue = false)]
		public DateTimeValue DateReported { get; set; }

		/// <summary>
		/// Gets or Sets Estimation
		/// </summary>
		[DataMember(Name = "Estimation", EmitDefaultValue = false)]
		public StringValue Estimation { get; set; }

		/// <summary>
		/// Gets or Sets InitialResponse
		/// </summary>
		[DataMember(Name = "InitialResponse", EmitDefaultValue = false)]
		public StringValue InitialResponse { get; set; }

		/// <summary>
		/// Gets or Sets Owner
		/// </summary>
		[DataMember(Name = "Owner", EmitDefaultValue = false)]
		public StringValue Owner { get; set; }

		/// <summary>
		/// Gets or Sets Reason
		/// </summary>
		[DataMember(Name = "Reason", EmitDefaultValue = false)]
		public StringValue Reason { get; set; }

		/// <summary>
		/// Gets or Sets Severity
		/// </summary>
		[DataMember(Name = "Severity", EmitDefaultValue = false)]
		public StringValue Severity { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public StringValue Status { get; set; }

		/// <summary>
		/// Gets or Sets Subject
		/// </summary>
		[DataMember(Name = "Subject", EmitDefaultValue = false)]
		public StringValue Subject { get; set; }

		/// <summary>
		/// Gets or Sets Workgroup
		/// </summary>
		[DataMember(Name = "Workgroup", EmitDefaultValue = false)]
		public StringValue Workgroup { get; set; }
	}
}
