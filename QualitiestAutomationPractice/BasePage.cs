using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace QualitiestAutomationPractice
{
    class BasePage
    {
        IWebDriver driver;

        [SetUp]
        public void Initalize()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Launch()
        {

            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

        }

        [TearDown]
        public void EndSession()
        {
            driver.Dispose();
        }
    }
}
