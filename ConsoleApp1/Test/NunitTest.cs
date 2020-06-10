using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TAProject1
{
    [TestFixture]
    
    class NunitTest:Baseclass
    { 

        [Test, Order(1)]
        [TestCaseSource(typeof(TestDataClass), "TestCases")]
        public void AddTMTest(String code, String description)
        {
            //Creating instance of time and material
            TimeMaterial timematerial = new TimeMaterial();
            timematerial.ClickCreatenew();
            timematerial.CreateNewRecord(code, description);
            timematerial.ValidateNewRecord(code, description);
            
        }

        [Test, Order(2)]
        public void EditTMTest()
        {
            TimeMaterial timematerial = new TimeMaterial();
            timematerial.EditNewRecord();
        }

        [Test]

        public void DeleteTMTest()
        {
            TimeMaterial timematerial = new TimeMaterial();
            timematerial.DeleteNewRecord();
        }

    }
}