using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using System.Threading.Tasks;
using Naukri_Job_Application1.Utility;

namespace Naukri_Job_Application1
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

            driver.FindElement(By.XPath("//input[@id='exampleCheck1']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[normalize-space()='Submit Application']")).Click();
            Thread.Sleep(4000);

            /*string ChildWindowName = driver.WindowHandles[2];
            driver.SwitchTo().Window(ChildWindowName);
            driver.FindElement(By.XPath("//*[@id=\"listContainer\"]/div[2]/div/div[1]/div/div[2]/span/a[1]")).Click();
            Thread.Sleep(4000);

            //driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            //Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@id=\"company-site-button\"]")).Click();
            Thread.Sleep(6000);

            driver.FindElement(By.XPath("//h3[normalize-space()='Technology Educator']")).Click();
            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//*[@id=\"joblistinghero-34fa81ba89\"]/div[1]/div[4]/div[1]/a")).Click();
            Thread.Sleep(9000);

            driver.FindElement(By.XPath("//input[@id='frm-last']")).SendKeys("xyz pvt.ltd");
            Thread.Sleep(4000);

            //update the job title
            driver.FindElement(By.XPath("//button[@id='next']")).Click();
            Thread.Sleep(4000);
            //click on check box
           // driver.FindElement(By.XPath("//input[@id='privacy-policy-checkbox']")).Click();
            //Thread.Sleep(4000);
            //click on update button
            //driver.FindElement(By.XPath("//button[normalize-space()='Submit']")).Click();
            //Thread.Sleep(4000);
            //close the current window and assosiated window
            driver.Quit();*/
           
        





        }
    }
}
