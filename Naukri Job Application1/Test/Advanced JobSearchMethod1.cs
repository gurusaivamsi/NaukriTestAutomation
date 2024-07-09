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
    public class JobSearch1 : BaseClass
    {



        private HomePage1 homePage1;
        private FilterPage1 filterPage1;



        [Test]
        public void AdvancedJobSearchMethod2()
        {
            //Search for product---Valid Search

            homePage1 = new HomePage1();
            filterPage1 = new FilterPage1();

            homePage1.AdvancedJobSearchMethod1();

            //ClassicAssert.That(resultPage.AssetResult(), Is.EqualTo("1 - 19 of 24036 \"Software Tester Jobs In Bengaluru\""));
            //Thread.Sleep(7000);
            Console.WriteLine(filterPage1.AssetResult());

        }

    }
}