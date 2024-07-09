using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Naukri_Job_Application1.BaseClasses
{
    public class BaseClass1dummy
    {
#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        public WebDriver driver;
#pragma warning restore NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method

        [OneTimeSetUp]
        public void Open()
        {
            //Intialize the IwebDriver
            driver = new ChromeDriver();
            //launch an application
            driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //driver.Navigate().GoToUrl("https://www.naukri.com/");
            Thread.Sleep(1000);
            //Maximize the Window
            driver.Manage().Window.Maximize();



            //Intialize the IwebDriver
            /*driver = new FirefoxDriver();
            //Launch an application
            driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            Thread.Sleep(1000);
            //Maximize the Window
            driver.Manage().Window.Maximize();*/


        }
    }
}