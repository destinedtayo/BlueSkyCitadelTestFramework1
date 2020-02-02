using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadelTest_Famework1.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [When(@"I enter no username ""(.*)""")]
        public void WhenIEnterNoUsername(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter wrong username ""(.*)""")]
        public void WhenIEnterWrongUsername(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter no password ""(.*)""")]
        public void WhenIEnterNoPassword(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter username ""(.*)""")]
        public void WhenIEnterUsername(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter the wrong password ""(.*)""")]
        public void WhenIEnterTheWrongPassword(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter the wrong password")]
        public void WhenIEnterTheWrongPassword()
        {
           // ScenarioContext.Current.Pending();
        }

        [Given(@"I click on login button")]
        public void GivenIClickOnLoginButton()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter username")]
        public void WhenIEnterUsername()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
