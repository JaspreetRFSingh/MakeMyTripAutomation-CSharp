using OpenQA.Selenium;

namespace MakeMyTripAutomation.DriverFactory
{
    public abstract class DriverManager
    {
        protected IWebDriver driver;
        protected abstract void CreateWebDriver();
        public void QuitWebDriver()
        {
            if (null != driver)
            {
                driver.Quit();
                driver = null;
            }

        }
        public IWebDriver GetWebDriver()
        {
            if (driver == null)
            {
                CreateWebDriver();
            }
            return driver;
        }
    }
}
