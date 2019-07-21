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
	/// CreditVerificationRules
	/// </summary>
	[DataContract]
	public partial class CreditVerificationRules : Entity
	{
		/// <summary>
		/// Gets or Sets CreditDaysPastDue
		/// </summary>
		[DataMember(Name = "CreditDaysPastDue", EmitDefaultValue = false)]
		public ShortValue CreditDaysPastDue { get; set; }

		/// <summary>
		/// Gets or Sets CreditLimit
		/// </summary>
		[DataMember(Name = "CreditLimit", EmitDefaultValue = false)]
		public DecimalValue CreditLimit { get; set; }

		/// <summary>
		/// Gets or Sets CreditVerification
		/// </summary>
		[DataMember(Name = "CreditVerification", EmitDefaultValue = false)]
		public StringValue CreditVerification { get; set; }

		/// <summary>
		/// Gets or Sets FirstDueDate
		/// </summary>
		[DataMember(Name = "FirstDueDate", EmitDefaultValue = false)]
		public DateTimeValue FirstDueDate { get; set; }

		/// <summary>
		/// Gets or Sets OpenOrdersBalance
		/// </summary>
		[DataMember(Name = "OpenOrdersBalance", EmitDefaultValue = false)]
		public DecimalValue OpenOrdersBalance { get; set; }

		/// <summary>
		/// Gets or Sets RemainingCreditLimit
		/// </summary>
		[DataMember(Name = "RemainingCreditLimit", EmitDefaultValue = false)]
		public DecimalValue RemainingCreditLimit { get; set; }

		/// <summary>
		/// Gets or Sets UnreleasedBalance
		/// </summary>
		[DataMember(Name = "UnreleasedBalance", EmitDefaultValue = false)]
		public DecimalValue UnreleasedBalance { get; set; }
	}
}
