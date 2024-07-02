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
    public class Salary_Insights_Search_by_Job_Title : LoginClass

    {
        [Test]
        //7.Salary Insights - Search by Job Title
        public void SalaryInsightMethod()
        {

            //IWebDriver driver = new ChromeDriver();


            // Navigate to Naukri job application website
            //driver.Navigate().GoToUrl("https://www.naukri.com/");

            // Maximize the browser window
            //driver.Manage().Window.Maximize();

            // Assuming we need to log in before accessing salary insights
            // Log in steps here (if required)

            // Navigate to the salary insights section
            // Assuming the URL or navigation steps are known
            //driver.Navigate().GoToUrl("https://www.ambitionbox.com/salaries?campaign=desktop_nav");

            // Wait for the page to load

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            String areSalaryInsightsDisplayed = "SalaryInsightsDisplayed";
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);
            //Enter Desgination
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Hyderabad");
            Thread.Sleep(4000);
            //Click on search method
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//a[normalize-space()='Software Engineer - Test']")).Click();
            Thread.Sleep(9000);
            //driver.FindElement(By.XPath("//section[@class='styles_salary-insights-container__gWIDg']")).Click();
            //Thread.Sleep(9000);
            


            // Wait for the salary insights results to load
            //wait.Until(d => d.FindElement(By.CssSelector("div.salaryResultsContainer")));

            // Verify that salary insights are displayed
            //bool areSalaryInsightsDisplayed = driver.FindElements(By.CssSelector("div.salaryResult")).Count > 0;
            bool SalaryInsight = driver.PageSource.Contains(areSalaryInsightsDisplayed);

            if (SalaryInsight)
            {
                Console.WriteLine(areSalaryInsightsDisplayed + "Salary insights displayed successfully.");
            }
            else
            {
                Console.WriteLine(areSalaryInsightsDisplayed + "Salary insights are not displayed.");
            }


            //driver.FindElement(By.XPath("//input[@id='fixed-typeahead']")).SendKeys("Automation tester");
            //Thread.Sleep(4000);

            //driver.FindElement(By.XPath("//button[@class='ab_btn search-btn round component-search-btn']")).Click();
            //Thread.Sleep(9000);


            //driver.FindElement(By.XPath("//input[@id='jobProfileSearchbox']")).SendKeys("Software Tester");
            //driver.FindElement(By.XPath("//span[normalize-space()='Software Engineer']")).Click();
            //string ChildWindowName = driver.WindowHandles[1];
            //driver.SwitchTo().Window(ChildWindowName);

            //Click on job listing page
            //driver.FindElement(By.XPath("//div[@class='styles_jlc__main__VdwtF']//div[1]//div[1]//div[1]//a[1]")).Click();
            //Thread.Sleep(4000);
            // Close the browser
            driver.Quit();




        }
    }
}


