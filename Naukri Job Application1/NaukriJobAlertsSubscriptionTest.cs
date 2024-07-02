using Naukri_Job_Application1.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukri_Job_Application1
{
    [TestFixture]
    public class NaukriJobAlertsSubscriptionTest : LoginClass

    {
        //5.Dynamic Content Update - Job Alerts Subscription
        [Test]
        public void JobAlertsSubscriptionTest()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            String CategoryandLocationAdded = "IT Software - All Jobs and Hyderabad";
            //navigate to job site
            driver.Navigate().GoToUrl("https://www.naukri.com/alert/manage");
            Thread.Sleep(9000);
            //click on modify alert
            driver.FindElement(By.XPath("//tbody/tr[4]/td[4]/a[1]")).Click();
            Thread.Sleep(9000);
            //update the job title
            driver.FindElement(By.XPath("//input[@id='cjaJob']")).SendKeys("IT Software - All Jobs");
            Thread.Sleep(6000);
            //update the location
            driver.FindElement(By.XPath("//input[@id='Sug_locsugg']")).SendKeys("Hyderabad");
            Thread.Sleep(4000);
            //click on the update button
            driver.FindElement(By.XPath("//button[@id='cjaSubmit']")).Click();
            Thread.Sleep(9000);

            // Wait for the dynamic update to complete
             //wait.Until(d => driver.FindElement(By.CssSelector("div.alertMessage")));

            // Verify that the subscribed alerts are updated dynamically without page refresh
            //bool isAlertUpdated = driver.FindElements(By.CssSelector("div.alertMessage.success")).Count > 0;
            bool isAlertUpdated = driver.PageSource.Contains(CategoryandLocationAdded);

            if (isAlertUpdated)
            {
                Console.WriteLine(CategoryandLocationAdded + "Job alerts subscription updated dynamically without page refresh.");
            }
            else
            {
                Console.WriteLine(CategoryandLocationAdded + "Job alerts subscription did not update dynamically.");
            }

            
            //close the current window assosiated window
            driver.Quit();
        }
    }
}
