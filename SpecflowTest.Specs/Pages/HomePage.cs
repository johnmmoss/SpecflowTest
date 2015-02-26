using System.Configuration;
using OpenQA.Selenium;

namespace SpecflowTest.Specs
{
    public class HomePage 
    {
        private readonly IWebDriver webDriver;
        protected static string BaseUrl = ConfigurationManager.AppSettings["WebsiteUrl"];

        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public RegisterPage GoToRegisterPage()
        {
            var registerLink = webDriver.FindElement(By.Id("registerLink"));
            registerLink.Click();
            return new RegisterPage(webDriver);
        }
    }
}
