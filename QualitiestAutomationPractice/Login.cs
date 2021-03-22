using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace QualitiestAutomationPractice
{
    public class Login : BasePage
    {
        string testUrl = "http://automationpractice.com/index.php?controller=authentication&back=my-account";
        private IWebDriver driver { get; }

        
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailAddress { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.ClassName, Using = "submit")]
        public IWebElement SignIn { get; set; }


        public Login(IWebDriver webDriver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void SignInToApplication()
        {
            EmailAddress.SendKeys("sramaraju2003@gmail.com");
            Password.SendKeys("Tester1");
            SignIn.Submit();
        }
        
    }
}
