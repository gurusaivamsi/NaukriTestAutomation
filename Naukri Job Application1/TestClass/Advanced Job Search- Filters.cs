using Naukri_Job_Application1.BaseClasses;
using NUnit.Framework.Legacy;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
      public class AdvancedJobSearch_Filters : BaseClass
      {
        //2.Advanced Job Search - Filters
        [Test]
        public void AdvancedJobSearchMethod()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();



            //driver.Navigate().GoToUrl("https://www.naukri.com/");

            //https://www.naukri.com/nlogin/login
            //Click on Search Field Here 
            //Xpth locators
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);

            //Enter the Job title Field
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
            Thread.Sleep(4000);

            //driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Bengaluru");
            //Thread.Sleep(4000);
            //Click on Search Button
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);

            //Move to Slider Experience 
            //IWebElement var = driver.FindElement(By.XPath("//*[@class=\"styles_appliedTxt__UmIjs\"]"));
            //var.Click();
            //Thread.Sleep(4000);
            //Click on Salary Check Box
            IWebElement salary = driver.FindElement(By.XPath("(//*[@title=\"10-15 Lakhs\"])[1]"));
            salary.Click();
            Thread.Sleep(9000);
            //Click on Industry Check Box
            IWebElement industry = driver.FindElement(By.XPath("//*[@title=\"IT Services & Consulting\"]"));
            industry.Click();
            Thread.Sleep(9000);
            //Move to Slider
            IWebElement exp = driver.FindElement(By.XPath("//*[@class=\"rc-slider-track\"]"));
            Actions actions = new Actions(driver);
            actions.DragAndDropToOffset(exp, 17, 0).Build().Perform();
            //Move to Slider Experience 
            IWebElement var = driver.FindElement(By.XPath("//*[@class=\"styles_appliedTxt__UmIjs\"]"));
            var.Click();
            Thread.Sleep(4000);
            //Dispaly The Title Name
            Console.WriteLine(driver.Title);
            Thread.Sleep(4000);
            //IWebElement appliedfilters = driver.FindElement(By.XPath("//*[@id=\"applied-filters\"]//p"));
            //appliedfilters.Click();
            //Close the Current Window And Assosiated Window
            driver.Quit();





            /*ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.XPath("//*[@id=\"applied-filters\"]//p"));
            List<string> elementTexts = elements.Select(element => element.Text).ToList();

            foreach (string text in elementTexts)
            {
                Console.WriteLine(text);
            }
            Thread.Sleep(4000); */

            /*List<string> appliedFiltersviewedonScreen = ConverttoList(obj);
            List<string> appliedFilters = new List<string>()
            { "10-15 Lakhs", "IT Services & Consulting", "17 Yrs" };

            ClassicAssert.AreEqual(appliedFilters, appliedFiltersviewedonScreen);
            Thread.Sleep(10000);*/
        }
      }
}
