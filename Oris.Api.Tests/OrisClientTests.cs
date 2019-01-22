using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Oris.Api.Tests
{
	public class OrisClientTests
	{
		[Test]
		public async Task GetClubsAsync_Simple()
		{
			var fixture = new TestFixture();

			IList<Club> clubs = await fixture.OrisClient.GetClubsAsync();

			Assert.IsNotNull(clubs);
			Assert.IsNotEmpty(clubs);

			Club sjc = clubs.FirstOrDefault(x => x.Abbreviation == "SJC");
			Assert.IsNotNull(sjc);
			Assert.AreEqual("145", sjc.Id);
			Assert.AreEqual("Sportcentrum Jičín", sjc.Name);
			Assert.AreEqual("Východočeská", sjc.Region);
			Assert.AreEqual("0618", sjc.Number);
		}
		}

		class TestFixture
		{
			public OrisClient OrisClient { get; }

			public TestFixture()
			{
				OrisClient = new OrisClient();
			}
		}
	}
}