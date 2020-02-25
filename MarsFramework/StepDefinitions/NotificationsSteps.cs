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
    public class NotificationsSteps
    {
        [Given(@"I have go to the notification page")]
        public void GivenIHaveGoToTheNotificationPage()
        {
            Notifications notifications = new Notifications();
            notifications.Notification_See_and_Select_All_Make_As_Read();
            Thread.Sleep(1000);
        }
        
        [Then(@"Clicked show All and it will show all the results")]
        public void ThenClickedShowAllAndItWillShowAllTheResults()
        {
            Assert.AreEqual("Notifications", Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/a/h1")).Text);
        }
    }
}
