using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Time_and_Material.Utilities
{
    class Wait
    {
        // Generic function to wait for - Element to Exist
        public static void ElementExist(IWebDriver driver, string attribute, string attributeValue, int seconds)
        {
            try
            {
                if (attribute == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(attributeValue)));
                }
                if (attribute == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(attributeValue)));
                }
                if (attribute == "CSSSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(attributeValue)));
                }
            }
            catch(Exception ex)
            {
                Assert.Fail("Test Failed, waiting for element to exist", ex.Message);
            }
            

        }


        // Generic function to wait for - Element is Clickable
        public static void ElementClickable(IWebDriver driver, string attribute, string attributeValue)
        {
            try
            {
                if (attribute == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(attributeValue)));
                }
                if (attribute == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(attributeValue)));
                }
                if (attribute == "CSSSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(attributeValue)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Test Failed, waiting for an element to be clickable", ex.Message);
            }


        }        
    }
}
