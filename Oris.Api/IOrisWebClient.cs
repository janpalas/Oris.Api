using System.Threading.Tasks;

namespace Oris.Api
{
	internal interface IOrisWebClient
	{
		Task<string> GetStringAsync(string uri);
	}
}