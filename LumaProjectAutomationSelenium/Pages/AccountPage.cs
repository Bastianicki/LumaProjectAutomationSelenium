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
    public class AccountPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly AccountElements elements;

        public AccountPage(IWebDriver driver)
        {
            this.driver = driver;
            elements = new AccountElements();
            wait = Wait.GetFluentWait(driver, 10);
        }

        // Messages
        public IWebElement MessageSuccess => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetMessageSuccess));
        public IWebElement ContactInformation => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetContactInformation));
        public IWebElement AlertAccountSignIncorrect => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetAlertAccountSignIncorrect));
        public IWebElement AlertInvalidEmailAddress => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetAlertInvalidEmailAddress));

        // Left panel
        public IWebElement MyAccountsSideBarMenu => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetMyAccountsSideBarMenu));
        public IWebElement MyOrdersSideBarMenu => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetMyOrdersSideBarMenu));
        public IWebElement MyDownloadableProductsSideBarMenu => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetMyDownloadableProductsSideBarMenu));
        public IWebElement MyWishListSideBarMenu => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetMyWishListSideBarMenu));
        public IWebElement AddressBookSideBarMenu => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetAddressBookSideBarMenu));
        public IWebElement AccountInformationSideBarMenu => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetAccountInformationSideBarMenu));
        public IWebElement StoredPaymentMethodsSideBarMenu => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetStoredPaymentMethodsSideBarMenu));
        public IWebElement MyProductReviewsSideBarMenu => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetMyProductReviewsSideBarMenu));
        public IWebElement NewsletterSubscriptionsSideBarMenu => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetNewsletterSubscriptionsSideBarMenu));

        public AccountPage ClickOnMyAccountsSideBarMenu()
        {
            MyAccountsSideBarMenu.Click();
            return this;
        }

        public AccountPage ClickOnMyOrdersSideBarMenu()
        {
            MyOrdersSideBarMenu.Click();
            return this;
        }

        public AccountPage ClickOnMyDownloadableProductsSideBarMenu()
        {
            MyDownloadableProductsSideBarMenu.Click();
            return this;
        }

        public AccountPage ClickOnMyWishListSideBarMenu()
        {
            MyWishListSideBarMenu.Click();
            return this;
        }

        public AccountPage ClickOnAddressBookSideBarMenu()
        {
            AddressBookSideBarMenu.Click();
            return this;
        }

        public AccountPage ClickOnAccountInformationSideBarMenu()
        {
            AccountInformationSideBarMenu.Click();
            return this;
        }

        public AccountPage ClickOnStoredPaymentMethodsSideBarMenu()
        {
            StoredPaymentMethodsSideBarMenu.Click();
            return this;
        }

        public AccountPage ClickOnMyProductReviewsSideBarMenu()
        {
            MyProductReviewsSideBarMenu.Click();
            return this;
        }

        public AccountPage ClickOnNewsletterSubscriptionsSideBarMenu()
        {
            NewsletterSubscriptionsSideBarMenu.Click();
            return this;
        }

    }
}
