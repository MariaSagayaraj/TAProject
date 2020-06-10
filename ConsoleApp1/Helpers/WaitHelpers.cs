using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TAProject1.Helpers
{
    class WaitHelpers
    {
        // generic method that allows driver to wait until element is clickable
        public static void waitClickableElement(IWebDriver driver, string locator, string locatorValue)
        {
            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
                }
                if (locator == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
                }
                if (locator == "CSSSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Excetion at waitClickableElement", ex.Message);
            }

        }
    }
}
