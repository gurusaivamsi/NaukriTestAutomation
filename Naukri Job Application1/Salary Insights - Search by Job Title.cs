using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Naukri_Job_Application1.Utility;

namespace Naukri_Job_Application1
{
    [TestFixture]
    public class Salary_Insights_Search_by_Job_Title : BaseClass

    {
        [Test]
        public void SalaryInsightMethod()
        {


            //IWebDriver driver = new ChromeDriver();

            try
            {
                // Navigate to Naukri job application website
                //driver.Navigate().GoToUrl("https://www.naukri.com/");

                // Maximize the browser window
                //driver.Manage().Window.Maximize();

                // Assuming we need to log in before accessing salary insights
                // Log in steps here (if required)

                // Navigate to the salary insights section
                // Assuming the URL or navigation steps are known
                driver.Navigate().GoToUrl("https://www.ambitionbox.com/salaries?campaign=desktop_nav");

                // Wait for the page to load
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ab-typeahead")));

                // Search for salary insights by entering a specific job title
                IWebElement jobTitleInput = driver.FindElement(By.ClassName("ab-typeahead"));
                jobTitleInput.SendKeys("Software Tester");
                jobTitleInput.SendKeys(Keys.Enter);

                // Wait for the results to load
                wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("Salaries")));

                // Verify that salary insights are displayed
                IList<IWebElement> salaryInsights = driver.FindElements(By.CssSelector("button[class='ab_btn search-btn round component-search-btn'] span[class='ctas-btn-medium']"));

                if (salaryInsights.Count > 0)
                {
                    Console.WriteLine("Salary insights are displayed successfully.");

                    // Print salary values in console
                    foreach (var insight in salaryInsights)
                    {
                        string jobTitle = insight.FindElement(By.CssSelector(".trend-title")).Text;
                        string avgSalary = insight.FindElement(By.CssSelector(".average-salary")).Text;
                        Console.WriteLine($"Job Title: {jobTitle} - Average Salary: {avgSalary}");
                    }
                }
                else
                {
                    Console.WriteLine("Salary insights are not displayed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the browser
                driver.Quit();



            }
        }
    }

}

