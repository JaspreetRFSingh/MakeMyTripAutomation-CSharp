using MakeMyTripAutomation.Config;
using MakeMyTripAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyTripAutomation.Pages.HomePage
{
    public class Login
    {
        IWebDriver driver = DriverConfiguration.GetDriver();
        CommonOperations operations;

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Login or Create Account')]")]
        IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//input[@id='username']")]
        IWebElement username;

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        IWebElement passwordField;

        [FindsBy(How = How.XPath, Using = "//button[@data-cy='login']")]
        IWebElement login;

        [FindsBy(How = How.XPath, Using = "//span[@class='crossIcon popupSprite popupCrossIcon']")]
        IWebElement modalClose;

        [FindsBy(How = How.XPath, Using = "//p[@class='whiteText appendBottom3 truncate']")]
        IWebElement loggedInUser;

        public Login()
        {
            new HomePage();
        }

        public void InitializePage()
        {
            PageFactory.InitElements(driver, this);
            operations = new CommonOperations();
        }

        public void LoginWithCredentials()
        {

            operations.ClickButton(loginButton);
            operations.EnterData(username, "jaspreetsinghproacc@gmail.com");
            username.Submit();
            operations.EnterData(passwordField,"Qwerty@123");
            passwordField.Submit();
            operations.ClickButton(modalClose);
        }

        public Boolean CheckWhetherUserIsLoggedIn()
        {
            return loggedInUser.GetAttribute("data-cy").Equals("loggedInUser");
        }

    }
}
