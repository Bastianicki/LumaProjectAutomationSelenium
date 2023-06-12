using LumaProjectAutomationSelenium.Elements;
using LumaProjectAutomationSelenium.TestData;
using LumaProjectAutomationSelenium.WaitHelpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly LoginElements elements;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            elements = new LoginElements();
            wait = Wait.GetFluentWait(driver, 10);
        }

        public IWebElement EmailField => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetEmailField));
        public IWebElement PasswordField => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetPasswordField));
        public IWebElement GetSignInButton => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetSignInButton));
        public IWebElement GetCreateAnAccountButton => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetCreateAnAccountbutton));

        public LoginPage FillEmailField(string email)
        {
            EmailField.SendKeys(email);
            return this;
        }

        public LoginPage FillEmailField()
        {
            return FillEmailField(UserData.EmailAdress);
        }

        public LoginPage FillPasswordField(string password)
        {
            PasswordField.SendKeys(password);
            return this;
        }
        public LoginPage FillPasswordField()
        {
            return FillPasswordField(UserData.Password);
        }

        public LoginPage ClickOnSignInButton()
        {
            GetSignInButton.Click();
            return this;
        }

        public LoginPage ClickOnCreateAnAccountButton()
        {
            GetCreateAnAccountButton.Click();
            return this;
        }
    }
}
