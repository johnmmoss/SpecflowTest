using System.Configuration;
using OpenQA.Selenium;

namespace SpecflowTest.Specs
{
    public class RegisterPage 
    {
        private readonly IWebDriver webDriver;
        protected static string BaseUrl = ConfigurationManager.AppSettings["WebsiteUrl"];

        public RegisterPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}