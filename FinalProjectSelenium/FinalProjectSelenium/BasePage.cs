using OpenQA.Selenium;


namespace FinalProjectSelenium
{
    public class BasePage
    {
        public IWebDriver Driver { get; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }


    }   
}
