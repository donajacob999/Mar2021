using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Time_and_Material.Pages;
using Time_and_Material.Utilities;

namespace Time_and_Material.Tests
{
    [TestFixture]
    [Parallelizable]
    class CompaniesTest : CommonDrivers
    {
        [Test]
        public void CreateCompanyTest()
        {
            // Page Objects for HomePage
            HomePage homeObj = new HomePage();
            homeObj.navigateToCompanies(driver);

            //Page Objects for CompaniesPage
            CompaniesPage companyObj = new CompaniesPage();
            companyObj.CreateComapany(driver);
        }

        [Test]
        public void EditCompanyTest()
        {
            // Page Objects for HomePage
            HomePage homeObj = new HomePage();
            homeObj.navigateToCompanies(driver);

            //Page Objects for CompaniesPage
            CompaniesPage companyObj = new CompaniesPage();
            companyObj.EditCompany(driver);
        }

        [Test]
        public void DeleteCompanyTest()
        {
            // Page Objects for HomePage
            HomePage homeObj = new HomePage();
            homeObj.navigateToCompanies(driver);

            //Page Objects for CompaniesPage
            CompaniesPage companyObj = new CompaniesPage();
            companyObj.EditCompany(driver);
        }
    }
}
