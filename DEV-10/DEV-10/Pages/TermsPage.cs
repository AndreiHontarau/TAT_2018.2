using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DEV_10.Pages
{
    public class TermsPage
    {
        /// <summary>Logout link.</summary>
        [FindsBy(How = How.Id, Using = "logoutlink")]
        public IWebElement LogoutLink { get; set; }

        /// <summary>Agree with terms checkbox.</summary>
        [FindsBy(How = How.ClassName, Using = "selectBooleanCheckbox")]
        public IWebElement AgreeCheckBox { get; set; }

        /// <summary>
        /// Click the 'agree' checkbox.
        /// </summary>
        public void ClickCheckBox()
        {
            AgreeCheckBox.Click();
        }
    }
}
