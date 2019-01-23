using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using DEV_10.Pages;
using OpenQA.Selenium;

namespace DEV_10.Tests
{
    [TestFixture]
    public class RoutesPageTest
    {
        ChromeDriver _driver;
        RoutesPage _routesPage;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(); ;
            _routesPage = new RoutesPage();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _driver.Navigate().GoToUrl("https://poezd.rw.by/wps/portal/home/rp/schedule/");
            PageFactory.InitElements(_driver, _routesPage);
        }

        [TearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void ElectronicRegistration()
        {
            Assert.AreEqual(_routesPage.ElectronicRegistrationCheckBox.Enabled, true);
        }

        [Test]
        [TestCase("БРЕСТ-ЦЕНТРАЛЬНЫЙ", "ВИТЕБСК-ПАССАЖИРСКИЙ")]
        [TestCase("Осиповичи-1", "Барановичи")]
        public void CorrectFields(string departure, string destination)
        {
            var trainPage = new TrainPage();
            PageFactory.InitElements(_driver, trainPage);
            _routesPage.DepartureStationTextBox.SendKeys(departure);
            _routesPage.DestinationStationTextBox.SendKeys(destination);
            _routesPage.ContinueButton.Click();
            Assert.IsTrue(trainPage.TrainTab.Enabled);
        }
    }
}
