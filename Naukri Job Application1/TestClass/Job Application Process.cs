using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class Job_Application_Process : LoginClass
    {
        //3.Job Application Process
        [Test]
        public void JobapplicationProcessMethod()
        {
            // Initialize the ChromeDriver
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.naukri.com/mnjuser/recommendedjobs");//Recomanded Jobs
            Thread.Sleep(4000);


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);//Wait Method

            try
            {
                // Navigate to the specific job listing page
                driver.Navigate().GoToUrl("https://codeachi.com/jobs");//Navigate Job Url
                Thread.Sleep(4000);//Wait

                driver.FindElement(By.XPath("//button[normalize-space()='Accept']")).Click();//Click On Accept Popup
                Thread.Sleep(4000);

                driver.FindElement(By.XPath("//*[@id=\"root\"]/div[5]/div[1]/div[2]/div[2]/div[2]/div[2]/a"));//Apply Button
                Thread.Sleep(4000);
                IWebElement nameField = driver.FindElement(By.XPath("//input[@placeholder='Your Name']"));//Enter Name
                nameField.SendKeys("John Doe");
                Thread.Sleep(4000);

                IWebElement emailField = driver.FindElement(By.XPath("//input[@placeholder='Your Email']"));//Enter Email Id
                emailField.SendKeys("john.doe@example.com");
                Thread.Sleep(4000);

                driver.FindElement(By.XPath("//input[@placeholder='State']")).SendKeys("ap");//Enter State
                Thread.Sleep(4000);

                driver.FindElement(By.XPath("//input[@placeholder='1 (702) 123-4567']")).SendKeys("98765-43210");//Enter Mobile Number
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//input[@placeholder='City']")).SendKeys("hyderabad");//Enter The City
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//input[@placeholder='Applying Job Post']")).SendKeys("naukri");//Enter the Apply Job Post
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//input[@placeholder='Expected Salary Per Month (in INR)']")).SendKeys("60,000");//Expected Salary
                Thread.Sleep(4000);

                driver.FindElement(By.XPath("//textarea[@placeholder='Message']")).SendKeys("job");//Message
                Thread.Sleep(4000);

                

                IWebElement resumeUpload = driver.FindElement(By.XPath("//input[@title=' Upload resume']"));//Upload The Resume
                resumeUpload.SendKeys("C:/Users/ADMIN/Downloads/freshers-resume.pdf");
                Thread.Sleep(9000);


                IWebElement photoUpload = driver.FindElement(By.XPath("//input[@title=' Upload Photo']"));//Upload The Photo
                photoUpload.SendKeys("C:\\Users\\ADMIN\\Downloads\\images3.png");
                Thread.Sleep(9000);

                IWebElement Checkbox = driver.FindElement(By.XPath("//input[@id='exampleCheck1']"));//Click On Check Box
                Checkbox.Click();
                Thread.Sleep(6000);

                // Submit the application form
                IWebElement submitApplicationButton = driver.FindElement(By.XPath("//button[normalize-space()='Submit Application']"));//Click Oon Submit Button
                submitApplicationButton.Click();
                Thread.Sleep(15000);

                // Verify successful submission or error messages for invalid inputs
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => d.FindElement(By.Id("success-message")));

                IWebElement successMessage = driver.FindElement(By.Id("success-message"));
                if (successMessage.Displayed)
                {
                    Console.WriteLine("Application submitted successfully!");
                }
                else
                {
                    Console.WriteLine("Application submission failed.");
                }
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Element not found: " + ex.Message);
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



