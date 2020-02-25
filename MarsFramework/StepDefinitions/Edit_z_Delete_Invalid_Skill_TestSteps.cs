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
    public class Edit_z_Delete_Invalid_Skill_TestSteps
    {
        [Given(@"I have entered managelist page and delete the skill I wrote before")]
        public void GivenIHaveEnteredManagelistPageAndDeleteTheSkillIWroteBefore()
        {
            ShareSkill shareSkill = new ShareSkill();
            shareSkill.DeleteShareSkill();
        }
        
        [Then(@"the result can be deleted")]
        public void ThenTheResultCanBeDeleted()
        {
           //
        }
    }
}
