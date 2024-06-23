using Naukri_Job_Application1.Utility;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukri_Job_Application1
{
    [TestFixture]
    public class ProfileUpdate_SkillAddition : LoginClass
    {
        //4.Profile Update - Skill Addition
        [Test]
        public void ProfileUpdateMethod()
        {

            //Intialize the IwebDriver
            //IWebDriver driver = new ChromeDriver();
            //launch an application
            //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            //driver.Manage().Window.Maximize();
            //Xpth locators
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            String skilltobeAdded = "ETL";

            /*driver.FindElement(By.XPath("//input[@id='usernameField']")).SendKeys("gurusaivamsi4@gmail.com");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@id='passwordField']")).SendKeys("Vamsi@123");
            Thread.Sleep(4000);
            //Login to Naukri
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
            Thread.Sleep(9000);*/
            //driver.FindElement(By.XPath("/html/body/main/div/div/div[3]/div/div[3]/div[2]/a")).Click();
            //Navigate to Profile Page

            driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[2]/a[1]")).Click();
            Thread.Sleep(9000);

            //wait.Until(d => d.FindElement(By.XPath("//div[contains(text(),'Key Skills')]")));
            bool skillFound = driver.PageSource.Contains(skilltobeAdded);

            if (skillFound)
            {
                Console.WriteLine(skilltobeAdded + " Skill Already present in the Key Skill List. Hence skipping the add");
            }
            else
            {
                Console.WriteLine(skilltobeAdded + " Skill not present in the Key Skill List. Hence proceeding to add");
                driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/span/div/div/div/div/div/div[2]/div[1]/div/div/ul/li[4]")).Click();
                Thread.Sleep(9000);
                driver.FindElement(By.XPath("//div[@class='widgetHead typ-16Bold']//span[@class='edit icon'][normalize-space()='editOneTheme']")).Click();
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//input[@id='keySkillSugg']")).SendKeys(skilltobeAdded);
                Thread.Sleep(6000);
                driver.FindElement(By.XPath("//button[@id='saveKeySkills']")).Click();
                Thread.Sleep(10000);
                skillFound = driver.PageSource.Contains(skilltobeAdded);
                if (skillFound)
                {
                    Console.WriteLine(skilltobeAdded + "Added successfully in the list");
                }
                else
                {
                    Console.WriteLine(skilltobeAdded + "is not added in the list. Hence failing the test case");
                }

                Console.WriteLine(driver.Title);

            }
            driver.Quit();
        }
    }
}
