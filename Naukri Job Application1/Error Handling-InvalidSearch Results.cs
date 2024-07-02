using Naukri_Job_Application1.Utility;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace Naukri_Job_Application1
{
    [TestFixture]
    public class ErrorHandling_InvalidSearchResults : BaseClass
    {
        //11.Error Handling - Invalid Search Results:Positive Scenarios
        [Test]
        public void ErrorHandlingMethod()
        {
            string jobSearchLocation = "Chittor";

            try
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
                //search for a non-existent job title
                driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("hgk");
                Thread.Sleep(4000);
                //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
                //Thread.Sleep(6000);
                //Location
                driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys(jobSearchLocation);
                Thread.Sleep(4000);
                //Click on search button
                driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
                Thread.Sleep(9000);


                try
                {
                    IWebElement noResultElement = driver.FindElement(By.XPath("//div[contains(text(),'No results found')]"));
                    Console.WriteLine("No Jobs Found and Search results are as expected for " + jobSearchLocation);
                }
                catch (NoSuchElementException)
                {
                    Console.WriteLine("Jobs Found and Search results are not as expected for " + jobSearchLocation + ". So test case failed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("system handles and displays appropriate error messages.Exception.: {ex.Message}");
                throw;
            }
            //display the page title
            //Console.WriteLine(driver.Title);
            //Close the current window and assosiated window
            Thread.Sleep(4000);
            driver.Quit();

        }

    }
}
