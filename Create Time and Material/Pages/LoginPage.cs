using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Time_and_Material.Utilities;

namespace Time_and_Material.Pages
{
    class LoginPage
    {
        public void loginSteps(IWebDriver driver)
        {
            //*******LOGIN PAGE *************
            // Below are commented out because these are refactored into one method. Right click->Quick actions and refactoring->Extract Method. This will create a new method #Ref1

            //driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            ////Maximize the browser window
            //driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            try
            {
                //Wait.ElementExists(driver, "Id", "UserName", 5);           // In this step, it is going to wait 5 sec and check if there is a Webelement with ID as 'Username'. If it exist, then it will do the next function.

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
            }
            catch (Exception msg)
            {
                Assert.Fail("Test Failed at Login Page", msg.Message);
            }
            
            Wait.ElementExist(driver, "XPath", "//*[@id='logoutForm']/ul/li/a", 5);     //In this step, it is going to wait for 5 sec and within that 5sec will check if there is a webelement with XPath as '//*[@id.....li/a'. If it exist, then will perform the next action.
                                                                                        //Validate User Logged in page or user landing page
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Thread.Sleep(1500);

            // ************* Commenting out the below 'if' statement and going to start using Assert. Assert is the right way to check if test passed or fail in NUnit

            //if (hellohari.Text == "Hello hari!")
            //{
            //    Console.WriteLine("Logged in successfully, TEST PASSED");
            //}
            //else
            //{
            //    Console.WriteLine("Log in failed, TEST FAILED");
            //} 

            // Option 1 to use ASSERT statement
            Assert.That(hellohari.Text, Is.EqualTo("Hello hari!"), ("Test Failed"));

            //Option 2 to use Asssert statement

            //if (hellohari.Text == "Hello hari!")
            //{
            //    Assert.Pass("Logged in successfully, TEST PASSED");
            //                }
            //else
            //{
            //    Assert.Fail("Log in failed, TEST FAILED");
            //}




        }

        

        // #Ref1
        public void navigateToLoginPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Maximize the browser window
            driver.Manage().Window.Maximize();
        }

        public bool ValidateThatYouAreAtLoginPage(IWebDriver driver)
        {
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            return LoginButton.Displayed;
        }
        public void enterUsernameAndPassword(IWebDriver driver)
        {
            try
            {
                //Wait.ElementExists(driver, "Id", "UserName", 5);           // In this step, it is going to wait 5 sec and check if there is a Webelement with ID as 'Username'. If it exist, then it will do the next function.

                //Identify and enter the username
                IWebElement username = driver.FindElement(By.Id("UserName"));
                username.SendKeys("hari");

                //Identify and enter password
                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("123123");                                
            }
            catch (Exception msg)
            {
                Assert.Fail("Test Failed at Login Page", msg.Message);
            }
        }

        public void clickLogInButton(IWebDriver driver)
        {
            //Identify and click Login button
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            LoginButton.Click();
            Thread.Sleep(1000);
        }

        public bool validateLoggedInSuccessfully(IWebDriver driver)
        {
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Thread.Sleep(1500);

            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, TEST PASSED");
                return true;
            }
            else
            {
                Console.WriteLine("Log in failed, TEST FAILED");
                return false;

            }
        }

        public bool validateNotLoggedIn(IWebDriver driver)
        {
            Wait.ElementExist(driver, "XPath", "/ html / body / div[4] / div / div / section / form / div[1]", 5);
            IWebElement loginErrorMessage = driver.FindElement(By.XPath("/ html / body / div[4] / div / div / section / form / div[1]"));
            return loginErrorMessage.Displayed;
            //   
        }


    }
}
