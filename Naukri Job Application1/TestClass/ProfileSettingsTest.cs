using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Threading.Tasks;
using System.Numerics;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;


namespace Naukri_Job_Application1.TestClass
{
    public class ProfileSettingsTest : LoginClass 
    {
        [Test]
        public void PageLoadCompletion()
        {
            // Initialize the ChromeDriver
            //IWebDriver driver = new ChromeDriver();

            try
            {

                //driver.Navigate().GoToUrl("https://www.naukri.com/mnjuser/profile");
                //Click on Complete Profile Button
                driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[2]/a[1]")).Click();
                Thread.Sleep(9000);
                
               
                //Verify that all required elements are present
                bool areElementsPresent = driver.FindElement(By.ClassName("Key skills")).Displayed &&
                                          driver.FindElement(By.Name("Mobile")).Displayed;

                if (areElementsPresent)
                {
                    Console.WriteLine("All required elements are present.");
                }
                else
                {
                    Console.WriteLine("Required elements are missing.");
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
    

