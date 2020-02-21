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
   internal class Search_page
    {

        public Search_page()
    {
        PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
    }


        //Click on search button
        [FindsBy(How = How.XPath, Using = "(//i[contains(@class,'search link icon')])[1]")]
        private IWebElement search_button { get; set; }

        //Click on grapics&design button
        [FindsBy(How = How.XPath, Using = "(//a[@role='listitem'])[2]")]
        private IWebElement grapics_Button { get; set; }

        //Click on showAll button
        [FindsBy(How = How.XPath, Using = " //button[@class='ui button'][contains(.,'ShowAll')]")]
        private IWebElement showAll_Button { get; set; }
       


        internal void SearchSearch_Skill_by_Categories() 
        {
            Thread.Sleep(1000);
            search_button.Click();
            // GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", grapics_Button.Text, 2000);
            Thread.Sleep(1000);
            grapics_Button.Click();
            
        }

        internal void SearchSearch_Skill_by_filter()
        {

            Thread.Sleep(1000);
            search_button.Click();
            Thread.Sleep(1000);
            showAll_Button.Click();

        }

    }
}
