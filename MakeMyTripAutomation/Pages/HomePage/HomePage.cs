using MakeMyTripAutomation.Config;
using MakeMyTripAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MakeMyTripAutomation.Pages.HomePage
{
    public class HomePage
    {
        IWebDriver driver = DriverConfiguration.GetDriver();

        [FindsBy(How = How.LinkText, Using = "Flights")]
        IWebElement flightsAnchorTag;

        [FindsBy(How = How.LinkText, Using = "Hotels")]
        IWebElement hotelsAnchorTag;

        [FindsBy(How = How.LinkText, Using = "Villas & Apts")]
        IWebElement villasAnchorTag;

        [FindsBy(How = How.LinkText, Using = "Holidays")]
        IWebElement holidaysAnchorTag;

        [FindsBy(How = How.LinkText, Using = "Trains")]
        IWebElement trainsAnchorTag;

        [FindsBy(How = How.LinkText, Using = "Buses")]
        IWebElement busesAnchorTag;

        [FindsBy(How = How.LinkText, Using = "Cabs")]
        IWebElement cabsAnchorTag;

       
        public HomePage()
        {
            //driver = DriverConfiguration.GetDriver();
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
        }

        public void InitializePageFactory()
        {
            PageFactory.InitElements(driver, this);
        }

        public String ClickFlightsTab()
        {
            flightsAnchorTag.Click();
            CustomWait.waitForUrl("flights");
            return driver.Url;
        }

        public String ClickHotelsTab()
        {
            hotelsAnchorTag.Click();
            CustomWait.waitForUrl("hotels");
            return driver.Url;
        }

        public String ClickVillasTab()
        {
            villasAnchorTag.Click();
            CustomWait.waitForUrl("homestays");
            return driver.Url;
        }

        public String ClickHolidaysTab()
        {
            holidaysAnchorTag.Click();
            CustomWait.waitForUrl("holidays-india");
            return driver.Url;
        }

        public String ClickTrainsTab()
        {
            trainsAnchorTag.Click();
            CustomWait.waitForUrl("railways");
            return driver.Url;

        }

        public String ClickBusesTab()
        {
            busesAnchorTag.Click();
            CustomWait.waitForUrl("bus-tickets");
            return driver.Url;
        }

        public String ClickCabsTab()
        {
            cabsAnchorTag.Click();
            CustomWait.waitForUrl("cabs");
            return driver.Url;
        }


    }
}
