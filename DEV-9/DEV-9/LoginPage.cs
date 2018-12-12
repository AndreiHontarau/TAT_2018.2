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
        By LoginBar = By.XPath("//*[@id = 'pagelet_bluebar']");
        By UsernameLocator = By.XPath("//*[@id = 'pagelet_bluebar']//*[@type = 'email']");
        By PasswordLocator = By.XPath("//*[@id = 'pagelet_bluebar']//*[@type = 'password']");
        By LoginButtonLocator = By.XPath("//*[@id = 'pagelet_bluebar']//*[@type = 'submit']");

        public string UserName { get; set; }
        public string Password { get; set; }

        public void Login(IWebDriver driver, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementToBeClickable(LoginButtonLocator));
            driver.FindElement(UsernameLocator).Click();
            driver.FindElement(UsernameLocator).SendKeys(UserName);
            driver.FindElement(PasswordLocator).SendKeys(Password);
            driver.FindElement(LoginButtonLocator).Click();
        }
    }
}
