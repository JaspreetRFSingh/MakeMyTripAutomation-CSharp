using MakeMyTripAutomation.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTripAutomation.Utilities
{
    public class CustomWait
    {
        private static WebDriverWait wait;
        private static IWebDriver driver = DriverConfiguration.GetDriver();

        public static IWebElement WaitFor(IWebElement locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            return element;
        }

        public static Boolean waitForUrl(String text)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(ExpectedConditions.UrlContains(text));

        }

    }
}
