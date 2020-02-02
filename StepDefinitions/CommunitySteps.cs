using System;
using TechTalk.SpecFlow;

namespace BlueSkyCitadelTest_Famework1.StepDefinitions
{
    [Binding]
    public class CommunitySteps
    {
        [Then(@"I am on the Community page")]
        public void ThenIAmOnTheCommunityPage()
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I click on Community")]
        public void WhenIClickOnCommunity()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am on Community page")]
        public void ThenIAmOnCommunityPage()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
