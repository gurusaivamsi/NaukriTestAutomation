using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Diagnostics;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using Naukri_Job_Application1.BaseClasses;
using BasePageObjectModel;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class PerformanceTesting : BaseClass
    {
        [Test]
        //1.Dynamic Element Visibility - Job Search Results
        public void PerformanceTestingMethod()
        {
    
            // Set up the Chrome driver
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
           

            try
            {
                // Find the search input fields
                //IWebElement Searchjobshere = driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']"));
                //Wait statement
                //Thread.Sleep(4000);
                //Stopwatch stopwatch1 = new Stopwatch();
                //stopwatch1.Start();
                // Perform the search
                //Searchjobshere.Click();
                //Enter Desgination
                /*IWebElement keywordField = driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']"));
                //keywordField.SendKeys("software tester");
                Thread.Sleep(4000);
                IWebElement locationField = driver.FindElement(By.XPath("//input[@placeholder='Enter location']"));
                //locationField.SendKeys("Bengaluru");
                Thread.Sleep(4000);
                //Click on search method
                IWebElement searchButton = driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']"));
                Thread.Sleep(9000);*/
                // List of keywords and locations for the search
                List<(string keyword, string location)> searchParameters = new List<(string, string)>
                {
                    ("Software Engineer", "Bangalore"),
                    ("Data Scientist", "Hyderabad"),
                    ("Project Manager", "Mumbai"),
                    ("DevOps Engineer", "Chennai"),
                    ("QA Tester", "Pune")
                };

                foreach (var searchParam in searchParameters)
                {
                    // Navigate to the Naukri home page
                    //driver.Navigate().GoToUrl("https://www.naukri.com/");

                    // Find the search input fields
                    /*IWebElement searchbutton = driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']"));
                    //Wait statement
                    Thread.Sleep(4000);
                    Stopwatch stopwatch1 = new Stopwatch();
                    stopwatch1.Start();
                    // Perform the search
                    searchbutton.Click();*/
                    //Enter Desgination
                    IWebElement keywordField = driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']"));
                    //keywordField.SendKeys("software tester");
                    Thread.Sleep(4000);
                    IWebElement locationField = driver.FindElement(By.XPath("//input[@placeholder='Enter location']"));
                    //locationField.SendKeys("Bengaluru");
                    Thread.Sleep(4000);
                    //Click on search method
                    IWebElement searchButton = driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']"));
                    Thread.Sleep(9000);
                    //IWebElement keywordField = driver.FindElement(By.Id("qsb-keyword-sugg"));
                    //IWebElement locationField = driver.FindElement(By.Id("qsb-location-sugg"));
                    //IWebElement searchButton = driver.FindElement(By.XPath("//button[contains(text(),'Search')]"));
                    // Start the stopwatch to measure response time
                   
                    // Clear the fields and enter search parameters
                    keywordField.Clear();
                    keywordField.SendKeys(searchParam.keyword);
                    locationField.Clear();
                    locationField.SendKeys(searchParam.location);

                    // Start the stopwatch to measure response time
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    // Perform the search
                    searchButton.Click();

                    // Wait for the search results to load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class,'list') and contains(@class,'jobTuple')]")));

                    // Stop the stopwatch
                    stopwatch.Stop();

                    // Output the response time
                    Console.WriteLine($"Search for '{searchParam.keyword}' in '{searchParam.location}' took {stopwatch.ElapsedMilliseconds} ms.");
                }
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Test Failed: Element not found - " + ex.Message);
            }
            finally
            {
                // Close the browser
                driver.Quit();
            }
        }
    }
}

