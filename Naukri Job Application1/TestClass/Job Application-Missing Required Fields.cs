using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;
using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium.Interactions;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class Job_Application_Missing_Required_Fields : LoginClass
    {
        //13.Job Application - Missing Required Fields:Negative Scenarios
        [Test]
        public void JobApplicationMissing()
        {
            driver.Navigate().GoToUrl("https://www.naukri.com/mnjuser/recommendedjobs");//Recomnded Job
            Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://codeachi.com/jobs");//Application URL
            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//button[normalize-space()='Accept']")).Click();//Click On accept button popup
            Thread.Sleep(4000);

            //driver.FindElement(By.XPath("//a[@title='Apply now']")).Click();
            //Wait statement
            //Thread.Sleep(4000);

            driver.FindElement(By.XPath("//input[@placeholder='1 (702) 123-4567']")).SendKeys("98765-43210");//Enter Mobilr Number
            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//input[@placeholder='City']")).SendKeys("hyderabad");//Enter City
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='State']")).SendKeys("ap");//Enter State
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Applying Job Post']")).SendKeys("naukri");//Applying Job Post
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Expected Salary Per Month (in INR)']")).SendKeys("60,000");//Enter Expected Salary
            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//textarea[@placeholder='Message']")).SendKeys("job");//Message
            Thread.Sleep(9000);


            IWebElement resumeUpload = driver.FindElement(By.XPath("//input[@title=' Upload resume']"));//Upload resume
            resumeUpload.SendKeys("C:/Users/ADMIN/Downloads/freshers-resume.pdf");
            Thread.Sleep(9000);


            IWebElement photoUpload = driver.FindElement(By.XPath("//input[@title=' Upload Photo']"));//Upload Photo
            photoUpload.SendKeys("C:\\Users\\ADMIN\\Downloads\\images3.png");
            Thread.Sleep(9000);

            Actions actions = new Actions(driver);
            actions.ScrollByAmount(0, 300).Perform();

            IWebElement Checkbox = driver.FindElement(By.XPath("//input[@type='checkbox']"));//Click On Check Box
            Checkbox.Click();
            Thread.Sleep(9000);

            // Submit the application form
            IWebElement submitApplicationButton = driver.FindElement(By.XPath("//button[normalize-space()='Submit Application']"));//Enter Submit Application Button
            submitApplicationButton.Click();
            Thread.Sleep(6000);

            /*string ChildWindowName = driver.WindowHandles[2];
            driver.SwitchTo().Window(ChildWindowName);*/

            //close the current window and assosiated window
            Thread.Sleep(4000);
            driver.Quit();







        }
    }
}
