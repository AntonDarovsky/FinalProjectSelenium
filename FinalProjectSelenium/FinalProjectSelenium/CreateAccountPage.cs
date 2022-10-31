using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProjectSelenium
{
    public class CreateAccountPage : BasePage
    {
        public static readonly By _genderButton = By.Id("id_gender1");

        public static readonly By _firstNameField = By.Id("customer_firstname");

        public static readonly By _lastNameField = By.Id("customer_lastname");

        public static readonly By _passwordField = By.Id("passwd");

        public static readonly By _daysDropdown = By.Id("days");

        public static readonly By _monthsDropdown = By.Id("months");

        public static readonly By _yearsDropdown = By.Id("years");

        public static readonly By _addressField = By.Id("address1");

        public static readonly By _cityField = By.Id("city");

        public static readonly By _stateDropdown = By.Id("id_state");

        public static readonly By _zipCodeField = By.Id("postcode");

        public static readonly By _phoneField = By.Id("phone_mobile");

        public static readonly By _submitButton = By.Id("submitAccount");

        public CreateAccountPage(IWebDriver driver) : base(driver)
        {
        }
        public void ChooseGender()
        {
            Driver.WaitForElement(_genderButton, TimeSpan.FromMinutes(2)).Click();
        }
        public void AddFirstName(string firstname)
        {
            Driver.WaitForElement(_firstNameField, TimeSpan.FromMinutes(2)).SendKeys(firstname);
        }
        public void AddLastName(string lastname)
        {
            Driver.WaitForElement(_lastNameField, TimeSpan.FromMinutes(2)).SendKeys(lastname);
        }
        public void AddPassword(string password)
        {
            Driver.WaitForElement(_passwordField, TimeSpan.FromMinutes(2)).SendKeys(password);
        }
        public void AddDayofBirthday(string dayOfBirthday)
        {
            SelectElement dayDropdown = new SelectElement(Driver.WaitForElement(_daysDropdown, TimeSpan.FromMinutes(2)));
            dayDropdown.SelectByValue(dayOfBirthday);
        }
        public void AddMonthofBirthday(string monthOfBirthday)
        {
            SelectElement monthDropdown = new SelectElement(Driver.WaitForElement(_monthsDropdown, TimeSpan.FromMinutes(2)));
            monthDropdown.SelectByValue(monthOfBirthday);
        }
        public void AddYearofBirthday(string yearOfBirthday)
        {
            SelectElement yearDropdown = new SelectElement(Driver.WaitForElement(_yearsDropdown, TimeSpan.FromMinutes(2)));
            yearDropdown.SelectByValue(yearOfBirthday);
        }
        public void AddAddress(string address)
        {
            Driver.WaitForElement(_addressField, TimeSpan.FromMinutes(2)).SendKeys(address);
        }
        public void AddCity(string city)
        {
            Driver.WaitForElement(_cityField, TimeSpan.FromMinutes(2)).SendKeys(city);
        }
        public void AddState(string state)
        {
            SelectElement stateDropdown = new SelectElement(Driver.WaitForElement(_stateDropdown, TimeSpan.FromMinutes(2)));
            stateDropdown.SelectByValue(state);
        }
        public void AddZipCode(string zipcode)
        {
            Driver.WaitForElement(_zipCodeField, TimeSpan.FromMinutes(2)).SendKeys(zipcode);
        }
        public void AddPhone(string phone)
        {
            Driver.WaitForElement(_phoneField, TimeSpan.FromMinutes(2)).SendKeys(phone);
        }
        public void SubmitButton()
        {
            Driver.WaitForElement(_submitButton, TimeSpan.FromMinutes(2)).Click();
        }

    }
}
