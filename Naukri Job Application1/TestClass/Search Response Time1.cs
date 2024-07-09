using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class Search_Response_Time : BaseClass
    {
        [Test]
        //10.Performance Testing - Search Response Time:Positive Scenarios
        public void SearchResponseTimeMethod()
        {


            // List of search keywords and locations
            var searches = new List<Tuple<string, string>>()
                {
                     new Tuple<string, string>("Software Developer", "Bangalore"),
                     new Tuple<string, string>("Data Scientist", "Mumbai"),
                     new Tuple<string, string>("Project Manager", "Delhi")
                };

            // Measure response times under normal load
            Console.WriteLine("Measuring response times under normal load...");
            MeasureResponseTimes(searches);

            // Simulate peak load by running multiple instances in parallel
            Console.WriteLine("Measuring response times under peak load...");
            Parallel.For(0, 5, i =>
            {
                MeasureResponseTimes(searches);
            });


            static void MeasureResponseTimes(List<Tuple<string, string>> searches)
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

                foreach (var search in searches)
                {
                    string keyword = search.Item1;
                    string location = search.Item2;
                    MeasureResponseTime(driver, keyword, location);
                }

                driver.Quit();
            }

            static void MeasureResponseTime(IWebDriver driver, string keyword, string location)
            {
                try
                {
                    // Navigate to Naukri
                    //driver.Navigate().GoToUrl("https://www.naukri.com");

                    // Validate page title
                    string expectedTitle = "Jobs - Recruitment - Job Search - Employment - Job Vacancies - Naukri.com";
                    if (driver.Title != expectedTitle)
                    {
                        Console.WriteLine($"Assertion Failed: Expected title: {expectedTitle}, but got: {driver.Title}");
                        return;
                    }

                    // Find search input fields
                    IWebElement keywordField = driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']"));
                    IWebElement locationField = driver.FindElement(By.XPath("//input[@placeholder='Enter location']"));

                    // Validate input fields presence
                    if (keywordField == null || locationField == null)
                    {
                        Console.WriteLine("Assertion Failed: One or both input fields are missing.");
                        return;
                    }

                    // Enter search criteria
                    keywordField.Clear();
                    keywordField.SendKeys(keyword);
                    locationField.Clear();
                    locationField.SendKeys(location);

                    // Start the stopwatch
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    // Perform search
                    IWebElement searchButton = driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']"));
                    searchButton.Click();

                    // Wait for the results to load
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    bool isResultsLoaded = wait.Until(d => d.FindElement(By.CssSelector(".list")) != null);

                    // Validate results loaded
                    if (!isResultsLoaded)
                    {
                        Console.WriteLine($"Assertion Failed: Search results did not load for '{keyword}' in '{location}'.");
                        return;
                    }

                    // Stop the stopwatch
                    stopwatch.Stop();

                    // Get response time
                    long responseTime = stopwatch.ElapsedMilliseconds;

                    // Print response time to console
                    Console.WriteLine($"Search for '{keyword}' in '{location}' took {responseTime} ms");

                    // Validate response time meets performance criteria
                    long acceptableResponseTime = 2000; // Example acceptable response time in milliseconds
                    if (responseTime > acceptableResponseTime)
                    {
                        Console.WriteLine($"Assertion Failed: Response time {responseTime} ms exceeds acceptable limit of {acceptableResponseTime} ms.");
                    }
                    else
                    {
                        Console.WriteLine($"Assertion Passed: Response time {responseTime} ms is within acceptable limit.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception occurred: {ex.Message}");
                }
            }
        }

    }
}


