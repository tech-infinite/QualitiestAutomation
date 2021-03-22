using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace QualitiestAutomationPractice
{
    public class ClothingPage
    {
        public ClothingPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "sfHoverForce")]
        private IWebElement WomenClothing;

        [FindsBy(How = How.XPath, Using = "//*[contains(., 'Dresses')]")]
        private IWebElement WomenDresses;

        [FindsBy(How = How.XPath, Using = "//*[contains(., 'T-Shirts')]")]
        private IWebElement TShirts;



    }
}
