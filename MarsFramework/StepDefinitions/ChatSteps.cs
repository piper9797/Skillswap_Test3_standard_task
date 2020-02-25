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
    public class ChatSteps
    {
        [Given(@"I have entered chat page and send one message to someone")]
        public void GivenIHaveEnteredChatPageAndSendOneMessageToSomeone()
        {
            Chat chat = new Chat();
            chat.chat();
            Thread.Sleep(1000);
        }
        
        [Then(@"the chat histry should be on the screen")]
        public void ThenTheChatHistryShouldBeOnTheScreen()
        {
            Assert.AreEqual("Bye", Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div/div/span/div[19]/div/div")).Text);
        }
    }
}
