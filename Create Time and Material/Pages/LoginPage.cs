using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Time_and_Material.Pages
{
    class LoginPage
    {
        public void loginSteps(IWebDriver driver)
        {
            //*******LOGIN PAGE *************
             
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            
            //Maximize the browser window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //Identify and enter the username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //Identify and enter password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //Identify and click Login button
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            LoginButton.Click();
            Thread.Sleep(1000);

            //Validate Login page
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, TEST PASSED");
            }
            else
            {
                Console.WriteLine("Log in failed, TEST FAILED");
            }

        }
    }
}
