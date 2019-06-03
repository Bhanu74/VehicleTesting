using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace VehicleDetailsTech
{
    [Binding]
    public sealed class VehicleTechSteps :Helper
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        

        //private readonly ScenarioContext context;
       

        //public VehicleTechSteps(ScenarioContext injectedContext)
        //{
        //    context = injectedContext;
        //}


        public WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

        [Given(@"I am in URL https://covercheck\.vwfsinsuranceportal\.co\.uk/")]
        public void GivenIAmInURLHttpsCovercheck_Vwfsinsuranceportal_Co_Uk()
        {
             driver.Navigate().GoToUrl("https://covercheck.vwfsinsuranceportal.co.uk/");
            
         }
    
        
        [When(@"I enter Vehicle registration number (.*)")]
        public void WhenIEnterVehicleRegistrationNumberOVUYY(string ValidRegNum)
        {
            driver.FindElement(By.CssSelector("#vehicleReg")).SendKeys(ValidRegNum);
        }

        [When(@"I press submit button")]
        public void WhenIPressSubmitbutton()
        {
            driver.FindElement(By.Id("icon")).Click();
        }

        [Then(@"I should  see vehicle detail")]
        public void ThenIShouldSeeVehicleDetail()
        {
            wait.Until(c => c.FindElement(By.CssSelector(".result")));
            Assert.IsTrue(driver.FindElement(By.CssSelector(".result")).Text.Contains("Result for : OV12UYY"));
            
        }
        

        [When(@"I enter invalid registration details (.*)")]
        public void WhenIEnterInvalidRegistrationDetailsOVYY(string RegNum)
        {
            driver.FindElement(By.CssSelector("#vehicleReg")).SendKeys(RegNum);
        }

        
        [Then(@"I should see a  message")]
        public void ThenIShouldSeeAMessage()
        {
            
            wait.Until(c => c.FindElement(By.CssSelector(".result")));
            Assert.IsTrue(driver.FindElement(By.CssSelector(".result")).Text.Contains("Sorry record not found"));
        }


        [Then(@"a message is displayed")]
        public void ThenAMessageIsDisplayed()
        {

            Assert.IsTrue(driver.FindElement(By.ClassName("error-required")).Text.Contains("Please enter a valid car registration"));
            
        }
        

    }
}

