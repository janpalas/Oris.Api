using System;
using Newtonsoft.Json;

namespace Oris.Api
{
	public class Event
	{
		[JsonProperty("ID")]
		public int Id { get; set; }

		[JsonProperty("Name")]
		public string Name { get; set; }

		[JsonProperty("Date")]
		public DateTime Date { get; set; }

		[JsonProperty("Region")]
		public string Region { get; set; }

		[JsonProperty("EntryDate1")]
		public DateTime? EntryDate1 { get; set; }

		[JsonProperty("EntryDate2")]
		public DateTime? EntryDate2 { get; set; }

		[JsonProperty("EntryDate3")]
		public DateTime? EntryDate3 { get; set; }

		[JsonProperty("Ranking")]
		public string Ranking { get; set; }

		[JsonProperty("Cancelled")]
		public string Cancelled { get; set; }

		[JsonProperty("GPSLat")]
		public string GpsLatitude { get; set; }

		[JsonProperty("GPSLon")]
		public string GpsLongitude { get; set; }

		[JsonProperty("Place")]
		public string Place { get; set; }

		[JsonProperty("Version")]
		public int Version { get; set; }

		[JsonProperty("ParentID")]
		public int ParentId { get; set; }

		[JsonProperty("Status")]
		public string Status { get; set; }

		[JsonProperty("OBPostupy")]
		public string OBPostupy { get; set; }
	}
}
