using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Naukri_Job_Application1.BaseClasses;
using Naukri_Job_Application1.POM;
using NUnit.Framework.Legacy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml;
using System.Collections.Generic;
//using Naukri_Job_Application1.BaseClasses;


namespace Naukri_Job_Application1.Test
{

    [TestFixture]

    public class Excel : BaseClass
    {
        // [DynamicData(nameof(ReadExcel), DynamicDataSourceType.Method)]
        [TestCaseSource("ReadExcel")]

        public void dynamicdataexceld(String fname, String iname)

        {
            driver.FindElement(By.Id("usernameField")).SendKeys(fname);
            Thread.Sleep(3000);
            driver.FindElement(By.Id("passwordField")).SendKeys(iname);
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
            Thread.Sleep(5000);
            driver.Quit();

        }


        public static IEnumerable<object[]> ReadExcel()
        {


            using (ExcelPackage package = new ExcelPackage(new FileInfo("C:\\Users\\ADMIN\\source\\repos\\NaukriTestAutomation_GIT\\Naukri Job Application1\\Test\\Data6.xlsx")))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.End.Row;
                for (int row = 2; row <= rowCount; row++)
                {
                    yield return new object[]
                    {
                        worksheet.Cells[row, 1].Value?.ToString().Trim(),
                        worksheet.Cells[row, 2].Value?.ToString().Trim()

                    };
                }
            }
        }









    }

}
