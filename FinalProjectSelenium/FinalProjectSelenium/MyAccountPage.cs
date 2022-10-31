using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FinalProjectSelenium
{
    public class MyAccountPage: BasePage
    {
        public static readonly By _wishlistButton = By.XPath("//*[contains(@href, 'http://automationpractice.com/index.php?fc=module&module=blockwishlist&controller=mywishlist')]");

        public static readonly By _tshirtButton = By.XPath("//*[@id='block_top_menu']/ul/li[3]/a");

        public static readonly By _productButton = By.CssSelector(".left-block");

        public static readonly By _wishlistButtonInProduct = By.Id("wishlist_button");

        public static readonly By _wishlistField = By.Id("name");

        public static readonly By _submitButton = By.Id("submitWishlist");

        public static readonly By _accountButton = By.CssSelector(".account");

        public static readonly By _dressesButton = By.XPath("//*[@id='block_top_menu']/ul/li[2]/a");

        public static readonly By _addToCart1 = By.XPath("//*[contains(@title,'Add to cart') and contains(@data-id-product,'3')]");

        public static readonly By _addToCart2 = By.XPath("//*[contains(@title,'Add to cart') and contains(@data-id-product,'4')]");

        public static readonly By _addToCart3 = By.XPath("//*[contains(@title,'Add to cart') and contains(@data-id-product,'5')]");

        public static readonly By _closeWindow = By.XPath("//*[contains(@title,'Close window')]");

        public static readonly By _cartButton = By.XPath("//*[contains(@title,'View my shopping cart')]");
        public MyAccountPage(IWebDriver driver) : base(driver)
        {
        }
        public void ClickOnWishlist()
        {
            Driver.WaitForElement(_wishlistButton, TimeSpan.FromMinutes(2)).Click();
        }

        public void GoToProductDetailsPage()
        {
            Driver.WaitForElement(_tshirtButton, TimeSpan.FromMinutes(2)).Click();
        }

        public void OpenProduct()
        {
            Driver.WaitForElement(_productButton, TimeSpan.FromMinutes(2)).Click();
        }

        public void ClickOnAddToWishlist()
        {
            Driver.WaitForElement(_wishlistButtonInProduct, TimeSpan.FromMinutes(2)).Click();
        }

        public void EnterNameOfYourWishlist(string name)
        {
            Driver.WaitForElement(_wishlistField, TimeSpan.FromMinutes(2)).SendKeys(name);
        }

        public void ClickSubmitButton()
        {
            Driver.WaitForElement(_submitButton, TimeSpan.FromMinutes(2)).Click();
        }

        public void ClickAccountButton()
        {
            Driver.WaitForElement(_accountButton, TimeSpan.FromMinutes(2)).Click();
        }

        public void GoToDressesPage()
        {
            Driver.WaitForElement(_dressesButton, TimeSpan.FromMinutes(2)).Click();
        }

        public void ClickonAddToCart1()
        {
            Driver.WaitForElement(_addToCart1,TimeSpan.FromMinutes(2)).Click();

            Thread.Sleep(1000);
        }

        public void ClickonAddToCart2()
        {
            Driver.WaitForElement(_addToCart2, TimeSpan.FromMinutes(2)).Click();

            Thread.Sleep(1000);
        }

        public void ClickonAddToCart3()
        {
            Driver.WaitForElement(_addToCart3, TimeSpan.FromMinutes(2)).Click();

            Thread.Sleep(1000);
        }

        public void CloseWindow()
        {
            Driver.WaitForElement(_closeWindow, TimeSpan.FromMinutes(2)).Click();
        }

        public void OpenCart()
        {
            Driver.WaitForElement(_cartButton, TimeSpan.FromMinutes(2)).Click();
        }
    }
}
