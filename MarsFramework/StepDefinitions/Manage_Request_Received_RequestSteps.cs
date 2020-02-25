using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using MarsFramework.Global;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using MarsFramework.Pages;

namespace MarsFramework.StepDefinitions
{
    [Binding]
    public class Manage_Request_Received_RequestSteps
    {
        [Given(@"I have entered received request page and checked")]
        public void GivenIHaveEnteredReceivedRequestPageAndChecked()
        {
           
                Manage_Request manageRequest = new Manage_Request();
                manageRequest.Receive_Request();
                Thread.Sleep(1000);
            
        }
        
        [Then(@"I should be able to check the request I received")]
        public void ThenIShouldBeAbleToCheckTheRequestIReceived()
        {
            Assert.IsNotNull(Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[1]/td[1]")).Text);
        }
    }
}
