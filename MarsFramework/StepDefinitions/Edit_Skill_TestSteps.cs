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
    public class Edit_Skill_TestSteps
    {
        [Given(@"I have entered managelist page and edit the skill I wrote before")]
        public void GivenIHaveEnteredManagelistPageAndEditTheSkillIWroteBefore()
        {
            // share a new skill
            ShareSkill shareSkill = new ShareSkill();
            shareSkill.EditShareSkill();
            //Assert
            Thread.Sleep(2000);

        }

        [Then(@"the result can be edited")]
        public void ThenTheResultCanBeEdited()

        {
            var titleElement = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")).Text;

            Assert.AreEqual("Arts", titleElement);
        }
    }
}
