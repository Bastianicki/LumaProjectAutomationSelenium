using LumaProjectAutomationSelenium.Elements;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumaProjectAutomationSelenium.TestData;
using LumaProjectAutomationSelenium.WaitHelpers;

namespace LumaProjectAutomationSelenium.Pages
{
    public class CreateAccountPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly CreateAccountElements elements;

        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            elements = new CreateAccountElements();
            wait = Wait.GetFluentWait(driver, 10);
        }

        public IWebElement FirstNameField => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetFirstNameField));
        public IWebElement LastNameField => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetLastNameField));
        public IWebElement SignUpForNewsLetterCheckbox => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetSignUpForNewsLetterCheckbox));
        public IWebElement EmailField => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetEmailField));
        public IWebElement PasswordField => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetPasswordField));
        public IWebElement ConfirmPasswordField => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetConfirmPasswordField));
        public IWebElement CreateAnAccountButton => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetCreateAnAccountButton));

        public CreateAccountPage FillFirstNameField(string firstName)
        {
            FirstNameField.SendKeys(firstName);
            return this;
        }

        public CreateAccountPage FillFirstNameField()
        {
            return FillFirstNameField(RandomData.GenerateRandomFirstName());
        }

        public CreateAccountPage FillLastNameField(string lastName)
        {
            LastNameField.SendKeys(lastName);
            return this;
        }

        public CreateAccountPage FillLastNameField()
        {
            return FillFirstNameField(RandomData.GenerateRandomLastName());
        }

        public CreateAccountPage ToggleSignUpForNewsLetterCheckbox(bool shouldClick)
        {
            if (shouldClick)
            {
                SignUpForNewsLetterCheckbox.Click();
            }
            return this;
        }

        public CreateAccountPage FillEmailField(string email)
        {
            EmailField.SendKeys(email);
            return this;
        }

        public CreateAccountPage FillEmailField()
        {
            return FillEmailField(RandomData.GenerateRandomEmailAddress());
        }

        public CreateAccountPage FillBothPasswordFields(string password)
        {
            PasswordField.SendKeys(password);
            ConfirmPasswordField.SendKeys(password);
            return this;
        }

        public CreateAccountPage FillBothPasswordFields()
        {
            return FillBothPasswordFields(RandomData.GenerateRandomPassword(10));
        }

        public CreateAccountPage ClickOnCreateAnAccountButton()
        {
            CreateAnAccountButton.Click();
            return this;
        }
    }
}