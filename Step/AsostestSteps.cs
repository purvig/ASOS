using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Asos.Page;
using Asos.Base;

namespace Asos.Step
{
    [Binding]
    [Scope(Tag = "SMOKE")]

    public class AsostestSteps : Asoshooks
    {
        public IWebDriver driver;
        public Asospage login;

        [Given(@"I naviagte to Asos")]
        public void GivenINaviagteToAsos()
        {
            driver = Driver;
            login = new Asospage(driver);
            login.NavigateMethod();
        }
        
        [When(@"I click on sign in")]
        public void WhenIClickOnSignIn()
        {
            login.ClickSignin();
        }
        
        [When(@"I  entered the user details")]
        public void WhenIEnteredTheUserDetails()
        {
            login.userdetails();
        }
        
        [Then(@"I am able to signin")]
        public void ThenIAmAbleToSignin()
        {
            login.VerifyPageload();
        }
    }
}
