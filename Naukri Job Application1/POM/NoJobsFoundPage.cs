using Naukri_Job_Application1.BaseClasses;
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
//using Flipkart.BaseClasses;

namespace Naukri_Job_Application1.POM
{
    public class NoJobsFoundPage :BaseClass
    {
        //[FindsBy(How = How.XPath, Using = "//span[@title='1 - 19 of 24036 ']")]
        //private IWebElement Result;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'No results found')]")]
        private IWebElement Result;



        public NoJobsFoundPage()
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);

        }




        public string AssetResult()
        {

            return Result.Text;




        }

    }
}

