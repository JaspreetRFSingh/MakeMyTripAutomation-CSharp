using MakeMyTripAutomation.Config;
using MakeMyTripAutomation.Pages.FlightsPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTripAutomation.Tests.FlightsPageTests
{
    [TestFixture]
    public class FlightBookingTest
    {
        FlightQuery flightQuery;
        [SetUp]
        public void Init()
        {
            flightQuery = new FlightQuery();
            flightQuery.InitializePage();
        }

        [Test]
        public void TestBookFlight()
        {
            flightQuery.SelectSourceCity();
            flightQuery.SelectDestinationCity();
            flightQuery.SelectDate("29 March 2020");
            flightQuery.HitSearchButton();
        }

        /*[TearDown]
        public void Close()
        {
            DriverConfiguration.CloseDriver();
        }*/
    }
}
