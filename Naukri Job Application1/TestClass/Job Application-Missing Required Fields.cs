using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;
using Naukri_Job_Application1.BaseClasses;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class Job_Application_Missing_Required_Fields : LoginClass
    {
        //13.Job Application - Missing Required Fields:Negative Scenarios
        [Test]
        public void JobApplicationMissing()
        {
            driver.Navigate().GoToUrl("https://www.naukri.com/mnjuser/recommendedjobs");
            Thread.Sleep(4000);

            driver.Navigate().GoToUrl("https://codeachi.com/jobs");
            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//button[normalize-space()='Accept']")).Click();
            Thread.Sleep(4000);

            //driver.FindElement(By.XPath("//a[@title='Apply now']")).Click();
            //Wait statement
            //Thread.Sleep(4000);

            driver.FindElement(By.XPath("//input[@placeholder='1 (702) 123-4567']")).SendKeys("98765-43210");
            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//input[@placeholder='City']")).SendKeys("hyderabad");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='State']")).SendKeys("ap");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Applying Job Post']")).SendKeys("naukri");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Expected Salary Per Month (in INR)']")).SendKeys("60,000");
            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//textarea[@placeholder='Message']")).SendKeys("job");
            Thread.Sleep(4000);


            IWebElement resumeUpload = driver.FindElement(By.XPath("//input[@title=' Upload resume']"));
            resumeUpload.SendKeys("C:/Users/ADMIN/Downloads/freshers-resume.pdf");
            Thread.Sleep(9000);


            IWebElement photoUpload = driver.FindElement(By.XPath("//input[@title=' Upload Photo']"));
            photoUpload.SendKeys("C:\\Users\\ADMIN\\Downloads\\images3.png");
            Thread.Sleep(9000);

            driver.FindElement(By.XPath("//input[@id='exampleCheck1']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[normalize-space()='Submit Application']")).Click();
            Thread.Sleep(4000);

            /*string ChildWindowName = driver.WindowHandles[2];
            driver.SwitchTo().Window(ChildWindowName);
            
            //close the current window and assosiated window
            driver.Quit();*/







        }
    }
}
