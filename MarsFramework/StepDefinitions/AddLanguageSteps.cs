using MarsFramework.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using MarsFramework.Global;

namespace MarsFramework.StepDefinitions
{
    [Binding]
    public class AddLanguageSteps
    {
        [Then(@"I should be abele to add language")]
        public void ThenIShouldBeAbeleToAddLanguage()
        {
            Profile profile = new Profile();
            profile.Add_Languages();

            //after clicking the "x" button in the pop window.Wait 1 sec to show all the original paths
            Thread.Sleep(2000);
            bool judge = true;
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddNewLanguages");

            //Asserstion
           /* while (judge)
            {

                for (int j = 1; j <= 5; j++)
                {
                    //each language
                    IWebElement languageContent = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + j + "]/tr/td[1]"));

                    //If we can find the content we just added, we can assert the same false to them, so it can break the while statement and make sure the assertion is right
                    if (languageContent.Text.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Language")))
                    {

                        judge = false;
                        Assert.IsFalse(judge);
                        return;


                    }
                    j++;
                }
                //if we cannot find that, we assert a wrong value
                judge = false;
                Assert.IsTrue(judge);
            }*/
        }
    }
}
