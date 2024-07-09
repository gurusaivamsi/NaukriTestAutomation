﻿using Naukri_Job_Application1.BaseClasses;
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
    public class ErrorHandilingInvalidSearchResult : BaseClass
    {



        private HomePage2 homepage2;
        private NoJobsFoundPage nojobsfoundPage;



        [Test]
        public void ErrorHandling()
        {
            //Search for product---Valid Search

            homepage2 = new HomePage2();
            nojobsfoundPage = new NoJobsFoundPage();

            homepage2.ErrorHandling();

            //ClassicAssert.That(resultPage.AssetResult(), Is.EqualTo("1 - 19 of 24036 \"Software Tester Jobs In Bengaluru\""));
            //Thread.Sleep(7000);
            Console.WriteLine(nojobsfoundPage.AssetResult());

        }

    }
}