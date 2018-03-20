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


        [SetUp]
        public void SetUp()
        {
            //run Chrome like default browser if the parameter is missing
            var browser = NUnit.Framework.TestContext.Parameters.Get("Browser","Chrome");
            this.driver = BrowserFactory.InitBrowser(browser);
            driver.Manage().Window.Maximize();
            Console.WriteLine("the browser selected is: "+ browser);
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
            google.search("Seleniumhq");
            google.clickOnFirstContain("Seleniumhq");

            Console.WriteLine("InterviewTest: The test case was finished successfully.");
        }
    }
}
