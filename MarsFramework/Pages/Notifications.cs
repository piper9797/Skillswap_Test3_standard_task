using MarsFramework.Global;
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
   

    class Notifications
    {
      public Notifications()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on notification Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/div")]
        private IWebElement notificationButton { get; set; }


        //Click on see_All Button
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'See All...')]")]
        private IWebElement see_All { get; set; }

        //Click on select_All Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[1]/div[1]")]
        private IWebElement select_All { get; set; }

        //Click on make_All_As_Read Button
        [FindsBy(How = How.XPath, Using = "//div[@class='seven wide column']//div[4]")]
        private IWebElement mark_All_As_Read { get; set; }


        //Click on select_One Button
        [FindsBy(How = How.XPath, Using = "//div[@name='5df755efbff75c0005f20d38']")]
        private IWebElement select_One { get; set; }

        internal void Notification_See_and_Select_All_Make_As_Read()
        {
            Thread.Sleep(2000);
            notificationButton.Click();
            Thread.Sleep(1000);
            see_All.Click();
            Thread.Sleep(1000);
            select_All.Click();
            mark_All_As_Read.Click();
            Thread.Sleep(1000);
            GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/a")).Click();

        }

        internal void Notification_select_one()
        {
            Thread.Sleep(1000);
            notificationButton.Click();
            Thread.Sleep(1000);
            select_One.Click();
       
        }



    }
}
