using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Naukri_Job_Application1.BaseClasses;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class Asynchronous_Operations : BaseClass
    {
        [Test]
        //4.Asynchronous Operations - Job Application Confirmation
        public void JobApplicationConfirmation()
        {
            // Initialize the Chrome driver
            //IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.naukri.com/mnjuser/recommendedjobs");
            Thread.Sleep(4000);

            //Implicit wait method
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            try
            {
                // Navigate to the job listing page
                driver.Navigate().GoToUrl("https://codeachi.com/jobs"); // Update with the actual job listing URL
                driver.FindElement(By.XPath("//button[normalize-space()='Accept']")).Click();//Accept Button
                Thread.Sleep(4000);
                // Maximize the browser window
                //driver.Manage().Window.Maximize();
                // Wait for the "Apply Now" button to become clickable
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement applyNowButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"root\"]/div[5]/div[1]/div[2]/div[2]/div[2]/div[2]/a"))); // Update XPath as necessary

                //Click on the "Apply Now" button
                applyNowButton.Click();
                IWebElement nameField = driver.FindElement(By.XPath("//input[@placeholder='Your Name']"));//Enter Name
                nameField.SendKeys("John Doe");
                Thread.Sleep(4000);

                IWebElement emailField = driver.FindElement(By.XPath("//input[@placeholder='Your Email']"));//Enter Email
                emailField.SendKeys("john.doe@example.com");
                Thread.Sleep(4000);

                driver.FindElement(By.XPath("//input[@placeholder='State']")).SendKeys("ap");//Enter State
                Thread.Sleep(4000);

                driver.FindElement(By.XPath("//input[@placeholder='1 (702) 123-4567']")).SendKeys("98765-43210");//Enter Mobile Number
                Thread.Sleep(4000);




                driver.FindElement(By.XPath("//input[@placeholder='City']")).SendKeys("hyderabad");//enter City

                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//input[@placeholder='Applying Job Post']")).SendKeys("naukri");//Applying Job Post
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//input[@placeholder='Expected Salary Per Month (in INR)']")).SendKeys("60,000");//Expected Salary
                Thread.Sleep(4000);

                driver.FindElement(By.XPath("//textarea[@placeholder='Message']")).SendKeys("job");//Message
                Thread.Sleep(4000);

                IWebElement resumeUpload = driver.FindElement(By.XPath("//input[@title=' Upload resume']"));//Upload Resume
                resumeUpload.SendKeys("C:/Users/ADMIN/Downloads/freshers-resume.pdf");
                Thread.Sleep(9000);


                IWebElement photoUpload = driver.FindElement(By.XPath("//input[@title=' Upload Photo']"));//Upload Photo
                photoUpload.SendKeys("C:\\Users\\ADMIN\\Downloads\\images3.png");
                Thread.Sleep(9000);

                IWebElement Checkbox = driver.FindElement(By.XPath("//input[@id='exampleCheck1']"));//Click On Check box
                Checkbox.Click();
                Thread.Sleep(6000);

                // Submit the application form
                IWebElement submitApplicationButton = driver.FindElement(By.XPath("//button[normalize-space()='Submit Application']"));//Submit Application
                submitApplicationButton.Click();
                Thread.Sleep(15000);


                // Wait for the application confirmation message to appear
                IWebElement confirmationMessage = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[contains(@class, 'confirmation-message')]"))); // Update XPath as necessary

                // Verify that the confirmation message matches the expected outcome
                string expectedMessage = "Your application has been submitted successfully."; // Update with the actual expected message
                if (confirmationMessage.Text.Contains(expectedMessage))
                {
                    Console.WriteLine("Test Passed: Confirmation message is correct.");
                }
                else
                {
                    Console.WriteLine("Test Failed: Confirmation message is incorrect.");
                }
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Element not found: " + e.Message);
            }
            catch (WebDriverTimeoutException e)
            {
                Console.WriteLine("Element not clickable or visible within the timeout period: " + e.Message);
            }
            finally
            {
                // Close the browser
                driver.Quit();
            }
        }
    }
}