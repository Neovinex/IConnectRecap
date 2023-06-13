using IConnectRecap.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IConnectRecap.Pages
{
    internal class LoginPage : CommonDriver
    {
        public void LoginSteps(IWebDriver driver)
        {
            //Launch Turn up Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            Wait.WaitToExist(driver, "Id", "UserName", 5);

            try
            {
                IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
                userNameTextBox.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Assert.Fail("TurnUp Portal did not loard");
            }

            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            IWebElement tickBoxRememberMe = driver.FindElement(By.Id("RememberMe"));
            tickBoxRememberMe.Click();
            Thread.Sleep(2500);

            IWebElement logInButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            logInButton.Click();
            Thread.Sleep(2000);


        }



    }
}
