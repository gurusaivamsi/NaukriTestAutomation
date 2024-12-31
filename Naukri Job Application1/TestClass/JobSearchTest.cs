using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
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
    public class JobSearchTest : BaseClass
    {
        [Test]
        //1.Dynamic Element Visibility - Job Search Results
        public void JobSearchTestMethod()
        {
            //Initialize the ChromeDriver
            //IWebDriver driver = new ChromeDriver();

            try
            {
                driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
                //Wait statement
                Thread.Sleep(4000);
                //Enter Desgination
                driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Bengaluru");
                Thread.Sleep(4000);
                //Click on search method
                driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
                Thread.Sleep(9000);
                // Navigate to the job application website
                //driver.Navigate().GoToUrl("https://www.naukri.com");

                // Perform job search with specific criteria
                /*IWebElement searchBox = driver.FindElement(By.Id("qsb-keyword-sugg"));
                searchBox.SendKeys("Software Engineer");

                IWebElement locationBox = driver.FindElement(By.Id("qsb-location-sugg"));
                locationBox.SendKeys("Bangalore");

                IWebElement searchButton = driver.FindElement(By.CssSelector("button[title='Search']"));
                searchButton.Click();*/

                // Wait for the search results to load and become visible
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".list")));

                // Verify that expected job listings are displayed
                var jobListings = driver.FindElements(By.CssSelector(".list li"));
                foreach (var job in jobListings)
                {
                    Console.WriteLine(job.Text);
                    // Add your verification logic here, e.g., checking for specific job titles or companies
                }
            }



            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);

            }
            finally
            {
                //Close the current window
                //driver.Close();
                // Clean up
                //Close the Associate Window
                driver.Quit();
                


            }


        }

    }
}


