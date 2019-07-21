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
	public partial class Entity : ILocalEntity
	{
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public Guid? Id { get; set; }

		[DataMember(Name = "rowNumber", EmitDefaultValue = false)]
		public long? RowNumber { get; set; }

		[DataMember(Name = "note", EmitDefaultValue = false)]
		public string Note { get; set; }

		[DataMember(Name = "delete", EmitDefaultValue = false)]
		public bool Delete { get; set; }

		[DataMember(Name = "noteid", EmitDefaultValue = false)]
		public Guid? SyncID { get; set; }

		[DataMember(Name = "lastmodifieddatetime", EmitDefaultValue = false)]
		public DateTime? SyncTime { get; set; }

		[DataMember(Name = "ReturnBehavior", EmitDefaultValue = false)]
		public ReturnBehavior ReturnBehavior { get; set; }

		[DataMember(Name = "custom", EmitDefaultValue = false)]
		public List<CustomField> Custom { get; set; }

		[DataMember(Name = "files", EmitDefaultValue = false)]
		public List<FileLink> Files { get; set; }
	}

	public enum ReturnBehavior
	{
		Default = -1,
		All = 0,
		None = 1,
		OnlySystem = 2,
		OnlySpecified = 3
	}
}
