using Newtonsoft.Json;

namespace Oris.Api
{
	public class Club
	{
		[JsonProperty("ID")]
		public string Id { get; set; }

		[JsonProperty("Name")]
		public string Nazev { get; set; }

		[JsonProperty("Abbr")]
		public string Zkratka { get; set; }

		[JsonProperty("Region")]
		public string Region { get; set; }

		[JsonProperty("Number")]
		public string Cislo { get; set; }
	}
}
