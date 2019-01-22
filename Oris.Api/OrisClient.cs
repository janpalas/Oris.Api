using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Oris.Api
{
	public class OrisClient
	{
		private readonly IOrisWebClient _orisWebClient;

		private const string OrisApiUrl = "https://oris.orientacnisporty.cz/API/?format=json";

		public OrisClient() : this(new OrisWebClient())
		{
		}

		internal OrisClient(IOrisWebClient orisWebClient)
		{
			_orisWebClient = orisWebClient;
		}

		public async Task<IList<Club>> GetClubsAsync()
		{
			string json = await _orisWebClient.GetStringAsync($"{OrisApiUrl}&method=getCSOSClubList");

			OrisDataBatch<Club> orisDataBatch = JsonConvert.DeserializeObject<OrisDataBatch<Club>>(json);
			orisDataBatch.EnsureSuccessfulResponse();

			List<Club> clubs = orisDataBatch.Data.Select(x => x.Value).ToList();
			return clubs;
		}

		public async Task<IList<Event>> GetEventsAsync(EventFilter filter)
		{
			string json = await _orisWebClient.GetStringAsync($"{OrisApiUrl}&method=getEventList{GetUrlParamsFromEventFilter(filter)}");

			OrisDataBatch<Event> orisDataBatch = JsonConvert.DeserializeObject<OrisDataBatch<Event>>(json);
			orisDataBatch.EnsureSuccessfulResponse();

			List<Event> events = orisDataBatch.Data.Select(x => x.Value).ToList();
			return events;
		}

		private string GetUrlParamsFromEventFilter(EventFilter filter)
		{
			string urlParams = $"&datefrom={filter.From:yyyy-MM-dd}&dateto={filter.To:yyyy-MM-dd}";

			if (!string.IsNullOrEmpty(filter.MyClubId))
				urlParams += $"&myClubId={filter.MyClubId}";

			if (!string.IsNullOrEmpty(filter.Club))
				urlParams += $"&club={filter.Club}";

			return urlParams;
		}
	}
}
