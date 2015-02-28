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

        public void EnterDetails(string username, string password)
        {
            webDriver.FindElement(By.Id("UserName")).SendKeys(username);
            webDriver.FindElement(By.Id("Password")).SendKeys(password);
            webDriver.FindElement(By.Id("ConfirmPassword")).SendKeys(password);
        }

        public void ClickRegister()
        {
            var elem = webDriver.FindElement(By.XPath("//input[@type='submit']"));
            elem.Click();
        }
    }
}