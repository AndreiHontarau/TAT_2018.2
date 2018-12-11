using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_9
{
    class LoginPage
    {
        By UsernameLocator = By.Id("email");
        By PasswordLocator = By.Id("pass");
        By LoginButtonLocator = By.Id("u_0_2");

        public string UserName { get; set; }
        public string Password { get; set; }

        public void Login(IWebDriver driver)
        {
            driver.FindElement(UsernameLocator).Click();
            driver.FindElement(UsernameLocator).SendKeys(UserName);
            driver.FindElement(PasswordLocator).SendKeys(Password);
            driver.FindElement(LoginButtonLocator).Click();
        }
    }
}
