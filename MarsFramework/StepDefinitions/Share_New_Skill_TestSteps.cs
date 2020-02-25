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
    public class Share_New_Skill_TestSteps
    {
        [Given(@"I have gone to shark skill page and filled up all the information")]
        public void GivenIHaveGoneToSharkSkillPageAndFilledUpAllTheInformation()
        {
            // share a new skill
            ShareSkill shareSkill = new ShareSkill();
            shareSkill.ShareNewSkill();
            //Assert
            Thread.Sleep(2000);
         
        }
        
        [Then(@"new skill will be added in the system")]
        public void ThenNewSkillWillBeAddedInTheSystem()

        {
            var titleElement = Global.GlobalDefinitions.driver.FindElement(By.XPath("//tr[1]//td[3]")).Text;
            Assert.AreEqual("Thai boxing", titleElement);
        }
    }
}
