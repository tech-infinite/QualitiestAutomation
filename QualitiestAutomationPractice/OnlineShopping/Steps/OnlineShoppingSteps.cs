using System;
using TechTalk.SpecFlow;

namespace QualitiestAutomationPractice.OnlineShopping.Steps
{
    [Binding]
    public class OnlineShoppingSteps
    {


        [Given(@"I'm logged in to the Automation Practice webpage")]
        public void GivenIMLoggedInToTheAutomationPracticeWebpage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select the T-Shirts link")]
        public void WhenISelectTheT_ShirtsLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add item to the shopping cart")]
        public void WhenIAddItemToTheShoppingCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select My Account link")]
        public void WhenISelectMyAccountLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click My Personal Information tab")]
        public void WhenIClickMyPersonalInformationTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I save the details")]
        public void WhenISaveTheDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the personal information should be updated successfully")]
        public void ThenThePersonalInformationShouldBeUpdatedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
