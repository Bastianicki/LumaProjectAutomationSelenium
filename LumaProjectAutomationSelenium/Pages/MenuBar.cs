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
    public class MenuBar
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly MenuBarElements elements;

        public MenuBar(IWebDriver driver)
        {
            this.driver = driver;
            elements = new MenuBarElements();
            wait = Wait.GetFluentWait(driver, 10);
        }

        public By GetWelcomeMessage => elements.GetWelcomeMessage;
        public IWebElement GetSignInButton => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetSignInButton));
        public IWebElement GetCreateAnAccountButton => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetCreateAnAccount));
        public IWebElement GetWelcomeMessageElement => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetWelcomeMessage));
        public IWebElement GetWhatsNewMenuItem => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetWhatsNewMenuItem));
        public IWebElement GetWomenMenuItem => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetWomenMenuItem));
        public IWebElement GetMenMenuItem => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetMenMenuItem));
        public IWebElement GetGearMenuItem => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetGearMenuItem));
        public IWebElement GetTrainingMenuItem => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetTrainingMenuItem));
        public IWebElement GetSaleMenuItem => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetSaleMenuItem));

        public MenuBar ClickOnSignInButton()
        {
            GetSignInButton.Click();
            return this;
        }

        public MenuBar ClickOnCreateAnAccountButton()
        {
            GetCreateAnAccountButton.Click();
            return this;
        }

        public MenuBar ClickOnWgatsNewMenuItem()
        {
            GetWhatsNewMenuItem.Click();
            return this;
        }

        public MenuBar ClickOnWomenMenuItem()
        {
            GetWomenMenuItem.Click();
            return this;
        }

        public MenuBar ClickOnMenMenuItem()
        {
            GetMenMenuItem.Click();
            return this;
        }

        public MenuBar ClickOnGearMenuItem()
        {
            GetGearMenuItem.Click();
            return this;
        }

        public MenuBar ClickOnTrainingMenuItem()
        {
            GetTrainingMenuItem.Click();
            return this;
        }

        public MenuBar ClickOnSaleMenuItem()
        {
            GetSaleMenuItem.Click();
            return this;
        }

    }
}
