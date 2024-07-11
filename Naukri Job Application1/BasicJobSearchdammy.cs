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
    public class BasicJobSearchdammy : BaseClass
    {

        //[SetUp]
        //1.Basic Job Search
        [Test]
        
           
            public void BasicJobSearchMethod()
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
                driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
                Thread.Sleep(4000);
                //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
                //Thread.Sleep(6000);
                //Enter Location
                driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Bengaluru");
                Thread.Sleep(4000);
                //string s1=driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Text;
                //Console.WriteLine(s1);
                //Click on search button
                driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
                Thread.Sleep(9000);
                //Display the Title name
                Console.WriteLine(driver.Title);
                //Close the current window are assosiated window
                driver.Quit();

            }
    }
}
