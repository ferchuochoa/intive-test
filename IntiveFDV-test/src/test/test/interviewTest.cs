using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using IntiveFDV_test.src.main.test.pageObject;


namespace IntiveFDV_test
{
    [TestClass]
     public class InterviewTest
     {
        private IWebDriver driver;
        private string browserName;

        [SetUp]
        public void SetUp()
        {
            //run Chrome as default browser if the parameter is missing
            browserName = NUnit.Framework.TestContext.Parameters.Get("Browser","Chrome");
            this.driver = BrowserFactory.InitBrowser(browserName);
            driver.Manage().Window.Maximize();
            Console.WriteLine("the browser selected is: "+ browserName);
        }

        [TearDown]
        public void TearDown()
        {
            this.driver.Quit();
        }

        [Test]
        [Category("interviewTest")]
        public void interviewTest()
        {
            Console.WriteLine("InterviewTest: Starting the Interview test case... ");
            Google google = new Google(driver);
            google.searchAndEnter("Seleniumhq");
            google.clickOnFirstContain("Seleniumhq");

            Console.WriteLine("InterviewTest: The test case was finished successfully.");
        }
    }
}
