using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Naukri_Job_Application1.BaseClasses;
using System.Xml.Linq;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class Element_Interactivity_Apply_Now_Button : BaseClass
    {
        [Test]
        public void ApplyNowButtonMethod()
        {
            // Initialize the Chrome driver
            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.naukri.com/mnjuser/recommendedjobs");
            Thread.Sleep(4000);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            try
            {
                // Navigate to the job listing page
                driver.Navigate().GoToUrl("https://codeachi.com/jobs"); // Update with the actual job listing URL
                driver.FindElement(By.XPath("//button[normalize-space()='Accept']")).Click();
                Thread.Sleep(4000);

                // Maximize the browser window
                //driver.Manage().Window.Maximize();

                // Wait for the "Apply Now" button to become clickable
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement applyNowButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[5]/div[1]/div[2]/div[2]/div[2]/div[2]/a"))); // Update XPath as necessary

                // Click on the "Apply Now" button
                applyNowButton.Click();
                Console.WriteLine("Element to be clickable with in the Processed the application Passed");

                // Additional steps to proceed with the application
                // For example, filling out the application form
                // IWebElement element = driver.FindElement(By.Id("elementId"));
                // element.SendKeys("value");

                // Optionally, add further steps for the application process
                // ...
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Element not found: " + e.Message);
            }
            catch (WebDriverTimeoutException e)
            {
                Console.WriteLine("Element not clickable within the timeout period: " + e.Message);
            }
            finally
            {

                Thread.Sleep(6000);
                // Close the browser
                driver.Quit();

            }
        }
    }
}
