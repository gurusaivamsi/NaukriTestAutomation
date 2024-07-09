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
    public class Basicjobsearch1 : BaseClass
    {
        //1.Basic Job Search
        //[Test]
        public void BasicobSearchMethod1()
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
                //Click on Search Field Here
                IWebElement Clickonsearch = driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']"));
                Clickonsearch.Click();
                //Wait statement
                Thread.Sleep(4000);
                //Enter the Keyword field
                IWebElement Designation = driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']"));
                Designation.SendKeys("software tester");
                Thread.Sleep(4000);

                //Enter the Location Field
                IWebElement Location = driver.FindElement(By.XPath("//input[@placeholder='Enter location']"));
                Location.SendKeys("Bengaluru");
                Thread.Sleep(4000);
                //Click On Search Button
                IWebElement SearchButton = driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']"));
                SearchButton.Click();
                Thread.Sleep(9000);

                Console.WriteLine("Verify the search results are relevant and displayed correctly.");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Verify the search results are relevant and displayed Failed.: {ex.Message}");
                throw;
            }
            //Display The Title name
            Console.WriteLine(driver.Title);
            //Current Window and Assosiated Window
            Thread.Sleep(6000);
            driver.Quit();






        }

    }
}
