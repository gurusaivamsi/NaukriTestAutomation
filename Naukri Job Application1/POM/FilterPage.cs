using Naukri_Job_Application1.BaseClasses;
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using NUnit.Framework.Internal;


namespace Naukri_Job_Application1.POM
{
    public class FilterPage : BaseClass
    {
        //[FindsBy(How = How.XPath, Using = "//span[@title='1 - 19 of 24036 ']")]
        //private IWebElement Result;

        [FindsBy(How = How.XPath, Using = "//h1[normalize-space()='Software Tester Jobs In Bengaluru']")]//Title of the Software Tester
        private IWebElement Result1;
        [FindsBy(How = How.XPath, Using = "//*[@title=\"10-15 Lakhs\"])[1]")]//Salary Check Box Click
        private IWebElement Salary;

        [FindsBy(How = How.XPath, Using = "//*[@title=\"IT Services & Consulting\"]")]//Check Box Click
        private IWebElement Industry;

        [FindsBy(How = How.XPath, Using = "//*[@class=\"rc-slider-track\"]")]//Check Box Click
        private IWebElement exp;

        [FindsBy(How = How.XPath, Using = "//*[@class=\"styles_appliedTxt__UmIjs\"]")]//Slide
        private IWebElement var;

        [FindsBy(How = How.XPath, Using = "//div[@class='styles_filter-wrapper-component__4OBpS']")]//all filters
        private IWebElement allfilters;
        [FindsBy(How = How.XPath, Using = "//*[@id='listContainer']/div[2]/div/div[1]/div/div[1]/a")]//list of container
        private IWebElement Result2;
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'No results found')]")]//no result found display
        private IWebElement Result3;
        [FindsBy(How = How.LinkText, Using = "Send me jobs like these")]//click on send me job like these
        private IWebElement Result4;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter alert name']")]//Valid Aleter Name
        private IWebElement Result5;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter your active Email ID']")]//Invalid Email Id
        private IWebElement Result6;
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Save']")]//Click On Save Button
        private IWebElement Result7;

        [FindsBy(How = How.LinkText, Using = "Send me jobs like these")]//click on send me job like these
        private IWebElement Result8;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter alert name']")]//valid Alert Name 
        private IWebElement Result9;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter your active Email ID']")]//Active Email Id
        private IWebElement Result10;
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Save']")]//Click On Save Button
        private IWebElement Result11;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/main[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[2]/a[1]")]//Click On Complete Pprofile Button
        private IWebElement CompleteProfile;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"root\"]/div/div/span/div/div/div/div/div/div[2]/div[1]/div/div/ul/li[4]")]//Click On Key Skill
        private IWebElement KeySkill;
        [FindsBy(How = How.XPath, Using = "//div[@class='widgetHead typ-16Bold']//span[@class='edit icon'][normalize-space()='editOneTheme']")]//Click On Edit Button
        private IWebElement Edit;

        [FindsBy(How = How.XPath, Using = "//input[@id='keySkillSugg']")]//Key Skill Add
        private IWebElement AddKeySkill;

        [FindsBy(How = How.XPath, Using = "//button[@id='saveKeySkills']")]//Click On Save Button
        private IWebElement Save;

        [FindsBy(How = How.XPath, Using = "//div[@title='ETL']//a[@class='material-icons close'][normalize-space()='Cross']")]//Delete Skill
        private IWebElement DeleteSkill;







        public FilterPage()
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);

        }



        //1.Basic Job Search
        public string AssetResult()
        {

            return Result1.Text;




        }

        //2.Advanced Job Search - Filters
        public void AdvancedJobSearchMethod1()
        {
            Salary.Click();
            Industry.Click();
            Actions actions = new Actions(driver);
            actions.DragAndDropToOffset(exp, 17, 0).Build().Perform();
            var.Click();
            allfilters.Click();
            //return search;

        }
        public string AssetResult1()
        {

            return allfilters.Text;





        }
        //6.Company Search and Details Verification

        public bool CompanySearchandDetails()
        {

            return Result2.Displayed;




        }
        //11.Error Handling - Invalid Search Results
        public String ErrorHandling()
        {

            return Result3.Text;




        }
        //15.Job Alerts - Invalid Email Subscription
        public void JobAlertsInvalid()
        {
            Result4.Click();
            Result5.SendKeys("software tester");
            Result6.SendKeys("saivamsiguru4577@gmail.com");
            Result7.Click();
            Thread.Sleep(6000);
            //return search;

        }
        //5.Email Subscription - Job Alerts
        public void JobAlerts()
        {
            Result8.Click();
            Result9.SendKeys("software testers");
            Result10.SendKeys("saivamsiguru457776@gmail.com");
            Result11.Click();
            Thread.Sleep(6000);
            //return search;

        }

        //4.Profile Update - Skill Addition
        public void Skilladdition()
        {
            CompleteProfile.Click();
            KeySkill.Click();
            Edit.Click();
            AddKeySkill.SendKeys("ETL");
            Save.Click();



        }
        //14.Profile Management - Delete Skill
        public void Skilldeletion()
        {
            CompleteProfile.Click();
            KeySkill.Click();
            Edit.Click();
            DeleteSkill.SendKeys("ETL");
            Save.Click();



        }
        //3.Job Application Process
        /*public void JobApplication ()
        {

            // Navigate to the specific job listing page
            driver.Navigate().GoToUrl("https://codeachi.com/jobs");//Navigate Job Url




        }*/
    }
}
    
