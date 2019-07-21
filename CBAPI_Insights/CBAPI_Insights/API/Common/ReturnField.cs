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
	public partial class IntReturn : IntValue
	{
	}
	[DataContract]
	public partial class BooleanReturn : BooleanValue
	{
	}
	[DataContract]
	public partial class StringReturn : StringValue
	{ 
	}
	[DataContract]
	public partial class ByteReturn : ByteValue
	{
	}
	[DataContract]
	public partial class DateTimeReturn : DateTimeValue
	{
	}
	[DataContract]
	public partial class DoubleReturn : DoubleValue
	{
	}
	[DataContract]
	public partial class ShortReturn : BooleanValue
	{
	}
	[DataContract]
	public partial class LongReturn : LongValue
	{
	}
	[DataContract]
	public partial class DecimalReturn : DecimalValue
	{
	}
	[DataContract]
	public partial class GuidReturn : GuidValue
	{ 
	}
}
