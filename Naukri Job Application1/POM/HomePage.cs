using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using BasePageObjectModel;
using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace Naukri_Job_Application1.POM
{

    public class HomePage : BaseClass
    {
        [FindsBy(How = How.XPath, Using = "//span[@class='nI-gNb-sb__placeholder']")]//jobSearch Here
        private IWebElement SearchJobsHere;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter keyword / designation / companies']")]//Enter Keyword
        private IWebElement EnterKeyword;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter location']")]//Enter Location 
        private IWebElement EnterLocation;
        [FindsBy(How = How.XPath, Using = "//button[@class='nI-gNb-sb__icon-wrapper']")]//Click On Search Button
        private IWebElement SearchButton;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter keyword / designation / companies']")]
        private IWebElement EnterCompany;

        [FindsBy(How = How.XPath, Using = "//span[@class='nI-gNb-sb__placeholder']")]//jobSearch Here
        private IWebElement SearchJobsHere1;
        [FindsBy(How = How.XPath, Using = "//button[@class='nI-gNb-sb__icon-wrapper']")]//Click On Search Button
        private IWebElement SearchButton1;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter keyword / designation / companies']")]//Enter Keyword
        private IWebElement EnterCompany1;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter location']")]
        private IWebElement EnterLocation1;
       
        [FindsBy(How = How.XPath, Using = "//span[@class='nI-gNb-sb__placeholder']")]//JobSearch Here
        private IWebElement SearchJobsHere2;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter keyword / designation / companies']")]//Enter Keyword
        private IWebElement EnterKeyword1;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter location']")]//Enter Location
        private IWebElement EnterLocation2;
        [FindsBy(How = How.XPath, Using = "//button[@class='nI-gNb-sb__icon-wrapper']")]//Click On Search Button
        private IWebElement SearchButton2;

        [FindsBy(How = How.XPath, Using = "//input[@id='usernameField']")]//Naukri Username
        private IWebElement Username;
        [FindsBy(How = How.XPath, Using = "//input[@id='passwordField']")]//Password
        private IWebElement Password;
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Login']")]//Login Button
        private IWebElement Login;




        public HomePage()
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        //1.Basic Job Search
        public void BasicJobSearch2()
        {

            //Search.Clear();
            SearchJobsHere.Click();
            EnterKeyword.SendKeys("Software Tester");
            EnterLocation.SendKeys("Bengaluru");
            SearchButton.Click();

            //return search;

        }
        //2.Advanced Job Search - Filters
        /*public void AdvancedJobSearchMethod1()
        {

            //Search.Clear();
            SearchJobsHere2.Click();
            EnterKeyword1.SendKeys("Software Tester");
            EnterLocation2.SendKeys("Bengaluru");
            SearchButton2.Click();

            //return search;

        }*/
        //6.Company Search and Details Verification
        public void CompanySearchandDetails()
        {

            //Search.Clear();
            SearchJobsHere.Click();
            EnterCompany.SendKeys("TCS");
            EnterLocation.SendKeys("Bengaluru");
            SearchButton.Click();

            //return search;

        }
        //11.Error Handling - Invalid Search Results
        public void ErrorHandling()
        {

            //Search.Clear();
            SearchJobsHere.Click();
            EnterCompany1.SendKeys("hgk");
            EnterLocation1.SendKeys("Bengaluru");
            SearchButton.Click();

            //return search;

        }
        //12.Form Validation - Blank Search
        public void FormValidation()
        {

            //Search.Clear();
            SearchJobsHere1.Click();


            SearchButton1.Click();

            //return search;


        }
        //4.Profile Update - Skill Addition
          public void Skilladdition()
          {
            Username.SendKeys("gurusaivamsi4@gmail.com");
            Password.SendKeys("Vamsi@123");
            Login.Click();


          }
        //3.Job Application Process
       /* public void JobApplication()
        {
            driver.Navigate().GoToUrl("https://www.naukri.com/mnjuser/recommendedjobs");//Recomanded Jobs
            Thread.Sleep(4000);
            // Navigate to the specific job listing page
            driver.Navigate().GoToUrl("https://codeachi.com/jobs");//Navigate Job Url




        }*/



    }
}
