using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecflowTest.Specs
{
    [Binding]
    public class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private const string Url = "http://localhost:49938/";

        [BeforeFeature()]
        public static void BeforeFeature()  // must be static
        {
            IWebDriver driver = new FirefoxDriver();
            FeatureContext.Current.Set(driver);
            driver.Navigate().GoToUrl(Url);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            var webDriver = FeatureContext.Current.Get<IWebDriver>();
            webDriver.Dispose();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
        }
    }
}
