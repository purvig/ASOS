using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Asos.Base
{
   
    public  class Asoshooks
    {
        public IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario]

        public void AfterScenario()
        {

            Driver.Close();
            Driver.Quit();
        }
    }
}
