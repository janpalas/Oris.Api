using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
[assembly:InternalsVisibleTo("Oris.Api.Tests")]

namespace Oris.Api
{
	internal class OrisWebClient : IOrisWebClient
	{
		public async Task<string> GetStringAsync(string uri)
		{
			using (var client = new HttpClient())
			using (HttpResponseMessage response = await client.GetAsync(uri))
			{
				if (!response.IsSuccessStatusCode)
					throw new OrisApiException(response.StatusCode, uri);

				return await response.Content.ReadAsStringAsync();
			}
		}
	}
}
