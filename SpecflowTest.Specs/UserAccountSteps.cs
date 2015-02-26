using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowTest.Specs
{
    [Binding]
    public class UserAccountSteps
    {
        [Given(@"I am on the register page")]
        public void GivenIAmOnTheRegisterPage()
        {
        }

        [Given(@"I have entered the following deatails into the form:")]
        public void GivenIHaveEnteredTheFollowingDeatailsIntoTheForm(Table table)
        {
        }

        [When(@"I press register")]
        public void WhenIPressRegister()
        {
        }

        [Then(@"a new account is created")]
        public void ThenANewAccountIsCreated()
        {
        }

    }
}
