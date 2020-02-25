using MarsFramework.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace MarsFramework.StepDefinitions
{
    [Binding]
    public class EditProfileSteps_details
    {
        [Given(@"I have navigated to profile page")]
        public void GivenIHaveNavigatedToProfilePage()
        {
          //
        }
        
        [Then(@"I should be abele to Edit_Loc, Availability, Hours, Earn Target")]
        public void ThenIShouldBeAbeleToEdit_LocAvailabilityHoursEarnTarget()
        {
            Profile profile = new Profile();
            profile.Edit_Availability_Hours_Earn_Target();
            Thread.Sleep(1000);
            //verify if the time avaliability is as expected
            Assert.AreEqual("Full Time", Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span")).Text.Substring(0, 9));

        }
    }
}
