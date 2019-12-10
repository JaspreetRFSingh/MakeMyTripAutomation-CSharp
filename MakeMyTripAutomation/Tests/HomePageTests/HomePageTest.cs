using MakeMyTripAutomation.Config;
using MakeMyTripAutomation.Pages.HomePage;
using NUnit.Framework;

namespace MakeMyTripAutomation.Tests.HomePageTests
{
    [TestFixture]
    public class HomePageTest
    {
        HomePage homePage;

        [SetUp]
        public void BeforeClass()
        {
            homePage = new HomePage();
            homePage.InitializePageFactory();
        }

        [Test]
        public void TestHomePage()
        {
            Assert.IsTrue(homePage.ClickFlightsTab().Contains("flights"), "Link to flights is broken!");
            Assert.IsTrue(homePage.ClickHolidaysTab().Contains("holidays-india"), "Link to flights is broken!");
            Assert.IsTrue(homePage.ClickHotelsTab().Contains("hotels"), "Link to flights is broken!");
            Assert.IsTrue(homePage.ClickTrainsTab().Contains("railways"), "Link to flights is broken!");
            Assert.IsTrue(homePage.ClickCabsTab().Contains("cabs"), "Link to flights is broken!");
            Assert.IsTrue(homePage.ClickBusesTab().Contains("bus-tickets"), "Link to flights is broken!");
            Assert.IsTrue(homePage.ClickVillasTab().Contains("homestays"), "Link to flights is broken!");
        }



        [TearDown]
        public void AfterClass()
        {
            DriverConfiguration.CloseDriver();
        }


    }
}
