using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.Utilities
{
    public class BrowserUtilities
    {
        private readonly IWebDriver driver;

        public BrowserUtilities(IWebDriver driver)
        {
            this.driver = driver;
        }

        public BrowserUtilities StartBrowser(string baseUrl = "https://magento.softwaretestingboard.com/")
        {
            driver.Navigate().GoToUrl(baseUrl);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return this;
        }

        public BrowserUtilities QuitBrowser()
        {
            driver.Quit();
            return this;
        }
    }
}
