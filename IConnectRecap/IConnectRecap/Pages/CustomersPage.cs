using IConnectRecap.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IConnectRecap.Pages
{
    public class CustomersPage
    {
        private int frame;
        private int id;

        public string ContactDetailWindow { get; private set; }

        public void CreateCustomersPage(IWebDriver driver)
        {
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            Thread.Sleep(3000);

            IWebElement nameTextBox = driver.FindElement(By.Id("Name"));
            nameTextBox.SendKeys("Smith N");
            Thread.Sleep(1000);

            IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
            editContactButton.Click();
            Thread.Sleep(3000);

            // switch to popup (Frame) window
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id=\"contactDetailWindow\"]/iframe")));
            Thread.Sleep(2000);
        
            driver.FindElement(By.Name("FirstName")).SendKeys("Neil");
            Thread.Sleep(1000);
            
            IWebElement lastNameTextBox = driver.FindElement(By.Id("LastName"));
            lastNameTextBox.SendKeys("Smith");
            Thread.Sleep(1000);

            IWebElement preferedNameTextBox = driver.FindElement(By.Id("PreferedName"));
            preferedNameTextBox.SendKeys("Smith");
            Thread.Sleep(1000);

            IWebElement phoneTextBox = driver.FindElement(By.Id("Phone"));
            phoneTextBox.SendKeys("04123456");
            Thread.Sleep(1000);

            IWebElement mobileTextBox = driver.FindElement(By.Id("Mobile"));
            mobileTextBox.SendKeys("03456789");
            Thread.Sleep(1000);

            IWebElement emailTextBox = driver.FindElement(By.Id("email"));
            emailTextBox.SendKeys("smith@gmail.com");
            Thread.Sleep(1000);

            IWebElement faxTextBox = driver.FindElement(By.Id("Fax"));
            faxTextBox.SendKeys("03789456");
            Thread.Sleep(1000);

            IWebElement streetTextBox = driver.FindElement(By.Id("Street"));
            streetTextBox.SendKeys("220 Main Street");
            Thread.Sleep(1000);

            IWebElement cityTextBox = driver.FindElement(By.Id("City"));
            cityTextBox.SendKeys("Melbourne");
            Thread.Sleep(1000);

            IWebElement postCodeTextBox = driver.FindElement(By.Id("Postcode"));
            postCodeTextBox.SendKeys("2050");
            Thread.Sleep(1000);

            IWebElement countryTextBox = driver.FindElement(By.Id("Country"));
            countryTextBox.SendKeys("Australia");
            Thread.Sleep(1000);

            IWebElement submitButton = driver.FindElement(By.Id("submitButton"));
            submitButton.Click();
            Thread.Sleep(2000);

            // Switch back to main frame
            driver.SwitchTo().ParentFrame();

            IWebElement sameContactCheckBox = driver.FindElement(By.Id("IsSameContact"));
            sameContactCheckBox.Click();
            Thread.Sleep(2000);

            IWebElement GstTextBox = driver.FindElement(By.Id("GST"));
            GstTextBox.SendKeys("102203");

            IWebElement saveButton = driver.FindElement(By.Id("submitButton"));
            saveButton.Click();

            //Find the new customer record on last page
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[4]/a[4]"));

            //Verifying last record in the last table
            IWebElement newName = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[last()]/td[2]"));
            IWebElement newCreatedDate = driver.FindElement(By.XPath("//*[@id=\"clientsGrid\"]/div[2]/table/tbody/tr[last()]/td[3]"));

            Assert.That(newName.Text == "Smith N", "Actual name and expected name do not match");
            Assert.That(newCreatedDate.Text == "12/06/2023", "Actual new create date and expected create date do not match");








        }
    }

}
