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

        //Click on Educaiton Page
        [FindsBy(How = How.XPath, Using = "//a[@class='item' and @data-tab='third']")]
        private IWebElement Education { get; set; }
       
        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.Name, Using = "instituteName")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.Name, Using = "country")]
        private IWebElement ChooseCountry { get; set; }


        //Click on Title dropdown
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement ChooseTitle { get; set; }

        //Degree
        [FindsBy(How = How.Name, Using = "degree")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.Name, Using = "yearOfGraduation")]
        private IWebElement DegreeYear { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddEdu { get; set; }

        //-------------------------------------------------------------------------------------------------

        // Click Certificate
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")]
        private IWebElement Certi { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationName']")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.Name, Using = "certificationFrom")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.Name, Using = "certificationYear")]
        private IWebElement CertiYear { get; set; }


        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddCerti { get; set; }


        //--------------------------------------------------------------------------------------------

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
            Thread.Sleep(1000);
            //close the pop up window
            GlobalDefinitions.driver.FindElement(By.XPath("//a[@href ='#']")).Click();
        }

        internal void Add_Education()
        {
            //read data from the excel
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddEduction");
            Thread.Sleep(1000);
            Education.Click();
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", AddNewEducation.Text, 2000);
            AddNewEducation.Click();
            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "university"));
            var countryOpt = new SelectElement(ChooseCountry);
            countryOpt.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "country"));
            var titleOpt = new SelectElement(ChooseTitle);
            titleOpt.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "title"));
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "degree"));
            var graduationOpt = new SelectElement(DegreeYear);
            graduationOpt.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "graduation year"));
            AddEdu.Click();
            Thread.Sleep(1000);
            //close the pop up window
            GlobalDefinitions.driver.FindElement(By.XPath("//a[@href ='#']")).Click();



        }


        internal void Add_Certifications()
        { 
            //read data from the excel
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddCertifications");
            Thread.Sleep(2000);
            Certi.Click();
            AddNewCerti.Click();
            GlobalDefinitions.WaitForElement(Global.GlobalDefinitions.driver, "XPath", EnterCerti.Text, 2000);
            EnterCerti.SendKeys("Advanced Certificate");
           // EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "certification"));
            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "From"));
            var yearOpt = new SelectElement(CertiYear);
            yearOpt.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "year"));
            AddCerti.Click();
            Thread.Sleep(1000);
            //close the pop up window
            GlobalDefinitions.driver.FindElement(By.XPath("//a[@href ='#']")).Click();

        }













    }
}
