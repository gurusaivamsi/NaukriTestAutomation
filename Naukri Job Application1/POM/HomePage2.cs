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
    public class HomePage2  : BaseClass
    {
        [FindsBy(How = How.XPath, Using = "//span[@class='nI-gNb-sb__placeholder']")]
        private IWebElement SearchJobsHere;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter keyword / designation / companies']")]
        private IWebElement EnterKeyword;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter location']")]
        private IWebElement EnterLocation;
        [FindsBy(How = How.XPath, Using = "//button[@class='nI-gNb-sb__icon-wrapper']")]
        private IWebElement SearchButton;


        public HomePage2()
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [Test]
        public void ErrorHandling ()
        {

            //Search.Clear();
            SearchJobsHere.Click();
            EnterKeyword.SendKeys("hgk");
            EnterLocation.SendKeys("Chittor");
            SearchButton.Click();

            //return search;

        }
    }

}
