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
    public class Search_Skills_By_FliterSteps
    {
        [Given(@"I have entered the search page and click each fliter")]
        public void GivenIHaveEnteredTheSearchPageAndClickEachFliter()
        {
            Search_page search_page = new Search_page();
            search_page.SearchSearch_Skill_by_filter();
            Thread.Sleep(1000);
        }
        
        [Then(@"the result should be differnt when I clicked different fliter")]
        public void ThenTheResultShouldBeDifferntWhenIClickedDifferentFliter()
        {
            Assert.IsNotNull(Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[1]")).Text);
        }
    }
}
