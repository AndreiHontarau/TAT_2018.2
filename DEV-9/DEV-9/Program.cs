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
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            LoginPage loginPage = new LoginPage();
            loginPage.UserName = "yopenoz@zdfpost.net";
            loginPage.Password = "FB135795";
            loginPage.Login(driver, 10);

            MainPage mainPage = new MainPage();
            List<Dialog> unreadDialogs = mainPage.GetUnreadDialogs(driver, 15);

            driver.Navigate().GoToUrl("https://www.facebook.com/messages/?filter=unread");
            driver?.FindElement(By.ClassName("_3ixn"))?.Click();

            MessegesPage messegesPage = new MessegesPage();
            messegesPage.ExtractUnreadDialogsMesseges(driver, unreadDialogs);
        }
    }
}
