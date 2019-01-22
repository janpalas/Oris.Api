using System;

namespace Oris.Api
{
	public class EventFilter
	{
		public EventFilter()
		{
		}

		public EventFilter(DateTime from, DateTime to)
		{
			From = from;
			To = to;
		}

		public DateTime From { get; set; }
		public DateTime To { get; set; }
		public string MyClubId { get; set; }
		public string Club { get; set; }
	}
}
