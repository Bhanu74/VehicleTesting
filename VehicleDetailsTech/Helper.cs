using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace VehicleDetailsTech
{
    [TestClass]
    public  class Helper
    {
       public RemoteWebDriver Driver { set; get; }
        public static  IWebDriver driver = new ChromeDriver();
        WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

     

        [AfterScenario]
        public void Teardown()
        {
            try
            {
                driver.Quit();
            }
            catch
            {

            }
        }

    }
}
