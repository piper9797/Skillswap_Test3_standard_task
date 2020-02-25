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
    public class SearchSkillsSteps
    {
        [Given(@"I have enter a key word in search textarea And I have clicked the search button")]
        public void GivenIHaveEnterAKeyWordInSearchTextareaAndIHaveClickedTheSearchButton()
        {
            Search_page search_page = new Search_page();
            search_page.SearchSearch_Skill_by_Categories();
            Thread.Sleep(1000);
        }
        
        [Then(@"all the relative result should be on the screen")]
        public void ThenAllTheRelativeResultShouldBeOnTheScreen()
        {
            Assert.IsNotNull(Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]")).Text);
        }
    }
}
