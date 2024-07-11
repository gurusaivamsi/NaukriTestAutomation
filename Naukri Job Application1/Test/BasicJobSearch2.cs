using Naukri_Job_Application1.BaseClasses;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naukri_Job_Application1.POM;
using System.Threading.Tasks;
//using Flipkart.BaseClasses;
//using Naukri_Job_Application.BaseClasses;

namespace Naukri_Job_Application1.Test
{
    [TestFixture]
    public class JobSearch : BaseClass
    {



        private HomePage homePage;
        private FilterPage filterPage;



        [Test]
        public void BasicJobSearch()
        {
            //Search for product---Valid Search

            homePage = new HomePage();
            filterPage = new FilterPage();

            homePage.BasicJobSearch2();

            //ClassicAssert.That(resultPage.AssetResult(), Is.EqualTo("1 - 19 of 24036 \"Software Tester Jobs In Bengaluru\""));
            //Thread.Sleep(7000);
            Console.WriteLine(filterPage.AssetResult());

        }

    }
}