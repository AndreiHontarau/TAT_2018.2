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
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            
            LoginPage loginPage = new LoginPage();
            loginPage.UserName = "yopenoz@zdfpost.net";
            loginPage.Password = "FB135795";
            loginPage.Login(driver);

            driver.Navigate().GoToUrl("https://www.facebook.com/messages/?filter=unread");

        }
    }
}
