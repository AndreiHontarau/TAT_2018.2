using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using DEV_10.Pages;

namespace DEV_10.Tests
{
    [TestFixture]
    public class LoginTest
    {
        public static ChromeDriver _driver;
        LoginPage _loginPage;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _driver.Navigate().GoToUrl("https://poezd.rw.by/wps/portal/home/login_main/");
            _loginPage = new LoginPage();
            PageFactory.InitElements(_driver, _loginPage);
        }

        [TearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }

        [Test]
        [TestCase("TAT2018.2", "Src8hr")]
        public void CorrectInputLogin(string login, string passwrod)
        {
            var termsPage = new TermsPage();
            PageFactory.InitElements(_driver, termsPage);
            _loginPage.EnterLogin(login);
            _loginPage.EnterPassword(passwrod);
            _loginPage.ClickLogInButton();
            Assert.IsFalse(string.IsNullOrEmpty(termsPage.LogoutLink.Text));
        }

        [Test]
        [TestCase("WrongLogin", "Src8hr")]
        public void WrongInputLogin(string login, string passwrod)
        {
            _loginPage.EnterLogin(login);
            _loginPage.EnterPassword(passwrod);
            _loginPage.ClickLogInButton();
            Assert.IsTrue(_loginPage.LoginErrorMessage.Displayed);
        }

        [Test]
        [TestCase("TAT2018.2", "WrongPassword")]
        public void WrongInputPassword(string login, string passwrod)
        {
            _loginPage.EnterLogin(login);
            _loginPage.EnterPassword(passwrod);
            _loginPage.ClickLogInButton();
            Assert.IsTrue(_loginPage.PasswordErrorMessage.Displayed);
        }
    }
}
