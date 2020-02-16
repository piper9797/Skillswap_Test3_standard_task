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

               
              
                /*GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", "//th[@xpath='1'][contains(.,'Skill')]", 9000);
                var newSkill = Global.GlobalDefinitions.driver.FindElement(By.XPath("//th[@xpath='1'][contains(.,'Skill')]"));


                bool judge = true;
                
                while (judge)
                {
                    for (int i = 1; i <= 10; i++)
                    {

                        GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", newSkill.Text, 2000);

                        IWebElement skillContent = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));

                        IWebElement levelContent = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "/tr/td[2]"));

                        if (skillContent.Text.Equals("postman"))
                        {
                            if (levelContent.Text.Equals("Beginner"))
                            {
                                judge = false;
                                Assert.IsFalse(judge);
                            }

                        }
                        i++;
                    }
                    judge = false;
                    Assert.IsTrue(judge);
                }*/
            }








        }
    }
}