using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace TAProject1.HookUp
{
    [Binding]
    public class TimeandMaterialSteps
        
    {
        IWebDriver driver;

        [Given(@"I have logged into the Turnup portal successfully")]
        public void GivenIHaveLoggedIntoTheTurnupPortalSuccessfully()
        {
            //Basic login code
            driver = new ChromeDriver();
            //Creating instance of Login Page
            Login loginpage = new Login(driver);
            loginpage.LoginSuccess();
        }

        [Given(@"Verify the title of the page")]
        public void GivenVerifyTheTitleOfThePage()
        {
            String ActualTitle = driver.Title;
            String ExpectedTitle = "Log In - Dispatching System";
            Assert.AreEqual(ActualTitle, ExpectedTitle);
            Console.WriteLine("passed");
            Console.ReadLine();
        }

        [Given(@"I create a time and material")]
        public void GivenICreateATimeAndMaterial()
        {
            //Creating instance of home page
            Home homepage = new Home(driver);
            homepage.ClickAdministration();
            homepage.ClickTimeAndMaterials();
            //Creating instance of time and material
            TimeMaterial timematerial = new TimeMaterial(driver);
            timematerial.ClickCreatenew();
            timematerial.CreateNewRecord("code", "description");

            timematerial.ValidateNewRecord("code", "description");
        }
       
        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            Thread.Sleep(1000);
            driver.Close();
        }
        [Given(@"I edit an existing time and material record")]
        public void GivenIEditAnExistingTimeAndMaterialRecord()
        {
            Home homepage = new Home(driver);
            homepage.ClickAdministration();
            homepage.ClickTimeAndMaterials();
            TimeMaterial timematerial = new TimeMaterial(driver);
            timematerial.EditNewRecord();

        }
        [Then(@"the record should be edited successfully")]
        public void ThenTheRecordShouldBeEditedSuccessfully()
        {
            
            TimeMaterial timematerial = new TimeMaterial(driver);
            timematerial.ValidateNewRecord();
            driver.Quit();
        }

        [Given(@"I create a time and material record with below (.*)")]
        public void GivenICreateATimeAndMaterialRecordWithBelow(string p0, string p1)
        {
            //Creating instance of home page
            Home homepage = new Home(driver);
            homepage.ClickAdministration();
            homepage.ClickTimeAndMaterials();
            //Creating instance of time and material
            TimeMaterial timematerial = new TimeMaterial(driver);
            timematerial.ClickCreatenew();
            timematerial.CreateNewRecord(p0,p1);

            timematerial.ValidateNewRecord("code", "description");

        }


    }
}
