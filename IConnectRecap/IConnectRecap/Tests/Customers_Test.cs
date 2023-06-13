using IConnectRecap.Pages;
using IConnectRecap.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConnectRecap.Tests
{
    [TestFixture]
    public class Customers_Test : CommonDriver
    {
        HomePage HomePageObj = new HomePage();
        CustomersPage CustomersPageObj = new CustomersPage();

        [SetUp]
        public void SetUpActions()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //CustomersPageObj = new CustomersPage();

            HomePage homePageOb = new HomePage();
            homePageOb.GoToCustomerPage(driver);

        }
        
        [Test, Order(1)]
        public void CreateCustomers_Test()

        {
            CustomersPage customersPageObj = new CustomersPage();
            customersPageObj.CreateCustomersPage(driver);
        }











    }
    
    
   

    
}
