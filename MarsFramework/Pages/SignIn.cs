using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MarsFramework.Pages
{
    class SignIn
    {


        // PageFactory.InitElements(Global.GlobalDefinitions.driver, this);


        public IWebElement SignIntab => Global.GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(text(),'Sign')]"));
        public IWebElement Email => Global.GlobalDefinitions.driver.FindElement(By.Name("email"));
        public IWebElement Password => Global.GlobalDefinitions.driver.FindElement(By.Name("password"));
        public IWebElement LoginBtn => Global.GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));




        /*#region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion*/

        public void LoginSteps()
        {

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");
            // navigate to the website
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2, "Url"));
            Thread.Sleep(2000);
            //login btn
            SignIntab.Click();
            // fill in user's information
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));
            // click the login btn 
            LoginBtn.Click();

        }
    }
}
