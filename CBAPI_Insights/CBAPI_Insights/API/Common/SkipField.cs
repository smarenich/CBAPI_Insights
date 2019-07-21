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
	public partial class IntSkip : IntValue
	{
	}
	[DataContract]
	public partial class BooleanSkip : BooleanValue
	{
	}
	[DataContract]
	public partial class StringSkip : StringValue
	{ 
	}
	[DataContract]
	public partial class ByteSkip : ByteValue
	{
	}
	[DataContract]
	public partial class DateTimeSkip : DateTimeValue
	{
	}
	[DataContract]
	public partial class DoubleSkip : DoubleValue
	{
	}
	[DataContract]
	public partial class ShortSkip : BooleanValue
	{
	}
	[DataContract]
	public partial class LongSkip : LongValue
	{
	}
	[DataContract]
	public partial class DecimalSkip : DecimalValue
	{
	}
	[DataContract]
	public partial class GuidSkip : GuidValue
	{ 
	}
}
