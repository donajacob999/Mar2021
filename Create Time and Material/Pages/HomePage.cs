using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Time_and_Material.Pages
{
    class HomePage
    {
        public void navigateToTM(IWebDriver driver)
        {
            //try
            //{
                //Identify and click Administration dropdown
                //Thread.Sleep(1000);
                
                IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                administration.Click();
            //}
            //catch (Exception msg)
            //{
            //    Assert.Fail("Test failed to identify and click Time Material button", msg.Message);
            //}

            //Identify and click Time & Materials button
            IWebElement time_and_material_button = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            time_and_material_button.Click();
            
            
            
        }
        public void navigateToCompanies(IWebDriver driver)
        {
            //Identify and click Administration dropdown
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();
            
            //Identify and click Companies - to-do           



        }
    }
}
