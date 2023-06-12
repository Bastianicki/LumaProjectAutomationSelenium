using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.WaitHelpers
{
    public static class Wait
    {
        public static WebDriverWait GetFluentWait(IWebDriver driver, int seconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds))
            {
                PollingInterval = TimeSpan.FromMilliseconds(1000)
            };

            return wait;
        }
    }
}