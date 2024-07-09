using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class Dynamic_Element_Visibility__Job_Search_Results 
    {
        [Test]
        //1.Dynamic Element Visibility-Job Search Results
        public void JobSearchResult()
        {
            // Job search criteria
            string keyword = "Software Developer";
            string location = "Bangaluru";

            // Perform job search and verify results
            PerformJobSearchAndVerifyResults(keyword, location);
        }

        static void PerformJobSearchAndVerifyResults(string keyword, string location)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            try
            {
                // Navigate to Naukri
                driver.Navigate().GoToUrl("https://www.naukri.com");

                // Find search input fields
                IWebElement keywordField = driver.FindElement(By.Name("qp"));
                
                IWebElement locationField = driver.FindElement(By.Name("ql"));
                

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

                // Perform search
                IWebElement searchButton = driver.FindElement(By.XPath("//button[contains(text(), 'Search')]"));
                searchButton.Click();

                // Wait for the results to load
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => d.FindElement(By.CssSelector(".list")) != null);

                // Validate results loaded
                IList<IWebElement> jobListings = driver.FindElements(By.CssSelector(".list .jobTuple"));
                if (jobListings.Count == 0)
                {
                    Console.WriteLine("Assertion Failed: No job listings found.");
                    return;
                }

                // Print number of job listings found
                Console.WriteLine($"Assertion Passed: {jobListings.Count} job listings found.");

                // Verify each job listing is displayed
                foreach (var job in jobListings)
                {
                    if (!job.Displayed)
                    {
                        Console.WriteLine("Assertion Failed: A job listing is not visible.");
                        return;
                    }
                }

                Console.WriteLine("Assertion Passed: All job listings are visible.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
