using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;
using Naukri_Job_Application1.Utility;

namespace Naukri_Job_Application1
{
    [TestFixture]
    public class EmailSubscription_JobAlerts :BaseClass
    {
        //5.Email Subscription - Job Alerts
        [Test]

        public void EmailSubscriptionMethod()
        {
            //Intialize the IwebDriver
            //IWebDriver driver = new ChromeDriver();
            //launch an application
            //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            //driver.Manage().Window.Maximize();

            //Xpth locators
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
            //Thread.Sleep(6000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Bengaluru");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.LinkText("Send me jobs like these")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter alert name']")).SendKeys("software testers bengaluru");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter your active Email ID']")).SendKeys("gurusaivamsi4@gmail.com");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();
            Thread.Sleep(4000);
            Console.WriteLine(driver.Title);
            driver.Quit();
        }
    }
}
