using Newtonsoft.Json;

namespace Oris.Api
{
	public class Club
	{
		[JsonProperty("ID")]
		public int Id { get; set; }

		[JsonProperty("Name")]
		public string Name { get; set; }

		[JsonProperty("Abbr")]
		public string Abbreviation { get; set; }

		[JsonProperty("Region")]
		public string Region { get; set; }

		[JsonProperty("Number")]
		public string Number { get; set; }
	}
}
