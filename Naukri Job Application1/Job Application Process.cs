using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naukri_Job_Application1.Utility;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Threading.Tasks;
using System.Numerics;

namespace Naukri_Job_Application1
{
    [TestFixture]
    public class Job_Application_Process : BaseClass
    {
        //3.Job Application Process
        /*[Test]
        public void JobApplicationProcessMethod()
        {

            //Intialize the IwebDriver
            //IWebDriver driver = new ChromeDriver();
            //launch an application
            //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            //driver.Manage().Window.Maximize();

            //Xpth locators
            driver.FindElement(By.XPath("//input[@id='usernameField']")).SendKeys("gurusaivamsi4@gmail.com");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@id='passwordField']")).SendKeys("Vamsi@123");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
            //launch an application
          driver.Navigate().GoToUrl("https://www.naukri.com/mnjuser/recommendedjobs");
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("///p[@title='Support Engineer (Microsoft Technologies with Unity Cloud)']")).Click();
          Thread.Sleep(4000);

          string ChildWindowName = driver.WindowHandles[1];
          driver.SwitchTo().Window(ChildWindowName);
          driver.FindElement(By.XPath("//div[@class='styles_jhc__apply-button-container__5Bqnb']//button[@id='company-site-button']")).Click();
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//button[normalize-space()='Get in touch']")).Click();
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//div[@class='sendMsg']")).Click();
          Thread.Sleep(4000);

          driver.FindElement(By.XPath("//div[@class='chatbot_InputContainer']")).SendKeys("vamsi");
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//div[@class='sendMsg']")).Click();
          Thread.Sleep(4000);

          driver.FindElement(By.XPath("//label[@for='Yes']")).Click();
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//div[@class='sendMsg']")).Click();
          Thread.Sleep(4000);

          driver.FindElement(By.XPath("//label[@for='Bangalore']")).Click();
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//div[@class='sendMsg']")).Click();
          Thread.Sleep(4000);

          driver.FindElement(By.XPath("//div[@id='_2ms5txi0l14']")).Click();
          Thread.Sleep(4000);

          driver.FindElement(By.XPath("//div[@id='userInput__2ms5txi0lInputBox']")).SendKeys("23456");
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//div[@class='sendMsg']")).Click();
          Thread.Sleep(4000);
          driver.Quit();

        }*/
    }
}
