using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;


namespace MarsFramework.Pages
{
   internal class Manage_Request
    {
        public Manage_Request()
        {
           PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on manage requests
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]")]
        private IWebElement manage_Request { get; set; }

        //Click on recieve requests
        [FindsBy(How = How.XPath, Using = "(//a[@href='/Home/ReceivedRequest'])[3]")]
        private IWebElement receive_Request { get; set; }


        //Click on send requests
        [FindsBy(How = How.XPath, Using = "//a[@href='/Home/SentRequest']")]
        private IWebElement send_Request { get; set; }




        internal void Receive_Request()
        {
            Thread.Sleep(1000);
           
            Actions action = new Actions(Global.GlobalDefinitions.driver);
            action.MoveToElement(manage_Request).Perform();
            manage_Request.Click();
            Thread.Sleep(2000);
            receive_Request.Click();
        }

        internal void Send_Request()
        {
            Thread.Sleep(1000);

            Actions action = new Actions(Global.GlobalDefinitions.driver);
            action.MoveToElement(manage_Request).Perform();
            manage_Request.Click();
            Thread.Sleep(1000);
            send_Request.Click();
        }



    }
}
