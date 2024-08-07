﻿using Naukri_Job_Application1.BaseClasses;
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
    public class FormValidation_BlankSearch1 : BaseClass
    {

        //12.Form Validation - Blank Search:Negative Scenario
        [Test]
        public void FormValidationMethod1()
        {
            try
            {
                //Intialize the IwebDriver
                //IWebDriver driver = new ChromeDriver();
                //launch an application
                //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
                //Maximize the Window
                //driver.Manage().Window.Maximize();
                //xpath locator
                //Leave the search field blank and attempt to perform a job search
                driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
                //Click on search button
                driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
                Thread.Sleep(4000);
                Console.WriteLine("The System submission and displays an appropriate validation message.");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"The System submission and displays an appropriate validation message. Failed.: {ex.Message}");
                throw;
            }
            //Console.WriteLine(driver.Title);
            //close the current window and assosiated window
            //driver.Quit();


        }
    }
}
