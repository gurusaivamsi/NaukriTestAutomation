using Naukri_Job_Application1.Utility;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OpenQA.Selenium.DevTools.V123.Debugger;

namespace Naukri_Job_Application1
{
    [TestFixture]
    public class Advanced_Job_Search_Multiple_Filters : BaseClass
    {
        [Test]
        public void AdvancedjobsearchmultipleMethod()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();



            //driver.Navigate().GoToUrl("https://www.naukri.com/");

            //https://www.naukri.com/nlogin/login
            //Xpth locators
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);

            //IWebElement search = driver.FindElement(By.XPath("//*[@placeholder=\"Enter skills / designations / companies\"]"));
            //search.SendKeys("Software Tester");
            //*[@class="dropdownMainContainer"]


            //IWebElement submit = driver.FindElement(By.XPath("//*[@class=\"qsbSubmit\"]"));
            //submit.Click();

            //Thread.Sleep(9000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
            Thread.Sleep(4000);

            //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
            //Thread.Sleep(6000);

            //driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Bengaluru");
            //Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            IWebElement salary = driver.FindElement(By.XPath("(//*[@title=\"10-15 Lakhs\"])[1]"));
            salary.Click();
            Thread.Sleep(9000);
            IWebElement Location = driver.FindElement(By.XPath("//span[@title='Bengaluru']"));
            Location.Click();
            Thread.Sleep(9000);
            IWebElement RoleCategory = driver.FindElement(By.XPath("//span[@title='Quality Assurance and Testing']"));
            RoleCategory.Click();
            Thread.Sleep(9000);
            IWebElement exp = driver.FindElement(By.XPath("//*[@class=\"rc-slider-track\"]"));
            Actions actions = new Actions(driver);
            actions.DragAndDropToOffset(exp, 17, 0).Build().Perform();

            IWebElement CompanyType = driver.FindElement(By.XPath("//span[@title='Indian MNC']"));
            CompanyType.Click();
            Thread.Sleep(9000);
            driver.Quit();





            /* ReadOnlyCollection<IWebElement> obj = driver.FindElements(By.XPath("//*[@id=\"applied-filters\"]//p"));
             List<string> appliedFiltersviewedonScreen = ConverttoList(obj);
             List<string> appliedFilters = new List<string>()
             { "10-15 Lakhs", "IT Services & Consulting", "17 Yrs" };

             ClassicAssert.AreEqual(appliedFilters, appliedFiltersviewedonScreen);
             Thread.Sleep(10000);*/
        }

    }
}
