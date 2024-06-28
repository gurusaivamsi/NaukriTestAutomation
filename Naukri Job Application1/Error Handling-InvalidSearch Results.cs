using Naukri_Job_Application1.Utility;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukri_Job_Application1
{
    [TestFixture]
    public class ErrorHandling_InvalidSearchResults : BaseClass
    {
        //11.Error Handling - Invalid Search Results
        [Test]
        public void ErrorHandlingMethod()
        {
            //Intialize the IwebDriver
            //IWebDriver driver = new ChromeDriver();
            //launch an application
            //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            //driver.Manage().Window.Maximize();

            //Xpth locators
            //click on job search here
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);
            //search for a non-existent job title
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("hgk");
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
            //Thread.Sleep(6000);
            //Location
            driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("chittor");
            Thread.Sleep(4000);
            //Click on search button
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            //display the page title
            Console.WriteLine(driver.Title);
            //Close the current window and assosiated window
            driver.Quit();

        }

    }
}
