using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class NaukriProfileSettingsTest : LoginClass
    {
        //3.Page Load Completion - Profile Settings
        [Test]
        public void Profilesettingset()

        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[2]/a[1]")).Click();
            Thread.Sleep(9000);

            

            // Verify that the required elements are present
            bool isKeySkillsPresent = driver.FindElements(By.XPath("//*[@id=\"root\"]/div/div/span/div/div/div/div/div/div[2]/div[1]/div/div/ul/li[4]")).Count > 0;
            bool isContactDetailsPresent = driver.FindElements(By.XPath("//span[@title='9703652659']")).Count > 0;
            Thread.Sleep(9000);

            if (isKeySkillsPresent && isContactDetailsPresent)
            {
                Console.WriteLine("Profile settings page loaded successfully and all required elements are present.");
            }
            else
            {
                Console.WriteLine("Profile settings page did not load correctly or some required elements are missing.");
            }

            // Close the browser
            driver.Quit();
        }
    }
}




