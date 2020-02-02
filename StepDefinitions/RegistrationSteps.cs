using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadelTest_Famework1.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        [When(@"I enter a wrong password ""(.*)"" for the confirm password")]
        public void WhenIEnterAWrongPasswordForTheConfirmPassword(string p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I enter the password ""(.*)""")]
        public void WhenIEnterThePassword(string p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I enter the first name ""(.*)""")]
        public void WhenIEnterTheFirstName(string p0)
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter the last name ""(.*)""")]
        public void WhenIEnterTheLastName(string p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"my name is displayed")]
        public void ThenMyNameIsDisplayed()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"I should not be logged in")]
        public void ThenIShouldNotBeLoggedIn()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter a wrong password for the confirm password")]
        public void WhenIEnterAWrongPasswordForTheConfirmPassword()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on the register button")]
        public void GivenIClickOnTheRegisterButton()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the first name")]
        public void WhenIEnterTheFirstName()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the last name")]
        public void WhenIEnterTheLastName()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the password")]
        public void WhenIEnterThePassword()
        {
            // ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the confirm password")]
        public void WhenIEnterTheConfirmPassword()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the sign up button")]
        public void WhenIClickTheSignUpButton()
        {
            // ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
