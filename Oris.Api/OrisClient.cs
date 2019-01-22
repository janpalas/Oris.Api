using System;
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
			if (filter == null)
				throw new ArgumentNullException(nameof(filter));

			string json = await _orisWebClient.GetStringAsync($"{OrisApiUrl}&method=getEventList{GetUrlParamsFromEventFilter()}");

			OrisDataBatch<Event> orisDataBatch = JsonConvert.DeserializeObject<OrisDataBatch<Event>>(json);
			orisDataBatch.EnsureSuccessfulResponse();

			List<Event> events = orisDataBatch.Data.Select(x => x.Value).ToList();
			return events;

			string GetUrlParamsFromEventFilter()
			{
				string urlParams = $"&datefrom={filter.From:yyyy-MM-dd}&dateto={filter.To:yyyy-MM-dd}";

				if (!string.IsNullOrEmpty(filter.MyClubId))
					urlParams += $"&myClubId={filter.MyClubId}";

				if (!string.IsNullOrEmpty(filter.Club))
					urlParams += $"&club={filter.Club}";

				return urlParams;
			}
		}

		public async Task<IList<EventEntry>> GetEventEntriesAsync(int eventId, EventEntriesFilter filter, string username = null, string password = null)
		{
			string json = await _orisWebClient.GetStringAsync($"{OrisApiUrl}&method=getEventEntries&eventid={eventId}{GetUrlParamsFromEventEntriesFilter()}");

			OrisDataBatch<EventEntry> orisDataBatch = JsonConvert.DeserializeObject<OrisDataBatch<EventEntry>>(json);
			orisDataBatch.EnsureSuccessfulResponse();

			List<EventEntry> eventEntries = orisDataBatch.Data.Select(x => x.Value).ToList();
			return eventEntries;

			string GetUrlParamsFromEventEntriesFilter()
			{
				string urlParams = string.Empty;

				if (!string.IsNullOrEmpty(username))
					urlParams += $"&username={username}";

				if (!string.IsNullOrEmpty(password))
					urlParams += $"&username={password}";

				if (filter == null)
					return urlParams;

				if (!string.IsNullOrEmpty(filter.ClubId))
					urlParams += $"&clubid={filter.ClubId}";

				return urlParams;
			}
		}

		
	}
}
