using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace Asos.Page
{
    public class Asospage
    {
        public IWebDriver driver;

        public Asospage(IWebDriver Driver)
        {
            driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        public void NavigateMethod()
        {
            driver.Navigate().GoToUrl("https://www.asos.com/");
        }
        public void ClickSignin()
        {
            Signinbutton.Click();
            Task.Delay(3000).Wait();
            SigninMyaccount.Click()
;
        }
        [FindsBy(How = How.CssSelector, Using = "#myAccountDropdown > button > span")]
        public IWebElement Signinbutton;
        [FindsBy(How = How.LinkText, Using = "My Account")]
        public IWebElement SigninMyaccount;
        public void userdetails()
        {
            Username.SendKeys("troy1lk@yahoo.com");
            Task.Delay(3000).Wait();
            Password.SendKeys("1234567891");
            Task.Delay(3000).Wait();
            Signin.Click();
            Task.Delay(3000).Wait();
;        }
        [FindsBy(How = How.CssSelector, Using = "#EmailAddress")]
        public IWebElement Username;
        [FindsBy(How = How.CssSelector, Using = "#Password")]
        public IWebElement Password;
        [FindsBy(How = How.CssSelector, Using = "#signin")]
        public IWebElement Signin;
        public void VerifyPageload()
        {
            WelcomeMessage.Text.Contains("My Account");

        }
        [FindsBy(How = How.LinkText, Using = "My Account")]
        public IWebElement WelcomeMessage;
    }
}