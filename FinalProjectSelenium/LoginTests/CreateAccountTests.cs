using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Web;
using FinalProjectSelenium;
using Assert = NUnit.Framework.Assert;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium.Remote;
using System.Collections.Generic;
using OpenQA.Selenium.Support.Extensions;

namespace LoginTests
{
    [TestFixture]
    [AllureNUnit]
    public class CreateAccountTests
    {
        private IWebDriver driver;


        [OneTimeSetUp]
        public void ClearResultsDir()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [SetUp]
        public void Open()
        {
            driver = new RemoteWebDriver(new Uri("https://oauth-antondarovski97-bf9e3:19b6c1c4-5127-4d25-b46e-d1f8419358ca@ondemand.eu-central-1.saucelabs.com:443/wd/hub"), GetChromeOptions().ToCapabilities(), TimeSpan.FromSeconds(60));
        }
        private ChromeOptions GetChromeOptions()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.PlatformName = "Windows 10";
            chromeOptions.BrowserVersion = "latest";
            chromeOptions.AddAdditionalOption("username", "oauth-antondarovski97-bf9e3");
            chromeOptions.AddAdditionalOption("accessKey", "*****58ca");
            var sauceOptions = new Dictionary<string, object>();
            sauceOptions.Add("build", "selenium-build-5PEA4");
            sauceOptions.Add("name", "<FinalTest>");
            chromeOptions.AddAdditionalOption("sauce:options", sauceOptions);
            return chromeOptions;
        }


        [TearDown]
        public void Close()
        {
            driver.Close();
        }
        public void UITest(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                var screenshot = driver.TakeScreenshot();

                DateTime time = DateTime.Now;

                OperatingSystem os = Environment.OSVersion;
                Version ver = os.Version;

                driver = new ChromeDriver();

                ICapabilities caps1 = ((ChromeDriver)driver).Capabilities;

                string browserName = string.Empty;

                if (caps1.HasCapability("browserName"))
                {
                    browserName = caps1.GetCapability("browserName").ToString();
                }

                string dateToday = "_date_" + time.ToString("yyyy-MM-dd") + "_time_" + time.ToString("HH-mm-ss");

                var filePath = "../../../../Screenshots/";

                screenshot.SaveAsFile(filePath + dateToday + "_" + browserName + caps1.GetCapability("browserVersion") + "_" + os + ver + ".png", ScreenshotImageFormat.Png);

                throw;
            }
        }
                [Test]
        public void CreateAccountTest()
        {
            UITest(() =>
            {

                driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";

                driver.Manage().Window.Maximize();

                LoginPage loginPage = new LoginPage(driver);

                loginPage.CreateAccount("antondarovski97@gmail.com");

                CreateAccountPage createAccountPage = loginPage.GoToCreateAccountPage();

                createAccountPage.ChooseGender();

                createAccountPage.AddFirstName("Anton");

                createAccountPage.AddLastName("Darovsky");

                createAccountPage.AddPassword("antondarleo97");

                createAccountPage.AddDayofBirthday("20");

                createAccountPage.AddMonthofBirthday("12");

                createAccountPage.AddYearofBirthday("1997");

                createAccountPage.AddAddress("first street");

                createAccountPage.AddCity("Los Angeles");

                createAccountPage.AddState("5");

                createAccountPage.AddZipCode("23434");

                createAccountPage.AddPhone("2345235352");

                createAccountPage.SubmitButton();

                var myaccount = driver.WaitForElement(By.CssSelector(".page-heading"), TimeSpan.FromMinutes(2));

                Assert.IsTrue(myaccount.Displayed, "Wrong page!");
            });
        }

        [Test]
        public void LoginAccountTest()
        {
            UITest(() =>
            {
                driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";

                driver.Manage().Window.Maximize();

                LoginPage loginPage = new LoginPage(driver);

                loginPage.LoginAccount("antondarovski97@gmail.com");

                loginPage.PasswordAccount("antondarleo97");

                loginPage.SignIn();

                var myaccount = driver.WaitForElement(By.CssSelector(".page-heading"), TimeSpan.FromMinutes(2));

                Assert.IsTrue(myaccount.Displayed, "Wrong page!");
            });
        }

        [Test]
        public void CreateWishlistTest()
        {
            UITest(() =>
            {
                driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";

                driver.Manage().Window.Maximize();

                LoginPage loginPage = new LoginPage(driver);

                loginPage.LoginAccount("antondarovski97@gmail.com");

                loginPage.PasswordAccount("antondarleo97");

                MyAccountPage myaccountpage = loginPage.GoToMyAcccountPage();

                myaccountpage.ClickOnWishlist();

                myaccountpage.GoToProductDetailsPage();

                myaccountpage.OpenProduct();

                myaccountpage.ClickOnAddToWishlist();

                var window = driver.WaitForElement(By.CssSelector(".fancybox-error"), TimeSpan.FromMinutes(2));

                Assert.IsTrue(window.Displayed, "You add to wishlist");
            });
        }

        [Test]

        public void AddWishlistTest()
        {
            UITest(() =>
            {
                driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";

                driver.Manage().Window.Maximize();

                LoginPage loginPage = new LoginPage(driver);

                loginPage.LoginAccount("antondarovski97@gmail.com");

                loginPage.PasswordAccount("antondarleo97");

                MyAccountPage myaccountpage = loginPage.GoToMyAcccountPage();

                myaccountpage.ClickOnWishlist();

                myaccountpage.EnterNameOfYourWishlist("Anton");

                myaccountpage.ClickSubmitButton();

                myaccountpage.GoToProductDetailsPage();

                myaccountpage.OpenProduct();

                myaccountpage.ClickOnAddToWishlist();

                myaccountpage.ClickAccountButton();

                myaccountpage.ClickOnWishlist();

                var window = driver.WaitForElement(By.Id("block-history"), TimeSpan.FromMinutes(2));

                Assert.IsTrue(window.Displayed, "You add to wishlist");
            });
        }

        [Test]

        public void AddtoCartTest()
        {
            UITest(() =>
            {
                driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";

                driver.Manage().Window.Maximize();

                LoginPage loginPage = new LoginPage(driver);

                loginPage.LoginAccount("antondarovski97@gmail.com");

                loginPage.PasswordAccount("antondarleo97");

                MyAccountPage myaccountpage = loginPage.GoToMyAcccountPage();

                myaccountpage.GoToDressesPage();

                myaccountpage.ClickonAddToCart1();

                myaccountpage.CloseWindow();

                myaccountpage.ClickonAddToCart2();

                myaccountpage.CloseWindow();

                myaccountpage.ClickonAddToCart3();

                myaccountpage.CloseWindow();

                myaccountpage.OpenCart();

                Assert.IsTrue(driver.WaitForElement(By.Id("cart_summary"), TimeSpan.FromMinutes(2)).Displayed, "No products in cart");
            });
        }
    }
}