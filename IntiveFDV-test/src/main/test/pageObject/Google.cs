﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Google: An error occurred when try to load the driver: '{0}'", e);
                throw;
            }
           
        }
        public void searchAndEnter(string toSearch, string browserName)
        {
            Console.WriteLine("Google: Starting to Search the value: "+toSearch+".");
            try
            {
                IWebElement input = driver.FindElement(By.Id("lst-ib"));
                input.SendKeys(toSearch);

                if (browserName.Equals("FireFox"))
                {
                    //In Firefox doen´t work the option Keys.Enter
                    
                    driver.FindElement(By.Name("btnK")).Click();
                }
                else
                {
                    input.SendKeys(Keys.Enter);
                   
                }
                
                
                
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Google: An error occurred when try to search "+toSearch+": '{0}'", e);
                throw;
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
                Console.WriteLine("Google: An error occurred when try to click on the first result with value "+value+": '{0}'", e);
                throw;
            }
            
        }
        
       
    }
}
