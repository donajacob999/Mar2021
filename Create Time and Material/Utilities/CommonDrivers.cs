using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Time_and_Material.Pages;

namespace Time_and_Material.Utilities
{
    class CommonDrivers
    {
        // Initializing the common driver 'driver
        public IWebDriver driver;

        [OneTimeSetUp]    // OneTimeSetUp is used, so that multipe browser instances wont be created.
        public void LoginTM()
        {
            Console.WriteLine("Hello World!");

            //Launch the TurnpUp portal
            driver = new ChromeDriver(@"C:\Repos\First\Create Time and Material");

            // Page objects for LoginPage
            LoginPage loginObj = new LoginPage();
            loginObj.loginSteps(driver);              // driver has to be initialized outside of any of the class, so that it can be used from anywhere. So this will be defined under the Utilities 
        }

        [OneTimeTearDown]   // Similar to OneTimeSetUp, this is for one final browser closure.
        public void FinalSteps()
        {
            //Close Driver
            driver.Close();
        }

    }
}
