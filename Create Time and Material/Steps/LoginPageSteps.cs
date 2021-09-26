using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Time_and_Material.Pages;

namespace Time_and_Material.Steps
{
    [Binding]
    public class LoginPageSteps
    {
        public readonly IWebDriver driver;

        public LoginPageSteps()
        {
            driver = new ChromeDriver(@"C:\Repos\First\Create Time and Material");
        }

        [AfterScenario]
        public void RunAfterEveryTest()
        {
            driver.Close();
        }

        [Given("I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.navigateToLoginPage(driver);

            Console.WriteLine("I am at the login page");
        }

        [Given("I validate that I am at the login page")]
        public void GivenIValidateThatIAmAtTheLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            bool isAtLoginPage = loginPage.ValidateThatYouAreAtLoginPage(driver);

            Assert.IsTrue(isAtLoginPage);
        }

        [When("I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.enterUsernameAndPassword(driver);

            Console.WriteLine("I enter valid credentials");
        }
        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.clickLogInButton(driver);

            Console.WriteLine("I click  the login button");
        }

        [When("I login with username '(.*)'")]
        public void WhenILoginWithUsername(string username)
        {
            Console.WriteLine("When I login with username =" + username);
            
        }

        [When("I login with (.*) and with (.*)")]
        public void WhenILoginWithUsername(string username, string password)
        {

            Console.WriteLine("When I login with username =" + username + "and with password=" + password);

        }
        [Then("I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            LoginPage loginPage = new LoginPage();
            bool isLoggedIn = loginPage.validateLoggedInSuccessfully(driver);
            Console.WriteLine("I should be logged in successfully");
            Assert.IsTrue(isLoggedIn);            
        }

        [Then("I should be not logged in")]
        public void ThenIShouldBeNotLoggedIn()
        {
            
            LoginPage loginPage = new LoginPage();
            bool isNotLoggedIn = loginPage.validateNotLoggedIn(driver);
            Console.WriteLine("I should be not logged in");
            Assert.IsTrue(isNotLoggedIn);
        }
    }
}
