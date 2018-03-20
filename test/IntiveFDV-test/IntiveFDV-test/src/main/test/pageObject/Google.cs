using OpenQA.Selenium;
using System;
using System.Threading;

namespace IntiveFDV_test.src.main.test.pageObject
{
    public class Google
    {
        private IWebDriver driver;
        public Google(IWebDriver driver) 
        {
            Console.WriteLine("Google: Creating a instance");
            try
            {
                this.driver = driver;
                driver.Navigate().GoToUrl("https://www.google.com");
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
           
        }
        public void search(string toSearch)
        {
            Console.WriteLine("Google: Starting to Search the value: "+toSearch+".");
            try
            {
                driver.FindElement(By.Id("lst-ib")).SendKeys(toSearch);
                driver.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
        }

        public void clickOnFirstContain(string value)
        {
            Console.WriteLine("Google: Clicking on the firts result with the value: " + value + ".");
            try
            {
                string url = value.ToLower();
                IWebElement line = driver.FindElement(By.XPath("//div//h3//a[contains(@href,'" + url + "')]"));
                line.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
            }
            
        }
        
       
    }
}
