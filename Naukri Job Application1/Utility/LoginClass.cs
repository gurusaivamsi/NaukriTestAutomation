using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukri_Job_Application1.Utility
{
    public class LoginClass : BaseClass
    {
        [OneTimeSetUp]
        public void Login()
        {    
            //Naukri_Job_Application1 login

            //Email id/username
            driver.FindElement(By.XPath("//input[@id='usernameField']")).SendKeys("gurusaivamsi4@gmail.com");
            //Wait Statement
            Thread.Sleep(4000);
            //Password
            driver.FindElement(By.XPath("//input[@id='passwordField']")).SendKeys("Vamsi@123");
            Thread.Sleep(4000);
            //Login button click
            //Open to the Login Naukri
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
            Thread.Sleep(9000);
        }
    }
}
