using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class Chat
    {
            public Chat()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }






        //Click on chat button
        [FindsBy(How = How.LinkText, Using = "Chat")]
        private IWebElement chat_button { get; set; }

        //Click on chat textarea
        [FindsBy(How = How.Id, Using = "chatTextBox")]
        private IWebElement textarea { get; set; }

        //Click on chat send button
        [FindsBy(How = How.Id, Using = "btnSend")]
        private IWebElement send_Btn { get; set; }


        internal void chat()
        {
            Thread.Sleep(1000);
            chat_button.Click();
            Thread.Sleep(1000);
            textarea.SendKeys("Bye");
            send_Btn.Click();


        }






    }
}
