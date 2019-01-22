using System;

namespace Oris.Api
{
	internal static class Extensions
	{
		internal static void EnsureSuccessfulResponse<T>(this OrisDataBatch<T> dataBatch, string uri)
		{
			if (dataBatch.Status?.Equals("OK", StringComparison.InvariantCultureIgnoreCase) != true)
				throw new OrisApiException(dataBatch.Status, uri);
		}

	}
}
