using Naukri_Job_Application1.BaseClasses;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naukri_Job_Application1.TestClass
{
    [TestFixture]
    public class CompanySearchandDetailVerification : BaseClass
    {
        //6.Company Search and Details Verification
        [Test]
        public void CompanySearchMethod()
        {

            //Intialize the IwebDriver
            //IWebDriver driver = new ChromeDriver();
            //launch an application
            //driver.Navigate().GoToUrl("https://www.naukri.com/nlogin/login");
            //Maximize the Window
            //driver.Manage().Window.Maximize();

            //Xpth locators
            //click on Search Field Here
            IWebElement ClickonSearch = driver.FindElement(By.XPath("//span[@class='nI-gNb-sb__placeholder']"));
            ClickonSearch.Click();
            //Wait statement
            Thread.Sleep(4000);
            //Enter the specific company
            IWebElement Companyname = driver.FindElement(By.XPath("//input[@placeholder='Enter keyword / designation / companies']"));
            Companyname.SendKeys("TCS");
            Thread.Sleep(4000);
            //click on the search button
            IWebElement SearchButton = driver.FindElement(By.XPath("//button[@class='nI-gNb-sb__icon-wrapper']"));
            SearchButton.Click();
            Thread.Sleep(9000);
            //Display the displays relevant information (e.g., about, job openings).
            driver.FindElement(By.XPath("//*[@id='listContainer']/div[2]/div/div[1]/div/div[1]/a")).Click();
            Thread.Sleep(4000);
            //Display the page title Name
            Console.WriteLine(driver.Title);
            //close the current windo and assosiated window
            driver.Quit();

        }
    }
}
