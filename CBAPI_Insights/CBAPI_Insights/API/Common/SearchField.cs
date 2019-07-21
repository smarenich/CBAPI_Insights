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
	public partial class IntSearch : IntValue
	{
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public IntCondition Condition { get; set; }

		[DataMember(Name = "value2", EmitDefaultValue = false)]
		public byte? Value2 { get; set; }
	}
	[DataContract]
	public partial class BooleanSearch : BooleanValue
	{
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public BooleanCondition Condition { get; set; }

		[DataMember(Name = "value2", EmitDefaultValue = false)]
		public byte? Value2 { get; set; }
	}
	[DataContract]
	public partial class StringSearch : StringValue
	{
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public StringCondition Condition { get; set; }

		[DataMember(Name = "value2", EmitDefaultValue = false)]
		public byte? Value2 { get; set; }
	}
	[DataContract]
	public partial class ByteSearch : ByteValue
	{
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public ByteCondition Condition { get; set; }

		[DataMember(Name = "value2", EmitDefaultValue = false)]
		public byte? Value2 { get; set; }
	}
	[DataContract]
	public partial class DateTimeSearch : DateTimeValue
	{
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public DateTimeCondition Condition { get; set; }

		[DataMember(Name = "value2", EmitDefaultValue = false)]
		public byte? Value2 { get; set; }
	}
	[DataContract]
	public partial class DoubleSearch : DoubleValue
	{
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public DoubleCondition Condition { get; set; }

		[DataMember(Name = "value2", EmitDefaultValue = false)]
		public byte? Value2 { get; set; }
	}
	[DataContract]
	public partial class ShortSearch : ShortValue
	{
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public ShortCondition Condition { get; set; }

		[DataMember(Name = "value2", EmitDefaultValue = false)]
		public byte? Value2 { get; set; }
	}
	[DataContract]
	public partial class LongSearch : LongValue
	{
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public LongCondition Condition { get; set; }

		[DataMember(Name = "value2", EmitDefaultValue = false)]
		public byte? Value2 { get; set; }
	}
	[DataContract]
	public partial class DecimalSearch : DecimalValue
	{
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public DecimalCondition Condition { get; set; }

		[DataMember(Name = "value2", EmitDefaultValue = false)]
		public byte? Value2 { get; set; }
	}
	[DataContract]
	public partial class GuidSearch : GuidValue
	{
		[DataMember(Name = "condition", EmitDefaultValue = false)]
		public GuidCondition Condition { get; set; }

		[DataMember(Name = "value2", EmitDefaultValue = false)]
		public byte? Value2 { get; set; }
	}
}
