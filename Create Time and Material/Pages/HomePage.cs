using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Time_and_Material.Pages
{
    class HomePage
    {
        public void navigateToTM(IWebDriver driver)
        {
            //Identify and click Administration dropdown
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administration.Click();

            //Identify and click Time & Materials button
            IWebElement time_and_material_button = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            time_and_material_button.Click();
        }
    }
}
