using System;
using System.Net;

namespace Oris.Api
{
	public class OrisApiException : Exception
	{
		public string OrisResponseStatus { get; }
		public string Method { get; }
		public HttpStatusCode? ResponseStatusCode { get; }

		public string Uri { get; }

		public OrisApiException(HttpStatusCode responseStatusCode, string uri)
		{
			ResponseStatusCode = responseStatusCode;
			Uri = uri;
		}

		public OrisApiException(string orisResponseStatus, string orisApiMethod)
		{
			OrisResponseStatus = orisResponseStatus;
			Method = orisApiMethod;
		}
	}
}
