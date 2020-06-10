using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TAProject1.Helpers;

namespace TAProject1
{
    public class Baseclass : CommonDriver
    {
        
        [OneTimeSetUp]
       

        public void Login()
        {
            // open a browser
            driver = new ChromeDriver();
            Login loginpage = new Login();
            loginpage.LoginSuccess(driver);

            //Creating instance of home page
            Home homepage = new Home();
            homepage.ClickAdministration(driver);
            homepage.ClickTimeAndMaterials(driver);

        }

        [OneTimeTearDown]
        

        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}


