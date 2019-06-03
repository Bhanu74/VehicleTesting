using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace VehicleDetailsTech
{ 
   
    public class Helper2

    {

        public static IWebDriver driver = new ChromeDriver();


        public static Func<IWebDriver, IWebElement> ElementIsClickable(By locator)
        {
            return driver =>
            {
                Thread.Sleep(2000);
                var element = driver.FindElement(locator);
                return (element != null && element.Displayed && element.Enabled) ? element : null;
            };

        }

        [TearDown]
        public void closeDriver()
        {
            driver.Close();
            {

                try
                {
                    driver.Quit();
                }
                catch { }

            }

        }


    }

