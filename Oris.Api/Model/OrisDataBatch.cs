using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Oris.Api
{
	internal class OrisDataBatch<T>
	{
		[JsonProperty("Method")]
		public string Method { get; set; }

		[JsonProperty("Format")]
		public string Format { get; set; }

		[JsonProperty("Status")]
		public string Status { get; set; }

		[JsonProperty("ExportCreated")]
		public DateTime ExportCreated { get; set; }

		[JsonProperty("Data")]
		public IDictionary<string, T> Data { get; set; }
	}
}
