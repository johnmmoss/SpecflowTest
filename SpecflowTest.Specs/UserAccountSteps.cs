using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecflowTest.Specs
{
    [Binding]
    public class UserAccountSteps
    {
        [Given(@"I am on the register page")]
        public void GivenIAmOnTheRegisterPage()
        {
            var homePage = ScenarioContext.Current.Get<HomePage>();
            var registerPage = homePage.GoToRegisterPage();
            ScenarioContext.Current.Set(registerPage);
        }

        [Given(@"I have entered the following deatails into the form:")]
        public void GivenIHaveEnteredTheFollowingDeatailsIntoTheForm(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press register")]
        public void WhenIPressRegister()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a new account is created")]
        public void ThenANewAccountIsCreated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
