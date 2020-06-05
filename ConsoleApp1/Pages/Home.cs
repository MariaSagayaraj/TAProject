using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TAProject1
{
    class Home
    {
        private IWebDriver driver;

        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Click Administration 
        internal void ClickAdministration()
        {
            Assert.That(driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]")).Text, Is.EqualTo("Administration"));
            
            //Click action on Administration
            driver.FindElement(By.XPath("//a[@href='#'][contains(.,'Administration')]")).Click();
        }

        //Click Time and Material
        internal void ClickTimeAndMaterials()
        {
            Assert.That(driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Text, Is.EqualTo("Time & Materials"));

            //Click action on Time & Material
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }

    }
}

