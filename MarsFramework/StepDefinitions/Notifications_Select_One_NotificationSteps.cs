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
    public class Notifications_Select_One_NotificationSteps
    {
        [Given(@"I have navigate to the notification page")]
        public void GivenIHaveNavigateToTheNotificationPage()
        {
            Notifications notifications = new Notifications();
            notifications.Notification_select_one();
            Thread.Sleep(1000);
        }
        
        [Then(@"Select one and it will show one of all results")]
        public void ThenSelectOneAndItWillShowOneOfAllResults()
        {
            Assert.AreEqual("Category", Global.GlobalDefinitions.driver.FindElement(By.XPath("//th[contains(text(),'Category')]")).Text);
        }
    }
}
