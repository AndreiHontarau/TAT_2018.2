using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DEV_10.Pages
{
    public class RoutesPage
    {
        [FindsBy(How = How.ClassName, Using = "page")]
        public IWebElement Page { get; set; }

        /// <summary>Selected tab</summary>
        [FindsBy(How = How.ClassName, Using = "tabsl2_ch")]
        public IWebElement TrainTabSelected { get; set; }

        /// <summary>Warning message</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:messages2")]
        public IWebElement WarningMessage { get; set; }

        /// <summary>Departure station text box.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:textDepStat")]
        public IWebElement DepartureStationTextBox { get; set; }

        /// <summary>Destination station text box.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:textArrStat")]
        public IWebElement DestinationStationTextBox { get; set; }

        /// <summary>Departure warning message.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:message1")]
        public IWebElement DepartureWarningMessage { get; set; }

        /// <summary>Destination warning message.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:message2")]
        public IWebElement DestinationWarningMessage { get; set; }

        /// <summary>Switch stations button.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:ns_Z7_9HD6HG80NGMO80ABJ9NPD12001_j_id1591088840_5ed61755")]
        public IWebElement SwitchStationsButton { get; set; }
        
        /// <summary>Date text box.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:dob")]
        public IWebElement DateTextBox { get; set; }

        /// <summary>Warning message for date text box.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:message3")]
        public IWebElement DateWarningMessage { get; set; }

        /// <summary>Date picker button.</summary>
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-trigger")]
        public IWebElement DatePickerButton { get; set; }

        /// <summary>Calendar datepicker</summary>
        [FindsBy(How = How.ClassName, Using = "ui-datepicker-div")]
        public IWebElement DatePicker { get; set; }

        /// <summary>Time selection box.</summary>
        [FindsBy(How = How.ClassName, Using = "time")]
        public IWebElement TimeSelectionBox { get; set; }

        /// <summary>Cells with an o'clock's values</summary>
        public IList<IWebElement> TimeCells { get; set; }

        /// <summary>Choose all time in time selection box.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed6129a")]
        public IWebElement ChooseAllTimeReference { get; set; }

        /// <summary>Choose no time in time selection box.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:ns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_j_id1591088840_5ed612ad")]
        public IWebElement ChooseNoTimeReference { get; set; }

        /// <summary>Electronic registration check box.</summary>
        [FindsBy(How = How.Id, Using = "viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:onlyER")]
        public IWebElement ElectronicRegistrationCheckBox { get; set; }

        /// <summary>Continue button.</summary>
        [FindsBy(How = How.ClassName, Using = "commandExButton")]
        public IWebElement ContinueButton { get; set; }

        /// <summary>Reset button.</summary>
        [FindsBy(How = How.ClassName, Using = "commandExRedButton")]
        public IWebElement ResetButton { get; set; }

        /// <summary>
        /// Selects spesified time range. Pass two equal numbers to select one cell</summary>
        /// </summary>
        /// <param name="cellNumberFrom">First interval limit</param>
        /// <param name="cellNumberTo">Second interval limitt</param>
        public void SetTimeInterval(int cellNumberFrom, int cellNumberTo)
        {
            if (TimeCells == null)
            {
                TimeCells = TimeSelectionBox.FindElements(By.TagName("a"));
            }

            ChooseNoTimeReference.Click();

            TimeCells[cellNumberFrom].Click();
            TimeCells[cellNumberTo].Click();
        }

        /// <summary>
        /// Sets departure and destination stations
        /// </summary>
        /// <param name="departureStation">Departure station name</param>
        /// <param name="destinationStation">Destination station name</param>
        public void SetRoute(string departureStation, string destinationStation)
        {
            DepartureStationTextBox.SendKeys(departureStation);
            DestinationStationTextBox.SendKeys(destinationStation);
        }

        /// <summary>
        /// Sets date
        /// </summary>
        /// <param name="day">Day</param>
        /// <param name="month">Month</param>
        public void SetDate(int day, int month, int year)
        {
            DateTextBox.Clear();
           DateTextBox.SendKeys(day + "." + month + "." + year);
        }
    }
}
