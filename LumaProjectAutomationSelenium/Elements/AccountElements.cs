using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace LumaProjectAutomationSelenium.Elements
{
    public class AccountElements
    {
        private readonly By myAccountsSideBarMenu = By.XPath("//ul[@class='nav items']//child::*[self::a or self::strong][text()='My Account']");
        private readonly By myOrdersSideBarMenu = By.XPath("//ul[@class='nav items']//child::*[self::a or self::strong][text()='My Orders']");
        private readonly By myDownloadableProductsSideBarMenu = By.XPath("//ul[@class='nav items']//child::*[self::a or self::strong][text()='My Downloadable Products']");
        private readonly By myWishListSideBarMenu = By.XPath("//ul[@class='nav items']//child::*[self::a or self::strong][text()='My Wish List']");
        private readonly By addressBookSideBarMenu = By.XPath("//ul[@class='nav items']//child::*[self::a or self::strong][text()='Address Book']");
        private readonly By accountInformationSideBarMenu = By.XPath("//ul[@class='nav items']//child::*[self::a or self::strong][text()='Account Information']");
        private readonly By storedPaymentMethodsSideBarMenu = By.XPath("//ul[@class='nav items']//child::*[self::a or self::strong][text()='Stored Payment Methods']");
        private readonly By myProductReviewsSideBarMenu = By.XPath("//ul[@class='nav items']//child::*[self::a or self::strong][text()='My Product Reviews']");
        private readonly By newsletterSubscriptionsSideBarMenu = By.XPath("//ul[@class='nav items']//child::*[self::a or self::strong][text()='Newsletter Subscriptions']");

        private readonly By contactInformation = By.XPath("//div[@class='box-content']");
        private readonly By alertAccountSignIncorrect = By.CssSelector("div[data-bind='html: $parent.prepareMessageForHtml(message.text)']");
        private readonly By alertInvalidEmailAddress = By.Id("email-error");

        private readonly By messageSuccess = By.XPath("//div[@data-ui-id='message-success']//child::div");


        public By GetMyAccountsSideBarMenu => myAccountsSideBarMenu;
        public By GetMyOrdersSideBarMenu => myOrdersSideBarMenu;
        public By GetMyDownloadableProductsSideBarMenu => myDownloadableProductsSideBarMenu;
        public By GetMyWishListSideBarMenu => myWishListSideBarMenu;
        public By GetAddressBookSideBarMenu => addressBookSideBarMenu;
        public By GetAccountInformationSideBarMenu => accountInformationSideBarMenu;
        public By GetStoredPaymentMethodsSideBarMenu => storedPaymentMethodsSideBarMenu;
        public By GetMyProductReviewsSideBarMenu => myProductReviewsSideBarMenu;
        public By GetNewsletterSubscriptionsSideBarMenu => newsletterSubscriptionsSideBarMenu;

        public By GetContactInformation => contactInformation;
        public By GetAlertAccountSignIncorrect => alertAccountSignIncorrect;
        public By GetAlertInvalidEmailAddress => alertInvalidEmailAddress;

        public By GetMessageSuccess => messageSuccess;

    }
}
