using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Time_and_Material.Pages;

namespace Create_Time_and_Material
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Launch the TurnpUp portal
            IWebDriver driver = new ChromeDriver(@"C:\Repos\First\Create Time and Material");

            // Page objects for LoginPage
            LoginPage loginObj = new LoginPage();
            loginObj.loginSteps(driver);

            // Page Objects for HomePage
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(driver);

            //Page Objects for TimeMaterialPage
            TimeMaterialPage TMObj = new TimeMaterialPage();
            TMObj.createTM(driver);
            TMObj.editTM(driver);
            TMObj.deleteTM(driver);



        }
    }
}

