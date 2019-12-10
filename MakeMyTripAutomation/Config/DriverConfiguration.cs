using MakeMyTripAutomation.DriverFactory;
using OpenQA.Selenium;

namespace MakeMyTripAutomation.Config
{
    public class DriverConfiguration
    {
        private static IWebDriver driver = null;

        private DriverConfiguration()
        {
            DriverManager driverManager = new ChromeDriverManager();
            driver = driverManager.GetWebDriver();

        }


        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                new DriverConfiguration();
            }
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static void CloseDriver()
        {
            driver.Close();
            driver = null;
        }

    }
}
