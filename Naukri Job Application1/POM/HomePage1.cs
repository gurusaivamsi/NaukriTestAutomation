using System;
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
    public class HomePage1 : Class1
    {
        [FindsBy(How = How.XPath, Using = "//span[@class='nI-gNb-sb__placeholder']")]
        private IWebElement SearchJobsHere;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter keyword / designation / companies']")]
        private IWebElement EnterKeyword;
        //[FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter location']")]
        //private IWebElement EnterLocation;
        [FindsBy(How = How.XPath, Using = "//button[@class='nI-gNb-sb__icon-wrapper']")]
        private IWebElement SearchButton;

        /*[FindsBy(How = How.XPath, Using = "//*[@title=\"10-15 Lakhs\"])[1]")]
        private IWebElement Salary;

        [FindsBy(How = How.XPath, Using = "//*[@title=\"IT Services & Consulting\"]")]
        private IWebElement Industry;

        [FindsBy(How = How.XPath, Using = "//*[@class=\"rc-slider-track\"]")]
        private IWebElement exp;

        [FindsBy(How = How.XPath, Using = "//*[@class=\"styles_appliedTxt__UmIjs\"]")]
        private IWebElement var;*/


        public HomePage1()
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [Test]
        public void AdvancedJobSearchMethod1()
        {

            //Search.Clear();
            SearchJobsHere.Click();
            EnterKeyword.SendKeys("Software Tester");
            //EnterLocation.SendKeys("Bengaluru");
            SearchButton.Click();
        }
           /*[Test]
            public void AdvancedJobSearchMethod2()
            {
              Salary.Click();
              Industry.Click(); 
              Actions actions = new Actions(driver);
               actions.DragAndDropToOffset(exp, 17, 0).Build().Perform();
              var.Click();

              //return search;

            }*/
    }

}
