using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;
using Naukri_Job_Application1.BaseClasses;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class EmailSubscription_JobAlerts : BaseClass
    {
        //5.Email Subscription - Job Alerts
        [Test]

        public void EmailSubscriptionMethod()

        {
            try
            {
                //Intialize the IwebDriver
                //IWebDriver driver = new ChromeDriver();
                //launch an application
                //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
                //Maximize the Window
                //driver.Manage().Window.Maximize();

                //Xpth locators
                //Click on search jobs here
                driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
                //Wait statement
                Thread.Sleep(4000);
                //Enter Desgination
                driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software test");
                Thread.Sleep(4000);

                //Enter the location
                driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Bengaluru");
                Thread.Sleep(4000);
                //click on search button
                driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
                Thread.Sleep(9000);
                //click on send me job like these link
                driver.FindElement(By.LinkText("Send me jobs like these")).Click();
                Thread.Sleep(9000);
                //Enter the alert name
                driver.FindElement(By.XPath("//input[@placeholder='Enter alert name']")).SendKeys("software testing jobs Bengaluru");
                Thread.Sleep(4000);
                //Enter the active email id
                driver.FindElement(By.XPath("//input[@placeholder='Enter your active Email ID']")).SendKeys("gurusaivamsi4@gmail.com");
                Thread.Sleep(4000);
                //Click on save button
                driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();
                Thread.Sleep(4000);
                Console.WriteLine("Verify successful subscription and confirmation message..");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Verify successful subscription and confirmation message. Failed.: {ex.Message}");
                throw;
            }
            //display the title Name
            //Console.WriteLine(driver.Title);
            Thread.Sleep(6000);
            //close the current window and assosiated window
            driver.Quit();
        }
    }
}
