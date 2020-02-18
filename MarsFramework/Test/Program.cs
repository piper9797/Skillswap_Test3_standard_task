using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]

            public void Share_New_Skill_Test()
            {

                // share a new skill
                ShareSkill shareSkill = new ShareSkill();
                shareSkill.ShareNewSkill();
                //Assert
                Thread.Sleep(2000);
                var titleElement = Global.GlobalDefinitions.driver.FindElement(By.XPath("//tr[1]//td[3]")).Text;
                Assert.AreEqual("Thai boxing", titleElement);
            }


            [Test]
            public void Edit_Skill_Test()
            {

                // share a new skill
                ShareSkill shareSkill = new ShareSkill();
                shareSkill.EditShareSkill();
                //Assert
                Thread.Sleep(2000);
                var titleElement = Global.GlobalDefinitions.driver.FindElement(By.XPath("//tr[1]//td[3]")).Text;
                Assert.AreEqual("Arts", titleElement);
            }

            [Test]
            public void Delete_Invalid_Skill_Test()
            {

                ShareSkill shareSkill = new ShareSkill();
                shareSkill.DeleteShareSkill();

            }


            [Test]

            public void Profile_page_Edit_Availability_Hours_Earn_Target()
            {
                Profile profile = new Profile();
                profile.Edit_Availability_Hours_Earn_Target();
                //verify if the time avaliability is as expected
                Assert.AreEqual("Part Time", Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span")).Text.Substring(0, 9));

            }

            [Test]

            public void Profile_page_Add_Languages()
            {
                Profile profile = new Profile();
                profile.Add_Languages();
                var newLanguage = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
                GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", newLanguage.Text, 2000);
                Assert.AreEqual("Mandarin", newLanguage.Text);
            }

            [Test]

            public void Profile_page_Add_Skills()
            {
                Profile profile = new Profile();
                profile.Add_Skills();
              

                //after clicking the "x" button in the pop window.Wait 1 sec to show all the original paths
                Thread.Sleep(1000);
                bool judge = true;
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");

                //Asserstion
                while (judge)
                {

                    for (int j = 1; j <= 5; j++)
                    {
                        //each skill
                        IWebElement skillContent = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody["+j+"]/tr/td[1]"));
                        //each level
                        IWebElement levelContent = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + j + "]/tr/td[2]"));

                        //If we can find the content we just added, we can assert the same false to them, so it can break the while statement and make sure the assertion is right
                        if (skillContent.Text.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Skill")))
                        {
                            if (levelContent.Text.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "Level")))
                            {
                                judge = false;
                                Assert.IsFalse(judge);
                                return;
                            }

                        }
                        j++;
                    }
                    //if we cannot find that, we assert a wrong value
                    judge = false;
                    Assert.IsTrue(judge);
                }

            }

            [Test]

            public void Profile_page_Add_Education()
            {
                Profile profile = new Profile();
                profile.Add_Education();
                //after clicking the "x" button in the pop window.Wait 1 sec to show all the original paths
                Thread.Sleep(1000);
                bool judge = true;
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddEduction");

                //Asserstion
                while (judge)
                {

                    for (int j = 1; j <= 5; j++)
                    {
                        
                        IWebElement univeristyContent = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + j + "]/tr/td[2]"));

                        //If we can find the content we just added, we can assert the same false to them, so it can break the while statement and make sure the assertion is right
                        
                            if (univeristyContent.Text.Equals(GlobalDefinitions.ExcelLib.ReadData(2, "university")))
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
                }


            }


            [Test]

            public void Profile_page_Add_Certification()
            {
                Profile profile = new Profile();
                profile.Add_Certifications();
                //after clicking the "x" button in the pop window.Wait 1 sec to show all the original paths
                Thread.Sleep(1000);
                bool judge = true;
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddCertifications");

                //Asserstion
                while (judge)
                {

                    for (int j = 1; j <= 5; j++)
                    {
                     
                        IWebElement univeristyContent = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + j + "]/tr/td[1]"));

                        //If we can find the content we just added, we can assert the same false to them, so it can break the while statement and make sure the assertion is right
                        if (univeristyContent.Text.Equals("Advanced Certificate"))
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
                }


            }

       



            [Test]

            public void Search_Skill_by_Categories()
            {
               

            }







        }
    }
}