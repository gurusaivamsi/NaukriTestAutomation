using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

using System.Threading.Tasks;
using System.Numerics;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class Job_Alerts_Management_Edit_Preferences : LoginClass
    {

        //9.Job Alerts Management - Edit Preferences:Positive Scenarios
        [Test]
        public void JobAlertsMethod()
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
                //ente the email
                /*driver.FindElement(By.XPath("//input[@id='usernameField']")).SendKeys("gurusaivamsi4@gmail.com");
                Thread.Sleep(4000);
                //enter the password 
                driver.FindElement(By.XPath("//input[@id='passwordField']")).SendKeys("Vamsi@123");
                Thread.Sleep(4000);
                //cick on save button
                driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
                Thread.Sleep(9000);*/
                //navigate to job site
                driver.Navigate().GoToUrl("https://www.naukri.com/alert/manage");//Alert Manage
                Thread.Sleep(9000);
                //click on modify alert
                driver.FindElement(By.XPath("//tbody/tr[4]/td[4]/a[1]")).Click();//Click On ModiFy Alert
                Thread.Sleep(9000);


                //update the location
                driver.FindElement(By.XPath("//input[@id='Sug_locsugg']")).SendKeys("Bengaluru");
                Thread.Sleep(4000);
                //update the Job Category
                driver.FindElement(By.XPath("//input[@id='cjaJob']")).SendKeys("IT Software - All Jobs");
                Thread.Sleep(6000);

                //click on the update button
                driver.FindElement(By.XPath("//button[@id='cjaSubmit']")).Click();
                Thread.Sleep(9000);
                Console.WriteLine("Verify that changes are successfully applied and reflected in the job alerts..");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"Verify that changes are successfully applied and reflected in the job alerts. Failed.: {ex.Message}");
                throw;
            }

            //Display the title name
            //Console.WriteLine(driver.Title);
            //close the current window assosiated window
            Thread.Sleep(4000);
            driver.Quit();
        }


    }
}
