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
    class MessegesPage
    {
        By UnreadDialogButton = By.XPath("//*[@class = '_1enh']//*[@class = '_5l-3 _1ht1 _1ht3']");
        By Messege = By.XPath("//*[@class = '_3058 _ui9 _hh7 _s1- _52mr _3oh-']");
        By MessegeText = By.XPath("//*[@class = '_3oh- _58nk']");
        const string hours = @"/d:";
        const string minutes = @":/d";

        public void ExtractUnreadDialogsMesseges(IWebDriver driver, List<Dialog> unreadDialogs)
        {
            List<IWebElement> unreadDialogsButtonsList = new List<IWebElement>();
            List<IWebElement> messegesList = new List<IWebElement>();
            IReadOnlyCollection<IWebElement> unreadDialogsButtons = driver.FindElements(UnreadDialogButton);
            IReadOnlyCollection<IWebElement> messeges = new List<IWebElement>();

            foreach (var x in unreadDialogsButtons)
            {
                unreadDialogsButtonsList.Add(x);
            }

            foreach (Dialog unreadDialog in unreadDialogs)
            {
                Console.WriteLine("\t\t\t" + unreadDialog.sender + "\n");

                IWebElement button = unreadDialogsButtonsList.Find(x => x.Text.Contains(unreadDialog.sender));
                button?.Click();
                unreadDialogsButtonsList.Remove(button);
                messeges = driver.FindElements(Messege);

                foreach (IWebElement messege in messeges)
                {
                    messegesList.Add(messege);
                    //SortMessegesByTime(messegesList);
                }

                for (int i = 0; i < unreadDialog.numberOfUnreadMesseges; i++)
                {
                    Console.WriteLine(messegesList[i].Text + "\n");
                }
            }
        }

        //private void SortMessegesByTime(List<IWebElement> messeges)
        //{
        //    messeges.OrderBy(x => x.GetAttribute("data-tooltip-content"));
            
        //}

        //private DateTime ExtractMessegeDateTime(string time)
        //{

        //}
    }
}
