using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AudenQaTest
{
    [Binding]

   public sealed class Hooks
    {
        IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            PropertiesCollection.driver= new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.auden.co.uk/credit/shorttermloan");
            PropertiesCollection.driver.Manage().Window.Maximize();
        }

       // [AfterScenario]
       // public void AfterScenario()
       // {
            // driver.Close();
            //TODO: implement logic that has to run after executing each scenario
       // }

    }
}
