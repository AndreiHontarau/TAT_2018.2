using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DEV_9
{
    class MainPage
    {
        By MessengerButton = By.XPath("//*[@id = 'pagelet_bluebar']//*[@name = 'mercurymessages']");
        By Sender = By.XPath("//*[@class = 'jewelItemNew']//*[@class = 'author']/strong/span");
        private const string numberOfUnreadMessegesPattern = @"(\d)";

        public void GetUnreadDialogs(IWebDriver driver, int timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            List<Dialog> unreadDialogs = new List<Dialog>();

            wait.Until(ExpectedConditions.ElementToBeClickable(MessengerButton));
            driver.FindElement(By.ClassName("_3ixn"))?.Click();
            driver.FindElement(MessengerButton).Click();
            wait.Until(ExpectedConditions.ElementExists(Sender));
            IReadOnlyCollection<IWebElement> Senders = driver.FindElements(Sender);

            string sender;
            int numberOfUnreadMesseges;

            foreach (IWebElement Sender in Senders)
            {
                Console.WriteLine(Sender.Text);

                //unreadDialogs.Add(new Dialog(sender, numberOfUnread));
            }
        }
    }
}