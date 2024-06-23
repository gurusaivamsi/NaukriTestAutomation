using Naukri_Job_Application1.Utility;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Naukri_Job_Application1
{
    [TestFixture]
    public class FormValidation_BlankSearch : BaseClass 
    {

        //12.Form Validation - Blank Search:Negative Scenario
        [Test]
        public void  FormValidationMethod()
        {
            //Intialize the IwebDriver
            //IWebDriver driver = new ChromeDriver();
            //launch an application
            //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            //driver.Manage().Window.Maximize();
            //xpath locator
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(4000);
            //Console.WriteLine(driver.Title);
            driver.Quit();


        }
    }
}
