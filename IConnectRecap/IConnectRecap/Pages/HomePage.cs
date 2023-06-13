using IConnectRecap.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConnectRecap.Pages
{
    public class HomePage : CommonDriver
    {

        public void GoToCustomerPage(IWebDriver driver)
        {
            //Navigate to Cusmtomers page
            IWebElement goToAdministrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            goToAdministrationTab .Click();
            Thread.Sleep(2000);

            //Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a", 7);

            IWebElement goToCustomerOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a"));
            goToCustomerOption.Click();


        }
   
   


    }
}
