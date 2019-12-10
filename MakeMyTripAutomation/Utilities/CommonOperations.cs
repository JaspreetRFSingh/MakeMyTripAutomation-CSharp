using MakeMyTripAutomation.Config;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTripAutomation.Utilities
{
    public class CommonOperations
    {
        private static IWebDriver driver = DriverConfiguration.GetDriver();

        public void ClickButton(IWebElement element)
        {
            CustomWait.WaitFor(element);
            element.Click();
        }

        public void EnterData(IWebElement element, String data)
        {
            CustomWait.WaitFor(element);
            element.SendKeys(data);
        }

    }
}
