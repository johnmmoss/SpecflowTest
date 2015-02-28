using System.Linq;
using NUnit.Framework;
using SpecflowTest.Data.Models;
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

        [Given(@"I have entered a Username of '(.*)' and a password of '(.*)'")]
        public void GivenIHaveEnteredAUsernameOfAndAPasswordOf(string username, string password)
        {
            var registerPage = ScenarioContext.Current.Get<RegisterPage>();
            registerPage.EnterDetails(username, password);
        }

        [When(@"I press register")]
        public void WhenIPressRegister()
        {
            var registerPage = ScenarioContext.Current.Get<RegisterPage>();
            registerPage.ClickRegister();
        }

        [Then(@"a new account is created with a username of  a Username of '(.*)'")]
        public void ThenANewAccountIsCreatedWithAUsernameOfAUsernameOf(string username)
        {
            using (var context = new SpecflowTestContext())
            {
                var allUserProfiles = context.UserProfiles.ToList();

                Assert.That(allUserProfiles.Count, Is.EqualTo(1));
                Assert.That(allUserProfiles.First().UserName, Is.EqualTo(username));
            }
        }
    }
}
