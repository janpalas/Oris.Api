using System;
using System.Net;

namespace Oris.Api
{
	public class OrisApiException : Exception
	{
		public string OrisResponseStatus { get; }
		public string Uri { get; }
		public HttpStatusCode? ResponseStatusCode { get; }

		public OrisApiException(HttpStatusCode responseStatusCode, string uri)
		{
			ResponseStatusCode = responseStatusCode;
			Uri = uri;
		}

		public OrisApiException(string orisResponseStatus, string uri)
		{
			OrisResponseStatus = orisResponseStatus;
			Uri = uri;
		}
	}
}
