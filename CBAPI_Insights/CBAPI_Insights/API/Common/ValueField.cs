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
	[DataContract]
	public partial class IntValue
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public int? Value { get; set; }
	}
	[DataContract]
	public partial class BooleanValue
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public bool? Value { get; set; }
	}
	[DataContract]
	public partial class StringValue
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }
	}
	[DataContract]
	public partial class ByteValue
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public byte? Value { get; set; }
	}
	[DataContract]
	public partial class DateTimeValue
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public DateTime? Value { get; set; }
	}
	[DataContract]
	public partial class DoubleValue
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public double? Value { get; set; }
	}
	[DataContract]
	public partial class ShortValue
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public short? Value { get; set; }
	}
	[DataContract]
	public partial class LongValue
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public long? Value { get; set; }
	}
	[DataContract]
	public partial class DecimalValue
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public decimal? Value { get; set; }
	}
	[DataContract]
	public partial class GuidValue
	{
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public Guid? Value { get; set; }
	}
}
