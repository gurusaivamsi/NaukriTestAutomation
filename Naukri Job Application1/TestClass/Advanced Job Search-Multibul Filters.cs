using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OpenQA.Selenium.DevTools.V123.Debugger;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class Advanced_Job_Search_Multiple_Filters : BaseClass
    {
        //8.Advanced Job Search - Multiple Filters:Positive Scenarios
        [Test]
        public void AdvancedjobsearchmultipleMethod()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();



            //driver.Navigate().GoToUrl("https://www.naukri.com/");

            //https://www.naukri.com/nlogin/login
            //Xpth locators
            //Click on Search Field Here
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);

            //Designation Field
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
            Thread.Sleep(4000);
            //Click on Search Button
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);

            //Click On Salary Check Box 
            IWebElement salary = driver.FindElement(By.XPath("(//*[@title=\"10-15 Lakhs\"])[1]"));
            salary.Click();
            Thread.Sleep(9000);
            //Click on Location Check Box
            IWebElement Location = driver.FindElement(By.XPath("//span[@title='Bengaluru']"));
            Location.Click();
            Thread.Sleep(9000);
            //Click on RoleCategory Check Box
            IWebElement RoleCategory = driver.FindElement(By.XPath("//span[@title='Quality Assurance and Testing']"));
            RoleCategory.Click();
            Thread.Sleep(9000);
            //Move to Slider
            /*IWebElement exp = driver.FindElement(By.XPath("//*[@class=\"rc-slider-track\"]"));
            Actions actions = new Actions(driver);
            actions.DragAndDropToOffset(exp, 17, 0).Build().Perform();*/
            //Click on Company Type Check Box
            IWebElement CompanyType = driver.FindElement(By.XPath("//span[@title='Indian MNC']"));
            CompanyType.Click();
            Thread.Sleep(4000);
            //Move to Slider Experience 
            IWebElement var = driver.FindElement(By.XPath("//*[@class=\"styles_appliedTxt__UmIjs\"]"));
            var.Click();
            Thread.Sleep(4000);
            //Display The Title Name
            Console.WriteLine(driver.Title);
            Thread.Sleep(9000);
            IWebElement appliedfilters = driver.FindElement(By.XPath("//*[@id=\"applied-filters\"]//p"));
            appliedfilters.Click();
            //Close The current Window And Assosiate Window
            driver.Quit();





            /*ReadOnlyCollection<IWebElement> obj = driver.FindElements(By.XPath("//*[@id=\"applied-filters\"]//p"));
            List<string> appliedFiltersviewedonScreen = ConverttoList(obj);
            List<string> appliedFilters = new List<string>()
            { "10-15 Lakhs", "IT Services & Consulting", "17 Yrs" };

            ClassicAssert.AreEqual(appliedFilters, appliedFiltersviewedonScreen);
            Thread.Sleep(10000);*/
        }

    }
}