using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TAProject1.Helpers;
using TechTalk.SpecFlow;

namespace TAProject1.HookUp
{
    [Binding]
    public class TimeandMaterialSteps : CommonDriver
    {
        [Given(@"I have logged into the Turnup portal successfully")]
        public void GivenIHaveLoggedIntoTheTurnupPortalSuccessfully()
        {
            //Basic login code
            driver = new ChromeDriver();
            //Creating instance of Login Page
            Login loginpage = new Login();
            loginpage.LoginSuccess(driver);

            //Creating instance of home page
            Home homepage = new Home();
            homepage.ClickAdministration(driver);
            homepage.ClickTimeAndMaterials(driver);

        }

        [Given(@"I create a new Time and Material record")]
        public void GivenICreateANewTimeAndMaterialRecord()
        {

            //Creating instance of time and material
            TimeMaterial timematerial = new TimeMaterial();
            timematerial.ClickCreatenew();
            timematerial.CreateNewRecord("jack1", "jack1Desc");
            timematerial.ValidateNewRecord("jack1", "jack1Desc");
        }

        [Given(@"I edit an existing Time and Material record")]
        public void GivenIEditAnExistingTimeAndMaterialRecord()
        {
            TimeMaterial timematerial = new TimeMaterial();
            timematerial.EditNewRecord();
        }

        [Given(@"I create a new Time and Material with below (.*),(.*)")]
        public void GivenICreateANewTimeAndMaterialWithBelowTestdec(string p0, string p1)
        {
            //Creating instance of time and material
            TimeMaterial timematerial = new TimeMaterial();
            timematerial.ClickCreatenew();
            timematerial.CreateNewRecord(p0, p1);
            timematerial.ValidateNewRecord(p0, p1);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            driver.Close();
        }

        [Then(@"The record should be edited successfully")]
        public void ThenTheRecordShouldBeEditedSuccessfully()
        {
            driver.Close();
        }
    }
}