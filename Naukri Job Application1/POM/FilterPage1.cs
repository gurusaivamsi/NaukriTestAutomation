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
    [TestFixture]
    public class FilterPage1 : Class1
    {
        [FindsBy(How = How.XPath, Using = "//*[@title=\"10-15 Lakhs\"])[1]")]
        private IWebElement Salary;

        [FindsBy(How = How.XPath, Using = "//*[@title=\"IT Services & Consulting\"]")]
        private IWebElement Industry;

        [FindsBy(How = How.XPath, Using = "//*[@class=\"rc-slider-track\"]")]
        private IWebElement exp;

        [FindsBy(How = How.XPath, Using = "//*[@class=\"styles_appliedTxt__UmIjs\"]")]
        private IWebElement var;

        [FindsBy(How = How.XPath, Using = "//div[@class='styles_filter-wrapper-component__4OBpS']")]
        private IWebElement allfilters;

        public FilterPage1()
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        [Test]
        public void AdvancedJobSearchMethod2()
        {
            Salary.Click();
            Industry.Click();
            Actions actions = new Actions(driver);
            actions.DragAndDropToOffset(exp, 17, 0).Build().Perform();
            var.Click();
            allfilters.Click();
            //return search;

        }





        public string AssetResult()
        {

              return allfilters.Text;
                




        }

       
    }
}

