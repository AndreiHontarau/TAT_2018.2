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
    class MessegesPage
    {
        By DialogsList = By.XPath("//*[@class = '_4u-c _3_e8 _9hq']");
        By UnreadDialog = By.XPath("//*[@class = '_4u-c _3_e8 _9hq']//*[@class = '_5l-3 _1ht1 _1ht3']");
        //By UnreadMessege 

        public IReadOnlyCollection<IWebElement> GetUnreadDialogs(IWebDriver driver)
        {
            return driver.FindElements(UnreadDialog);
        }

        //public List<Dialog> GetUnreadDialogsMesseges(IWebDriver driver)
        //{
        //    IReadOnlyCollection<IWebElement> unreadDialogs = GetUnreadDialogs(driver);
        //    List<Dialog> unreadDialogsMesseges = new List<Dialog>();

        //    foreach (IWebElement unreadDialog in unreadDialogs)
        //    {
                
        //    }
        //}
    }
}
