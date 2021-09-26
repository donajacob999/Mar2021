using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Time_and_Material.Pages;
using Time_and_Material.Utilities;

namespace Create_Time_and_Material
{
    [TestFixture]
    [Parallelizable]    // This is used so that tests in program class and CompaniesTest class can run simultaneously
    class Program : CommonDrivers
    {
        /*  ************Commenting the below Main() as we are now going to learn & use UNIT TESTING . The same codes from below will be used for Unit Testing ************ 
        
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello World!");

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

            //Close Driver
            driver.Close();
        }  */

          
        
        [Test]
        public void CreateTM()
        {
            // Page Objects for HomePage
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(driver);

            //Page Objects for TimeMaterialPage
            TimeMaterialPage TMObj = new TimeMaterialPage();
            TMObj.createTM(driver);
        }

        [Test]
        public void EditTM()
        {
            // Page Objects for HomePage
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(driver);

            //Page Objects for TimeMaterialPage
            TimeMaterialPage TMObj = new TimeMaterialPage();
            TMObj.editTM(driver);
        }

        [Test]
        public void DeleteTM()
        {
            // Page Objects for HomePage
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(driver);

            //Page Objects for TimeMaterialPage
            TimeMaterialPage TMObj = new TimeMaterialPage();
            TMObj.deleteTM(driver);
        }





    }
}

