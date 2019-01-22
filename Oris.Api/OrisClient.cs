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
			string uri = $"{OrisApiUrl}&method=getCSOSClubList";
			string json = await _orisWebClient.GetStringAsync(uri);

			OrisDataBatch<Club> orisDataBatch = JsonConvert.DeserializeObject<OrisDataBatch<Club>>(json);
			orisDataBatch.EnsureSuccessfulResponse(uri);

			List<Club> clubs = orisDataBatch.Data.Select(x => x.Value).ToList();
			return clubs;
		}
	}
}
