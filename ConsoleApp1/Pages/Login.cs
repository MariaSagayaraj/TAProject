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
        public void LoginSuccess(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
           Assert.AreEqual("Log In", driver.FindElement(By.XPath("//*[@id='loginForm']/form/h2")).Text);
           // driver.Manage().Window.Maximize();
            // enter hari as username
            driver.FindElement(By.XPath(("//*[@id='UserName']"))).SendKeys("hari");
            //identfying password & sending password
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("123123");
            //clicked login btn
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }

        //public void VerifyTitle(IWebDriver driver)
        //{
        //    String ActualTitle = driver.Title;
        //    String ExpectedTitle = "Dashboard - Dispatching System";
        //    Assert.AreEqual(ActualTitle, ExpectedTitle);
        //    Console.WriteLine("passed");
        //    Console.ReadLine();
        //}

        public void Loginfailure(IWebDriver driver)
        {
            //Identify username and enter user name as hari
            driver.FindElement(By.XPath("//*[@id='UserName']")).SendKeys("hari");

            //identfying password & sending password
            driver.FindElement(By.XPath("//*[@id='Password']")).SendKeys("123123");
        }
    }
}

