using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace TAProject1
{

    internal class Login
    {
        private IWebDriver driver;

        IWebElement UserName => driver.FindElement(By.XPath(("//*[@id='UserName']")));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id='Password']"));
        IWebElement LoginBtn => driver.FindElement(By.XPath("//input[@type='submit']"));


        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LoginSuccess()
        {
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            driver.Manage().Window.Maximize();
            // enter hari as username
            UserName.SendKeys("hari");
            //identfying password & sending password
            Password.SendKeys("123123");
            //clicked login btn
            LoginBtn.Click();
        }

        public void VerifyTitle()
        {
            String ActualTitle = driver.Title;
            String ExpectedTitle = "Log In - Dispatching System";
            Assert.AreEqual(ActualTitle, ExpectedTitle);
            Console.WriteLine("passed");
            Console.ReadLine();
        }

    }
}

