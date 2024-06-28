using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class Job_Alerts_Management_Edit_Preferences : BaseClass
    {

        //9.Job Alerts Management - Edit Preferences
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
            //ente the email
            driver.FindElement(By.XPath("//input[@id='usernameField']")).SendKeys("gurusaivamsi4@gmail.com");
            Thread.Sleep(4000);
            //enter the password 
            driver.FindElement(By.XPath("//input[@id='passwordField']")).SendKeys("Vamsi@123");
            Thread.Sleep(4000);
            //cick on save button
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
            Thread.Sleep(9000);
            //navigate to job site
            driver.Navigate().GoToUrl("https://www.naukri.com/alert/manage");
            Thread.Sleep(9000);
            //click on modify alert
            driver.FindElement(By.XPath("//tbody/tr[4]/td[4]/a[1]")).Click();
            Thread.Sleep(9000);
            //driver.FindElement(By.XPath("//*[@id=\"block\"]")).Click();
            //Thread.Sleep(9000);
            //driver.FindElement(By.XPath("//*[@id=\"allow\"]")).Click();
            //Thread.Sleep(9000);
            //IAlert a = driver.SwitchTo().Alert();
            //driver.SwitchTo().Alert().Dismiss();
            //Console.WriteLine(a.GetType());
            //a.Dismiss();
            IAlert simpleAlert = driver.SwitchTo().Alert();
            String alertText = simpleAlert.Text;
            Console.WriteLine("Alert text is " + alertText);
            simpleAlert.Accept();
            Console.WriteLine("confirmation alert completed");

            //update the job title
            driver.FindElement(By.XPath("//div[@id='kwdsugg']//div[@class='inpWrap']")).SendKeys("QA");
            Thread.Sleep(4000);
            //update the location
            driver.FindElement(By.XPath("//div[@id='locsugg']//div[@class='inpWrap']")).SendKeys("Hyderabad");
            Thread.Sleep(4000);
            //click on the update button
            driver.FindElement(By.XPath("//button[@id='cjaSubmit']")).Click();
            Thread.Sleep(9000);
            //close the current window assosiated window
            driver.Quit();


        }
    }
}
