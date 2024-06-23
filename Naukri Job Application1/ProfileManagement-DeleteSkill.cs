using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naukri_Job_Application1.Utility;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Naukri_Job_Application1
{
    [TestFixture]
    public class ProfileManagement_DeleteSkill : BaseClass
    {
        //14.Profile Management - Delete Skill
        [Test]  
        public void ProfileManagementMethod()
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
            Thread.Sleep(9000);
            //driver.FindElement(By.XPath("/html/body/main/div/div/div[3]/div/div[3]/div[2]/a")).Click();
            driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[2]/a[1]")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/span/div/div/div/div/div/div[2]/div[1]/div/div/ul/li[4]")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//div[@class='widgetHead typ-16Bold']//span[@class='edit icon'][normalize-space()='editOneTheme']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//div[@title='Linux']//a[@class='material-icons close'][normalize-space()='Cross']")).Click();
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//button[@id='saveKeySkills']")).Click();
            Thread.Sleep(6000);
            Console.WriteLine(driver.Title);
            driver.Quit();
        }
    }
}
