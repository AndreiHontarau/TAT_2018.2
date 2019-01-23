using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DEV_10.Pages
{
    public class LoginPage
    {
        /// <summary>Login text field.</summary>
        [FindsBy(How = How.CssSelector, Using = "input#login")]
        public IWebElement LoginTextBox { get; set; }

        /// <summary>Password text field.</summary>
        [FindsBy(How = How.CssSelector, Using = "input#password")]
        public IWebElement PasswordTextBox { get; set; }

        /// <summary>Login button.</summary>
        [FindsBy(How = How.CssSelector, Using = "input.commandExButton")]
        public IWebElement LoginButton { get; set; }

        /// <summary>Login error message.</summary>
        [FindsBy(How = How.Id, Using = "login.errors")]
        public IWebElement LoginErrorMessage { get; set; }

        /// <summary>Password error message.</summary>
        [FindsBy(How = How.Id, Using = "password.errors")]
        public IWebElement PasswordErrorMessage { get; set; }

        /// <summary>
        /// Enter login in the login text box.
        /// </summary>
        /// <param name="login.">Login.</param>
        public void EnterLogin(string login)
        {
            LoginTextBox.SendKeys(login);
        }

        /// <summary>
        /// Enter password in the password text box.
        /// </summary>
        /// <param name="password.">Password.</param>
        public void EnterPassword(string password)
        {
            PasswordTextBox.SendKeys(password);
        }

        /// <summary>
        /// Click login button.
        /// </summary>
        public void ClickLogInButton()
        {
            LoginButton.Click();
        }
    }
}
