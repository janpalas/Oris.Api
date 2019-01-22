using System;
using Newtonsoft.Json;

namespace Oris.Api
{
	public class EventEntry
	{
		[JsonProperty("ID")]
		public int Id { get; set; }

		[JsonProperty("ClassID")]
		public int ClassId { get; set; }

		[JsonProperty("ClassDesc")]
		public string ClassDescription { get; set; }

		[JsonProperty("RegNo")]
		public string ReginstrationNumber { get; set; }

		[JsonProperty("Name")]
		public string Name { get; set; }

		[JsonProperty("FirstName")]
		public string FirstName { get; set; }

		[JsonProperty("LastName")]
		public string LastName { get; set; }

		[JsonProperty("RentSI")]
		public string RentSI { get; set; }

		[JsonProperty("SI")]
		public string SI { get; set; }

		[JsonProperty("Licence")]
		public string Licence { get; set; }

		[JsonProperty("RequestedStart")]
		public string RequestedStart { get; set; }

		[JsonProperty("UserID")]
		public int UserId { get; set; }

		[JsonProperty("ClubUserID")]
		public int ClubUserId { get; set; }

		[JsonProperty("ClubID")]
		public int ClubId { get; set; }

		[JsonProperty("Note")]
		public string Note { get; set; }

		[JsonProperty("Fee")]
		public decimal Fee { get; set; }

		[JsonProperty("EntryStop")]
		public string EntryStop { get; set; }

		[JsonProperty("CreatedDateTime")]
		public DateTime Created { get; set; }

		[JsonProperty("CreatedByUserID")]
		public int CreatedByUserId { get; set; }

		[JsonProperty("UpdatedDateTime")]
		public DateTime? Updated { get; set; }

		[JsonProperty("UpdatedByUserID")]
		public int? UpdatedByUserId { get; set; }
	}
}
