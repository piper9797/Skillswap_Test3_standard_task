using MarsFramework.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using MarsFramework.Global;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace MarsFramework.StepDefinitions
{
    [Binding]
    public class Manage_Request_Sent_RequestSteps
    {
        [Given(@"I have entered send request page and checked")]
        public void GivenIHaveEnteredSendRequestPageAndChecked()
        {
            Manage_Request manageRequest = new Manage_Request();
            manageRequest.Send_Request();
            Thread.Sleep(1000);
        }
        
        [Then(@"I should be able to check the request I sent")]
        public void ThenIShouldBeAbleToCheckTheRequestISent()
        {
            Assert.IsNotNull(Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[1]/td[1]")).Text);
        }
    }
}
