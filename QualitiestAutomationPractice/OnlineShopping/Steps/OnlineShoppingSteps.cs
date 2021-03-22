using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;

namespace QualitiestAutomationPractice.OnlineShopping.Steps
{
    [Binding]
    public class OnlineShoppingSteps
    {
        BasePage _basePage;
        IWebDriver driver;

        [Given(@"I'm logged in to the Automation Practice webpage")]
        public void GivenIMLoggedInToTheAutomationPracticeWebpage()
        {
            driver.Url = "http://automationpractice.com/index.php";

        }
        
        [When(@"I select the T-Shirts link")]
        public void WhenISelectTheT_ShirtsLink(string link)
        {
        }
        
        [When(@"I add item to the shopping cart")]
        public void WhenIAddItemToTheShoppingCart()
        {
            
        }

        [When(@"I proceed to checkout")]
        public void WhenIProceedToCheckout()
        {
        }

        [When(@"I sign into my account")]
        public void WhenISignIntoMyAccount()
        {
            
        }

        [When(@"I enter the address details")]
        public void WhenIEnterTheAddressDetails()
        {
            
        }

        [When(@"I enter the shipping details")]
        public void WhenIEnterTheShippingDetails()
        {
            
        }

        [When(@"I select the payment method")]
        public void WhenISelectThePaymentMethod()
        {
            
        }

        [Then(@"I should be able to confirm my order")]
        public void ThenIShouldBeAbleToConfirmMyOrder()
        {
            
        }


        [When(@"I select My Account link")]
        public void WhenISelectMyAccountLink()
        {
        }
        
        [When(@"I click My Personal Information tab")]
        public void WhenIClickMyPersonalInformationTab()
        {
        }
        
        [When(@"I save the details")]
        public void WhenISaveTheDetails()
        {
        }
        
        [Then(@"the personal information should be updated successfully")]
        public void ThenThePersonalInformationShouldBeUpdatedSuccessfully()
        {
        }
    }
}
