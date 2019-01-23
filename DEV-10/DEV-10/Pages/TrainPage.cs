using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DEV_10.Pages
{
    public class TrainPage
    {
        /// <summary>Train tab</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:menu:s2")]
        public IWebElement TrainTab { get; set; }
    }
}
