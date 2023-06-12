using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.WaitHelpers
{
    public class Delay
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public Delay(IWebDriver driver)
        {
            this.driver = driver;
            wait = Wait.GetFluentWait(driver, 10);
        }

        public Delay WaitForTextInElement(By by, string text)
        {
            _ = wait.Until(ExpectedConditions.TextToBePresentInElementLocated(by, text));
            return this;
        }
    }
}