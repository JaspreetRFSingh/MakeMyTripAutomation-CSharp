using MakeMyTripAutomation.Config;
using MakeMyTripAutomation.Pages.HomePage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTripAutomation.Tests.HomePageTests
{
    [TestFixture]
    public class LoginTest
    {
        Login login;
        [SetUp]
        public void Initialize()
        {
            login = new Login();
            login.InitializePage();
        }
        [Test]
        public void TestLogin()
        {
            login.LoginWithCredentials();
            Assert.IsTrue(login.CheckWhetherUserIsLoggedIn());
        }

        [TearDown]
        public void EndTestSuite()
        {
            DriverConfiguration.CloseDriver();
        }
    }
}
