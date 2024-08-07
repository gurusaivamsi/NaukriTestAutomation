﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Flipkart.BaseClasses;
using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace Naukri_Job_Application1.POM
{
    [TestFixture]
    public class CompanySearchPage : BaseClass
    {
        [FindsBy(How = How.XPath, Using = "//span[@class='nI-gNb-sb__placeholder']")]
        private IWebElement SearchJobsHere;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter keyword / designation / companies']")]
        private IWebElement EnterCompany;
        //[FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter location']")]
        //private IWebElement EnterLocation;
        [FindsBy(How = How.XPath, Using = "//button[@class='nI-gNb-sb__icon-wrapper']")]
        private IWebElement SearchButton;


        public CompanySearchPage()
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

       
        public void CompanySearch()
        {

            //Search.Clear();
            SearchJobsHere.Click();
            EnterCompany.SendKeys("TCS");
            //EnterLocation.SendKeys("Bengaluru");
            SearchButton.Click();

            //return search;

        }
    }

}
