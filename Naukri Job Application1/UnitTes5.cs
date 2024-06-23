using Microsoft.VisualStudio;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Runtime.CompilerServices;
using OpenQA.Selenium.IE;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Collections.ObjectModel;
using Naukri_Job_Application1.Utility;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;



namespace Naukri_Job_Application1
{
    [TestFixture]
    public class UniTest5 : BaseClass
    {
        //[SetUp]
        //1.Basic Job Search
        [Test]
        
           
            public void jobapplication1()
            {
                //Intialize the IwebDriver
                //IWebDriver driver = new ChromeDriver();
                //launch an application
                //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
                //Maximize the Window
                //driver.Manage().Window.Maximize();

                //Xpth locators
                driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
                //Wait statement
                Thread.Sleep(4000);
                driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
                Thread.Sleep(4000);
                //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
                //Thread.Sleep(6000);
                driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Bengaluru");
                Thread.Sleep(4000);
                //string s1=driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Text;
                //Console.WriteLine(s1);
                driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
                Thread.Sleep(9000);
                Console.WriteLine(driver.Title);
                driver.Quit();

            }




        //4.Profile Update - Skill Addition
        /*[Test]
        public void jobapplication2()
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
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("/html/body/main/div/div/div[3]/div/div[3]/div[2]/a")).Click();
            driver.FindElement(By.XPath("/html[1]/body[1]/main[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[2]/a[1]")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div/span/div/div/div/div/div/div[2]/div[1]/div/div/ul/li[4]")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//div[@class='widgetHead typ-16Bold']//span[@class='edit icon'][normalize-space()='editOneTheme']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@id='keySkillSugg']")).SendKeys("Devops Admin");
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//button[@id='saveKeySkills']")).Click();
            Thread.Sleep(6000);
            Console.WriteLine(driver.Title);
            driver.Quit();
         }*/

        //5.Email Subscription - Job Alerts
        /*[Test]

        public void jobapplication3()
        {
            //Intialize the IwebDriver
            /IWebDriver driver = new ChromeDriver();
            //launch an application
            //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            //driver.Manage().Window.Maximize();

            //Xpth locators
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
            //Thread.Sleep(6000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("bengaluru");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.LinkText("Send me jobs like these")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter alert name']")).SendKeys("software testers bengaluru");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter your active Email ID']")).SendKeys("gurusaivamsi4@gmail.com");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();
            Thread.Sleep(4000);
            Console.WriteLine(driver.Title);
            driver.Quit();
        }*/

        //6.Company Search and Details Verification
        /*[Test]
        public void jobapplication4()
        {
            //Intialize the IwebDriver
            IWebDriver driver = new ChromeDriver();
            //launch an application
            driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            driver.Manage().Window.Maximize();
            //Xpth locators
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("TCS");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//*[@id='listContainer']/div[2]/div/div[1]/div/div[1]/a")).Click();
            Thread.Sleep(4000);
            Console.WriteLine(driver.Title);
            driver.Quit();

        }*/




        //11.Error Handling - Invalid Search Results
        /*[Test]
        public void jobapplication5()
        {
            //Intialize the IwebDriver
            IWebDriver driver = new ChromeDriver();
            //launch an application
            driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            driver.Manage().Window.Maximize();

            //Xpth locators
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("hgk");
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
            //Thread.Sleep(6000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("chittor");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            Console.WriteLine(driver.Title);
            driver.Quit();

        }*/






        //12.Form Validation - Blank Search:Negative Scenario
        /*[Test]
        public void jobapplication6()
        {
            //Intialize the IwebDriver
            IWebDriver driver = new ChromeDriver();
            //launch an application
            driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            driver.Manage().Window.Maximize();
            //xpath locator
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(4000);
            //Console.WriteLine(driver.Title);
            driver.Quit();


        }*/

        //14.Profile Management - Delete Skill
        /*[Test]  
        public void jobapplication7()
        {
            //Intialize the IwebDriver
            IWebDriver driver = new ChromeDriver();
            //launch an application
            driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            driver.Manage().Window.Maximize();
            //Xpth locators
            driver.FindElement(By.XPath("//input[@id='usernameField']")).SendKeys("gurusaivamsi4@gmail.com");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@id='passwordField']")).SendKeys("Vamsi@123");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
            Thread.Sleep(4000);
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
        }*/

