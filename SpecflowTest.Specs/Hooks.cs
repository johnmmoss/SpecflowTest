using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecflowTest.Specs
{
    [Binding]
    public class Hooks
    {
        private static string Url = ConfigurationManager.AppSettings["WebsiteUrl"];

        [BeforeFeature()]
        public static void BeforeFeature()  // must be static
        {
            // Create the webdriver and store it in the feature context
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
            // At the begining of the scenario, we are on the homepage
            var webDriver = FeatureContext.Current.Get<IWebDriver>();
            var homePage = new HomePage(webDriver);
            ScenarioContext.Current.Set<HomePage>(homePage);
        }

        [AfterScenario]
        public void AfterScenario()
        {
        }
    }
}
