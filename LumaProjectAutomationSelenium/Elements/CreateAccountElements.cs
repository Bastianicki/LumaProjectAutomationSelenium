using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.Elements
{

    public class CreateAccountElements
    {
        private readonly By firstNameField = By.Id("firstname");
        private readonly By lastNameField = By.Id("lastname");
        private readonly By signUpForNewsLetterCheckbox = By.Id("is_subscribed");
        private readonly By emailField = By.Id("email_address");
        private readonly By passwordField = By.Id("password");
        private readonly By confirmPasswordField = By.Id("password-confirmation");
        private readonly By createAnAccountButton = By.CssSelector("button[title='Create an Account']");

        public By GetFirstNameField => firstNameField;

        public By GetLastNameField => lastNameField;

        public By GetSignUpForNewsLetterCheckbox => signUpForNewsLetterCheckbox;

        public By GetEmailField => emailField;

        public By GetPasswordField => passwordField;

        public By GetConfirmPasswordField => confirmPasswordField;

        public By GetCreateAnAccountButton => createAnAccountButton;
    }
}