        //15.Job Alerts - Invalid Email Subscription
        /*[Test]
        public void jobapplication8()
        {
            //Intialize the IwebDriver
            IWebDriver driver = new ChromeDriver();
            //launch an application
            driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            driver.Manage().Window.Maximize();

            //Xpth locators
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
            //Thread.Sleep(6000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("bengalore");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.LinkText("Send me jobs like these")).Click();
            Thread.Sleep(9000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter alert name']")).SendKeys("software tester,bengalore");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter your active Email ID']")).SendKeys("gurusaivamsi47437@gmail.com");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();
            Thread.Sleep(4000);
            Console.WriteLine(driver.Title);
            driver.Quit();
        }*/

        //2.Advanced Job Search - Filters
        /*[Test]
        public void jobapplication10()
        {
            //Intialize the IwebDriver
            IWebDriver driver = new ChromeDriver();
            //launch an application
            driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            driver.Manage().Window.Maximize();
            //Xpth locators
            driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
            //Wait statement
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
            //Thread.Sleep(6000);

            driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("Bengaluru");
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
            Thread.Sleep(9000);
            //driver.FindElement(By.XPath("//input[@id='experienceDD']"));
            //Thread.Sleep(9000);
            driver.FindElement(By.XPath("//label[@for='chk-6-10 Lakhs-ctcFilter-']")).Click();
            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//div[@class='rc-slider-rail']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath(" //div[@class='inside'] ")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//div[@class='cir']")).Click();
            Thread.Sleep(4000);
            IWebElement element =driver.FindElement(By.XPath("//div[@class='inside']"));
            IWebElement element1 = driver.FindElement(By.XPath("//div[@class='cir']"));
            Console.WriteLine(element);
            Console.WriteLine(element1);
            SelectElement selectElement = new Select(element,element1);
            //Actions actions = new Actions(driver);
            Thread.Sleep(4000);
            SelectElement.(element).Perform();
            Thread.Sleep(4000);
            SelectElement.(element1).Perform();
            Thread.Sleep(4000);







            driver.FindElement(By.XPath("//label[@for='chk-IT Services & Consulting-industryTypeIdGid-']")).Click();
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath(" //div[@class='cir']")).Click();
            //Thread.Sleep(9000);
            //driver.FindElement(By.XPath("//div[@class='inside']")).Click();
            //Thread.Sleep(9000);
            //Current Window and Assosiated Window
            Thread.Sleep(9000);
            driver.Quit();
        }*/

        //3.Job Application Process
        /*[Test]
        public void jobapplication11()
        {

          //Intialize the IwebDriver
          IWebDriver driver = new ChromeDriver();
          //launch an application
          driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
          //Maximize the Window
          driver.Manage().Window.Maximize();

          //Xpth locators
          driver.FindElement(By.XPath("//input[@id='usernameField']")).SendKeys("gurusaivamsi4@gmail.com");
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//input[@id='passwordField']")).SendKeys("Vamsi@123");
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//a[normalize-space()='Was Administrator']")).Click();
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//div[@class='styles_jhc__apply-button-container__5Bqnb']//button[@id='apply-button']")).Click();
          Thread.Sleep(4000);
          driver.FindElement(By.XPath("//div[@id='userInput__2ms5txi0lInputBox']")).SendKeys("sai");
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

        //8.Advanced Job Search - Multiple Filters:positive scenarios
        /*[Test]
        public void jobapplication7()
        {
         //Intialize the IwebDriver
         IWebDriver driver = new ChromeDriver();
         //launch an application
         driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
         //Maximize the Window
         driver.Manage().Window.Maximize();
         //Xpth locators
         driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']")).Click();
         //Wait statement
         Thread.Sleep(4000);
         driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']")).SendKeys("software tester");
         Thread.Sleep(4000);
         //driver.FindElement(By.XPath("//span[@class='ni-gnb-icn ni-gnb-icn-expand-more']")).SendKeys("software tester");
         //Thread.Sleep(6000);
         driver.FindElement(By.XPath("//input[@placeholder='Enter location']")).SendKeys("bengalore");
         Thread.Sleep(4000);
         driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']")).Click();
         Thread.Sleep(9000);
         driver.FindElement(By.XPath("//div[@data-filter-id='industryTypeGid']//div[1]")).Click();
         Thread.Sleep(4000);
         driver.FindElement(By.XPath("//div[@data-type='absolute']//div[@data-filter-id='citiesGid']//div[1]")).Click();
         Thread.Sleep(4000);
         driver.FindElement(By.XPath("//div[@data-type='absolute']//div[@data-filter-id='salaryRange']//div[1]")).Click();
         Thread.Sleep(6000);
         driver.FindElement(By.XPath("//div[@data-filter-id='industryTypeGid']//div[1]")).Click();
         Thread.Sleep(6000);
         driver.Quit();

        }*/




       
    }





}




















