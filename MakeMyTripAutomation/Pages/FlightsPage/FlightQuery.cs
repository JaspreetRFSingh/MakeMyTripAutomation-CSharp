using MakeMyTripAutomation.Config;
using MakeMyTripAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTripAutomation.Pages.FlightsPage
{
    public class FlightQuery
    {
        IWebDriver driver = DriverConfiguration.GetDriver();
        HomePage.HomePage homePage;
        CommonOperations operations;

        [FindsBy(How = How.XPath, Using = "//label[@for='fromCity']/input")]
        IWebElement fromCity;

        [FindsBy(How = How.XPath, Using = "//label[@for='toCity']/input")]
        IWebElement toCity;

        [FindsBy(How = How.XPath, Using = "//li[@id='react-autowhatever-1-section-0-item-0']")]
        IWebElement fromCityInput;

        [FindsBy(How = How.XPath, Using = "//li[@id='react-autowhatever-1-section-0-item-0']")]
        IWebElement toCityInput;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'fsw_inputBox dates inactiveWidget')]")]
        IWebElement departureDateDiv;

        [FindsBy(How = How.XPath, Using = "//span[@class='DayPicker-NavButton DayPicker-NavButton--next']")]
        IWebElement nextMonth;

        [FindsBy(How = How.XPath, Using = "//*[@class='DayPicker-Caption']")]
        IWebElement monthCaptions;

        [FindsBy(How = How.XPath, Using = "//a[@class='primaryBtn font24 latoBlack widgetSearchBtn ']")]
        IWebElement searchButton;

        public FlightQuery()
        {
            homePage = new HomePage.HomePage();
            homePage.InitializePageFactory();
            homePage.ClickFlightsTab();
        }

        public void InitializePage()
        {
            PageFactory.InitElements(driver, this);
            operations = new CommonOperations();
        }

        public void SelectSourceCity()
        {

            operations.EnterData(fromCity, "Delhi");
            operations.ClickButton(fromCityInput);

        }

        public void SelectDestinationCity()
        {
            operations.EnterData(toCity, "Mumbai");
            operations.ClickButton(toCityInput);
        }

        public void SelectDate(String date)
        {
            operations.ClickButton(departureDateDiv);
            IReadOnlyCollection<IWebElement> d = driver.FindElements(By.XPath("//*[@class='DayPicker-Caption']"));
            String caption = "";
            String currentMonthCaption = d.ElementAt(0).Text;
            String nextMonthCaption = d.ElementAt(1).Text;
            if (!currentMonthCaption.Equals(date.Substring(3)))
            {
                while (!caption.Equals(date.Substring(3)))
                {
                    caption = nextMonthCaption;
                    // logger.info(caption);
                    nextMonth.Click();
                    d = driver.FindElements(By.XPath("//*[@class='DayPicker-Caption']"));
                    currentMonthCaption = d.ElementAt(0).Text;
                    nextMonthCaption = d.ElementAt(1).Text;
                }
            }
            String xpathForDateSelected = "//div[@class='dateInnerCell']/p[contains(text(),'" + date.Substring(0, 2) + "')]";
            IWebElement datePicked = driver.FindElement(By.XPath(xpathForDateSelected));
            operations.ClickButton(datePicked);
        }

        public void HitSearchButton()
        {
            operations.ClickButton(searchButton);
        }
    }
}

