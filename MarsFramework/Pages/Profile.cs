using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "(//i[contains(@class,'right floated outline small write icon')])[1]")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }


        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement AvailabilityHours { get; set; }

        //Click on Availability Hour option
        [FindsBy(How = How.Name, Using = "availabiltyHour")]
        private IWebElement AvailabilityHoursOpt { get; set; }


        //Click on salary
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement Salary { get; set; }

        [FindsBy(How = How.Name, Using = "availabiltyTarget")]
        private IWebElement SalaryOpt { get; set; }

        //------------------------------------------------------------------------------------
        //Click on Add new to add new Language
        [FindsBy(How = How.XPath, Using = "(//div[@class='ui teal button '][contains(.,'Add New')])[1]")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        private IWebElement AddLangText { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "(//div[contains(.,'Add New')])[11]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddLang { get; set; }
        //------------------------------------------------------------------------------------

        //change to skill page
        [FindsBy(How = How.XPath, Using = "//a[@class='item'][contains(.,'Skills')]")]
        private IWebElement NewSkillPage { get; set; }

        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button'][contains(.,'Add New')]")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @name='name']")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='level']")]
        private IWebElement ChooseSkill { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddSkill { get; set; }
        //------------------------------------------------------------------------------------

        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddCerti { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        private IWebElement Description { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@name='value']")]
        private IWebElement DescriptionTextArea { get; set; }


        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//button[@class='ui teal button' and @type='button']")]
        private IWebElement DesSave { get; set; }

        #endregion


        internal void Edit_Availability_Hours_Earn_Target()
        {
            //edit availability
            Thread.Sleep(2000);
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", AvailabilityTimeEdit.Text, 2000);
            AvailabilityTimeEdit.Click();
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "Name", AvailabilityTime.Text, 2000);
            AvailabilityTime.Click();
            var selectTime = new SelectElement(AvailabilityTime);
            selectTime.SelectByText("Full Time");

            //edit the hours
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", AvailabilityHours.Text, 2000);
            AvailabilityHours.Click();
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "Name", AvailabilityHoursOpt.Text, 2000);
            AvailabilityHoursOpt.Click();
            var selectHours = new SelectElement(AvailabilityHoursOpt);
            selectHours.SelectByText("As needed");

            //edit Earn Target
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", Salary.Text, 2000);
            Salary.Click();
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "Name", SalaryOpt.Text, 2000);
            SalaryOpt.Click();
            var selectSelary = new SelectElement(SalaryOpt);
            selectSelary.SelectByText("More than $1000 per month");

            //edit desciption
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", Description.Text, 2000);
            Description.Click();
            DescriptionTextArea.Clear();
            DescriptionTextArea.SendKeys("A good tester. That is me!");
            DesSave.Click();
        }


        internal void Add_Languages()
        {
            //read data from the excel
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddNewLanguages");
            Thread.Sleep(2000);
            //add the language
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", AddNewSkillBtn.Text, 2000);
            AddNewLangBtn.Click();
            AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));
            ChooseSkill.Click();
            var chooseSkillOpt = new SelectElement(ChooseSkill);
            chooseSkillOpt.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Level"));
            AddSkill.Click();
        }

        internal void Add_Skills()
        {

            //read data from the excel
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");
            Thread.Sleep(2000);

            // look up if there is a repeated data

            NewSkillPage.Click();
            //add a new skill
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", AddNewSkillBtn.Text, 2000);
            AddNewSkillBtn.Click();
            AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));
            ChooseSkill.Click();
            var chooseSkillOpt = new SelectElement(ChooseSkill);
            chooseSkillOpt.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Level"));
            AddSkill.Click();




            bool judge = true;
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", AddNewSkillBtn.Text, 2000);
            IWebElement skillContent = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]"));

           
            
            while (judge)
            {
                for (int j = 1; j <= 10; j++)
                {
                    IWebElement levelContent = Global.GlobalDefinitions.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
                    if (skillContent.Text.Equals("postman"))
                    {
                        if (levelContent.Text.Equals("Beginner"))
                        {
                            judge = false;
                            Assert.IsFalse(judge);
                            break;
                        }

                    }
                    j++;
                }
                judge = false;
                Assert.IsFalse(judge);
            }

        }
    }
}
