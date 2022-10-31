using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProjectSelenium
{
    public class LoginPage : BasePage
    {
        public static readonly By _emailField = By.Id("email_create");

        public static readonly By _createButton = By.Id("SubmitCreate");

        public static readonly By _emailFieldLogin = By.Id("email");

        public static readonly By _passwordField = By.Id("passwd");

        public static readonly By _submitButton = By.Id("SubmitLogin");

        

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void CreateAccount(string login)
        {
            Driver.WaitForElement(_emailField, TimeSpan.FromMinutes(2)).SendKeys(login);

            Thread.Sleep(1000);
        }

        public CreateAccountPage GoToCreateAccountPage()
        {
            Driver.WaitForElement(_createButton, TimeSpan.FromMinutes(2)).Click();

            return new CreateAccountPage(Driver);
        }

        public void LoginAccount(string login)
        {
            Driver.WaitForElement(_emailFieldLogin, TimeSpan.FromMinutes(2)).SendKeys(login);
        }

        public void PasswordAccount(string password)
        {
            Driver.WaitForElement(_passwordField, TimeSpan.FromMinutes(2)).SendKeys(password);
        }

        public void SignIn()
        {
            Driver.WaitForElement(_submitButton, TimeSpan.FromMinutes(2)).Click();
        }

        public MyAccountPage GoToMyAcccountPage()
        {
            Driver.WaitForElement(_submitButton, TimeSpan.FromMinutes(2)).Click();

            return new MyAccountPage(Driver);
        }
    }
}
