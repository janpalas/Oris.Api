using System;
using Newtonsoft.Json;

namespace Oris.Api
{
	public class Event
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public DateTime Date { get; set; }
		public string Region { get; set; }
		public DateTime? EntryDate1 { get; set; }
		public DateTime? EntryDate2 { get; set; }
		public DateTime? EntryDate3 { get; set; }
		public string Ranking { get; set; }
		public string Cancelled { get; set; }

		[JsonProperty("GPSLat")]
		public string GpsLatitude { get; set; }

		[JsonProperty("GPSLon")]
		public string GpsLongitude { get; set; }

		public string Place { get; set; }
		public string Version { get; set; }
		public int ParentId { get; set; }
		public string Status { get; set; }
		public string OBPostupy { get; set; }
	}
}
