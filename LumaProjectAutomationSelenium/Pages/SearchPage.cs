using LumaProjectAutomationSelenium.Elements;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumaProjectAutomationSelenium.WaitHelpers;

namespace LumaProjectAutomationSelenium.Pages
{
    public class SearchPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly SearchElements elements;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            elements = new SearchElements();
            wait = Wait.GetFluentWait(driver, 10);
        }


        public IWebElement SearchField => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetSearchField));
        public IWebElement SearchButton => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetSearchButton));
        public IWebElement FirstItemFiltered => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetFirstItemFiltered));
        public IWebElement SecondItemFiltered => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetSecondItemFiltered));
        public IWebElement ThirdItemFiltered => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetThirdItemFiltered));
        public IWebElement FourthItemFiltered => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetFourthItemFiltered));
        public IWebElement FifthItemFiltered => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetFifthItemFiltered));

        public SearchPage SendKeysToSearchField(string element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(SearchField)).SendKeys(element);
            return this;
        }

        public SearchPage ClickOnSearchButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(SearchButton)).Click();
            return this;
        }

        public SearchPage ClickOnFirstItemFiltered()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(FirstItemFiltered)).Click();
            return this;
        }

        public SearchPage ClickOnSecondItemFiltered()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(SecondItemFiltered)).Click();
            return this;
        }

        public SearchPage ClickOnThirdItemFiltered()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(ThirdItemFiltered)).Click();
            return this;
        }

        public SearchPage ClickOnFourthItemFiltered()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(FourthItemFiltered)).Click();
            return this;
        }

        public SearchPage ClickOnFifthItemFiltered()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(FifthItemFiltered)).Click();
            return this;
        }

    }
}
