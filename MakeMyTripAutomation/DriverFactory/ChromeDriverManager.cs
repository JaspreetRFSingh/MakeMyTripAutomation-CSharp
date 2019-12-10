using OpenQA.Selenium.Chrome;

namespace MakeMyTripAutomation.DriverFactory
{
    public class ChromeDriverManager : DriverManager
    {
        protected override void CreateWebDriver()
        {
            //ChromeOptions options = new ChromeOptions();
            this.driver = new ChromeDriver();
        }
    }
}
