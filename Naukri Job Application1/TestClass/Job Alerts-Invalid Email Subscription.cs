using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class JobAlerts_InvalidEmailSubscription : BaseClass
    {

        //15.Job Alerts - Invalid Email Subscription:Negative Scenarios
        [Test]
        public void JobAlertsMethod()
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
            //enter the job desgination
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
            Thread.Sleep(4000);

            //enter the location
            driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Bengaluru");
            Thread.Sleep(4000);
            //click on nthe search button
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            //click on send me job like these link
            driver.FindElement(By.LinkText("Send me jobs like these")).Click();
            Thread.Sleep(9000);
            //enter the alert name
            driver.FindElement(By.XPath("//input[@placeholder='Enter alert name']")).SendKeys("software tester,bengaluru");
            Thread.Sleep(4000);
            //enter the invalid email id
            driver.FindElement(By.XPath("//input[@placeholder='Enter your active Email ID']")).SendKeys("saivamsi47436gmail.com");
            Thread.Sleep(4000);
            //click on save button
            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();
            Thread.Sleep(4000);
            //display the title page
            //Console.WriteLine(driver.Title);
            //close the current window assosiated window
            Thread.Sleep(4000);
            driver.Quit();
        }
    }
}
