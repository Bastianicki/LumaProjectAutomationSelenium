using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.Elements
{
    public class LoginElements
    {
        private readonly By emailField = By.Id("email");
        private readonly By passwordField = By.Id("pass");
        private readonly By signInButton = By.CssSelector("button[class='action login primary']");
        private readonly By createAnAccountbutton = By.CssSelector("a[class='action create primary']");

        public By GetEmailField => emailField;

        public By GetPasswordField => passwordField;

        public By GetSignInButton => signInButton;

        public By GetCreateAnAccountbutton => createAnAccountbutton;
    }
}

