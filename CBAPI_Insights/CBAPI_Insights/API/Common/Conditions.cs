using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CBAPI_Insights.API
{
	[DataContract]
	public enum IntCondition
	{
		Equal,
		NotEqual,
		IsBetween,
		IsGreaterThan,
		IsLessThan,
		IsGreaterThanOrEqualsTo,
		IsLessThanOrEqualsTo,
		IsNull,
		IsNotNull,
	}
	[DataContract]
	public enum BooleanCondition
	{
		Equal,
		NotEqual,
		IsNull,
		IsNotNull,
	}
	[DataContract]
	public enum StringCondition
	{
		Equal,
		NotEqual,
		IsBetween,
		IsGreaterThan,
		IsLessThan,
		IsGreaterThanOrEqualsTo,
		IsLessThanOrEqualsTo,
		Contains,
		DoesNotContain,
		StartsWith,
		EndsWith,
		IsNull,
		IsNotNull,
	}
	[DataContract]
	public enum ByteCondition
	{
		Equal,
		NotEqual,
		IsBetween,
		IsGreaterThan,
		IsLessThan,
		IsGreaterThanOrEqualsTo,
		IsLessThanOrEqualsTo,
		IsNull,
		IsNotNull,
	}
	[DataContract]
	public enum DateTimeCondition
	{
		Equal,
		NotEqual,
		IsBetween,
		IsGreaterThan,
		IsLessThan,
		IsGreaterThanOrEqualsTo,
		IsLessThanOrEqualsTo,
		Today,
		Overdue,
		Tomorrow,
		ThisWeek,
		ThisMonth,
		IsNull,
		IsNotNull,
	}
	[DataContract]
	public enum ShortCondition
	{
		Equal,
		NotEqual,
		IsBetween,
		IsGreaterThan,
		IsLessThan,
		IsGreaterThanOrEqualsTo,
		IsLessThanOrEqualsTo,
		IsNull,
		IsNotNull,
	}
	[DataContract]
	public enum DoubleCondition
	{
		Equal,
		NotEqual,
		IsBetween,
		IsGreaterThan,
		IsLessThan,
		IsGreaterThanOrEqualsTo,
		IsLessThanOrEqualsTo,
		IsNull,
		IsNotNull,
	}
	[DataContract]
	public enum LongCondition
	{
		Equal,
		NotEqual,
		IsBetween,
		IsGreaterThan,
		IsLessThan,
		IsGreaterThanOrEqualsTo,
		IsLessThanOrEqualsTo,
		IsNull,
		IsNotNull,
	}
	[DataContract]
	public enum DecimalCondition
	{
		Equal,
		NotEqual,
		IsBetween,
		IsGreaterThan,
		IsLessThan,
		IsGreaterThanOrEqualsTo,
		IsLessThanOrEqualsTo,
		IsNull,
		IsNotNull,
	}
	[DataContract]
	public enum GuidCondition
	{
		Equal,
		NotEqual,
		IsNull,
		IsNotNull,
	}

	public enum GeneralCondition
	{
		Equal,
		NotEqual,
		IsBetween,
		IsGreaterThan,
		IsLessThan,
		IsGreaterThanOrEqualsTo,
		IsLessThanOrEqualsTo,
		StartsWith,
		EndsWith,
		IsNull,
		IsNotNull,
	}
}
