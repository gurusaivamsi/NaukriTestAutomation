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
    public class Salaryinsightsection : LoginClass

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

            // Wait for the page to load
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            String areSalaryInsightsDisplayed = "SalaryInsightsDisplayed";
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);
            //Enter Desgination
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Hyderabad");
            //Thread.Sleep(4000);
            //Click on search method
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("/html/body/div/div/main/div[1]/div[2]/div[2]/div/div[1]/div")).Click();
            Thread.Sleep(5000);
            //Window Handiles
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            Thread.Sleep(5000);
            //Scroll Up And Scroll Down
            Actions actions = new Actions(driver);
            actions.ScrollByAmount(0, 1000).Perform();
            Thread.Sleep(9000);
            //Wait for the salary insights results to load
            //wait.Until(d => d.FindElement(By.CssSelector("div.salaryResultsContainer")));
            //Verify that salary insights are displayed
            bool SalaryInsightsDisplayed = driver.FindElements(By.CssSelector(".styles_sic__avg-salary__KDnuT")).Count > 0;
            //bool SalaryInsightsDisplayed = driver.FindElements(By.CssSelector(".styles_salary - insights - container__gWIDg")).Count > 0;
            bool SalaryInsightDisplayed = driver.PageSource.Contains(areSalaryInsightsDisplayed);

            if (SalaryInsightDisplayed)
            {
                Console.WriteLine(areSalaryInsightsDisplayed + "Salary insights displayed successfully.");
            }
            else
            {
                Console.WriteLine(areSalaryInsightsDisplayed + "Salary insights are not displayed.");
            }

            // Close the browser
            driver.Quit();




        }
    }
}
