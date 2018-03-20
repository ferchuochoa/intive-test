using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Configuration;

namespace IntiveFDV_test.src.main.test.pageObject
{
    public class BrowserFactory
    {
        private static IWebDriver driver;
        
        public static IWebDriver InitBrowser(string browserName)
        {
            string path = "";
            try
            {
                switch (browserName)
                {
                    case "FireFox":
                        try
                        {
                            path = ConfigurationManager.AppSettings["URL FireFox"];
                            path = Environment.ExpandEnvironmentVariables(path);
                            Console.WriteLine(path);
                            driver = new FirefoxDriver(path);
                            driver.Navigate().Refresh();
                            break;
                        }
                        catch (Exception)
                        {

                            throw;
                        }


                    case "IE":
                        try
                        {
                            path = ConfigurationManager.AppSettings["URL IE"];
                            path = Environment.ExpandEnvironmentVariables(path);
                            Console.WriteLine(path);
                            driver = new InternetExplorerDriver(path);
                            break;
                        }
                        catch (Exception)
                        {

                            throw;
                        }


                    case "Chrome":
                        try
                        {
                            path = ConfigurationManager.AppSettings["URL Chrome"];
                            path = Environment.ExpandEnvironmentVariables(path);
                            Console.WriteLine(path);
                            driver = new ChromeDriver(path);
                            break;
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                }
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occurred: '{0}'", e);
            }
            
            return driver;
        }
    }
}
