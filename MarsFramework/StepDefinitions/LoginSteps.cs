using MarsFramework.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using MarsFramework.Global;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Chrome;

namespace MarsFramework.StepDefinitions
{
   
    [Binding]
    public class LoginSteps
    {
     [BeforeScenario]

        public static void Initialize()
        {
            Base.Initialize();

        }

        [AfterScenario]
        public static void TearDown()
        {
            Base.End();

        }


        [Then(@"I shoule be able to login with valid information.")]
        public void ThenIShouleBeAbleToLoginWithValidInformation_()
        {


           //do nothing
        }
    }
}
