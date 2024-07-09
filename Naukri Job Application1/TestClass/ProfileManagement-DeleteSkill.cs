using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Threading.Tasks;
using System.Numerics;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class ProfileManagement_DeleteSkill : LoginClass
    {
        //14.Profile Management - Delete Skill:Negative Scenarios
        [Test]
        public void ProfileManagementMethod()
        {
            //Intialize the IwebDriver
            //IWebDriver driver = new ChromeDriver();
            //launch an application
            //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            //driver.Manage().Window.Maximize();
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //String skilltobeDeleted = "ETL";
            //Xpth locators
            //driver.FindElement(By.XPath("//input[@id='usernameField']")).SendKeys("gurusaivamsi4@gmail.com");
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//input[@id='passwordField']")).SendKeys("Vamsi@123");
            //Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
            //Thread.Sleep(9000);
            //driver.FindElement(By.XPath("/html/body/main/div/div/div[3]/div/div[3]/div[2]/a")).Click();
            //click om complete profile button
            driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[2]/a[1]")).Click();
            Thread.Sleep(9000);
            //wait.Until(d => d.FindElement(By.XPath("//div[contains(text(),'Key Skills')]")));
            //bool skillnotFound = driver.PageSource.Contains(skilltobeDeleted);

            //if (skillnotFound)
            //{
            //Console.WriteLine(skilltobeDeleted + " Skill Already present in the Key Skill List. Hence skill is the deleted");
            //}
            //else
            //{
            //Console.WriteLine(skilltobeDeleted + " Skill not present in the Key Skill List. Hence proceeding to deleted");
            //click on skill link
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/span/div/div/div/div/div/div[2]/div[1]/div/div/ul/li[4]")).Click();
            Thread.Sleep(9000);
            //click on edit link
            driver.FindElement(By.XPath("//div[@class='widgetHead typ-16Bold']//span[@class='edit icon'][normalize-space()='editOneTheme']")).Click();
            Thread.Sleep(4000);
            //delete the skill
            driver.FindElement(By.XPath("//div[@title='ETL']//a[@class='material-icons close'][normalize-space()='Cross']")).Click();
            Thread.Sleep(6000);
            //click on save button
            driver.FindElement(By.XPath("//button[@id='saveKeySkills']")).Click();
            Thread.Sleep(6000);
            //skillnotFound = driver.PageSource.Contains(skilltobeDeleted);
            //if (skillnotFound)
            //{
            //Console.WriteLine(skilltobeDeleted + "Deleted successfully in the list");
            //}
            //else
            //{
            //Console.WriteLine(skilltobeDeleted + "is not Deleted in the list. Hence failing the test case");
            //}
            //dispaly the title page
            Console.WriteLine(driver.Title);
            //Console.WriteLine(driver.Title);
            //}
            //close the current window and assosiated window
            Thread.Sleep(4000);
            driver.Quit();
        }
    }
}
