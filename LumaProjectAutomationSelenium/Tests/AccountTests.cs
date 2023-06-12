using LumaProjectAutomationSelenium.Pages;
using LumaProjectAutomationSelenium.TestData;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using LumaProjectAutomationSelenium.Utilities;
using LumaProjectAutomationSelenium.WaitHelpers;

namespace LumaProjectAutomationSelenium.Tests
{
    public class AccountTests
    {
        private readonly IWebDriver driver = new ChromeDriver(@"C:\\bin");
        private readonly BrowserUtilities browserUtilities;
        private readonly MenuBar menuBar;
        private readonly LoginPage loginPage;
        private readonly CreateAccountPage createAccountPage;
        private readonly AccountPage accountPage;
        private readonly Delay delay;

        public AccountTests()
        {
            browserUtilities = new BrowserUtilities(driver);
            menuBar = new MenuBar(driver);
            loginPage = new LoginPage(driver);
            createAccountPage = new CreateAccountPage(driver);
            accountPage = new AccountPage(driver);
            delay = new Delay(driver);
        }

        [Fact]
        [Trait("Create", "Test Case 1")]
        public void VerifyThatAccountIsCreatedSuccesfully()
        {
            string firstName = RandomData.GenerateRandomFirstName();
            string lastName = RandomData.GenerateRandomLastName();
            string firstAndLastName = firstName + " " + lastName;
            string email = RandomData.GenerateRandomEmailAddress();

            try
            {
                // Arrange
                browserUtilities
                    .StartBrowser();

                // Act
                menuBar
                    .ClickOnSignInButton();

                loginPage
                    .ClickOnCreateAnAccountButton();

                createAccountPage
                    .FillFirstNameField(firstName)
                    .FillLastNameField(lastName)
                    .ToggleSignUpForNewsLetterCheckbox(true)
                    .FillEmailField(email)
                    .FillBothPasswordFields()
                    .ClickOnCreateAnAccountButton();

                // Assert
                string expectedTitle = "My Account";
                string expectedMessage = "Thank you for registering with Main Website Store.";
                string expectedFirstAndLastName = firstAndLastName;
                string expectedEmail = email;

                Assert.Multiple(
                    () => Assert.Equal(expectedTitle, driver.Title),
                    () => Assert.Equal(expectedMessage, accountPage.MessageSuccess.Text),
                    () => Assert.Contains(expectedFirstAndLastName, accountPage.ContactInformation.Text),
                    () => Assert.Contains(expectedEmail, accountPage.ContactInformation.Text));
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }

        }

        [Fact]
        [Trait("Login", "Test Case 2")]
        public void VerifyThatCorrectUserNameAppearsInWelcomingMessageAfterSuccesfullLogin()
        {
            try
            {
                // Arrange
                browserUtilities
                    .StartBrowser();

                // Act
                menuBar
                    .ClickOnSignInButton();

                loginPage
                    .FillEmailField(UserData.EmailAdress)
                    .FillPasswordField(UserData.Password)
                    .ClickOnSignInButton();

                delay
                    .WaitForTextInElement(menuBar.GetWelcomeMessage, "Welcome");

                // Assert
                string expectedTitle = "Home Page";
                string expectedTextInElement = "Welcome, " + UserData.UserName + "!";
                string actualTextInElement = menuBar.GetWelcomeMessageElement.Text;

                Assert.Multiple(
                    () => Assert.Equal(expectedTitle, driver.Title),
                    () => Assert.Equal(expectedTextInElement, actualTextInElement));
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

        [Fact]
        [Trait("Login", "Test Case 3")]
        public void VerifyWhetherApropriateErrorAppearsAfterIncorrectLoginAndPassword()
        {
            try
            {
                // Arrange
                browserUtilities
                    .StartBrowser();

                // Act
                menuBar
                    .ClickOnSignInButton();

                loginPage
                    .FillEmailField(RandomData.GenerateRandomEmailAddress())
                    .FillPasswordField(RandomData.GenerateRandomPassword(15))
                    .ClickOnSignInButton();

                // Assert
                string expectedTitle = "Customer Login";
                string expectedTextInElement = "The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later.";
                string actualTextInElement = accountPage.AlertAccountSignIncorrect.Text;

                Assert.Multiple(
                    () => Assert.Equal(expectedTitle, driver.Title),
                    () => Assert.Equal(expectedTextInElement, actualTextInElement));
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

        [Fact]
        [Trait("Login", "Test Case 4")]
        public void VerifyWhetherApropriateErrorAppearsAfterCorrectLoginAndIncorrectPassword()
        {
            try
            {
                // Arrange
                browserUtilities
                    .StartBrowser();

                // Act
                menuBar
                    .ClickOnSignInButton();

                loginPage
                    .FillEmailField(UserData.UserName)
                    .FillPasswordField(RandomData.GenerateRandomPassword(15))
                    .ClickOnSignInButton();

                // Assert
                string expectedTitle = "Customer Login";
                string expectedTextInElement = "The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later.";
                string actualTextInElement = accountPage.AlertAccountSignIncorrect.Text;

                Assert.Multiple(
                    () => Assert.Equal(expectedTitle, driver.Title),
                    () => Assert.Equal(expectedTextInElement, actualTextInElement));
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

        [Fact]
        [Trait("Login", "Test Case 5")]
        public void VerifyWhetherAppropriateErrorAppearsAfterInvalidEmail()
        {
            try
            {
                // Arrange
                browserUtilities
                    .StartBrowser();

                // Act
                menuBar
                    .ClickOnSignInButton();

                loginPage
                    .FillEmailField(RandomData.GenerateRandomFirstName())
                    .FillPasswordField(RandomData.GenerateRandomPassword(15))
                    .ClickOnSignInButton();

                // Assert
                string expectedTitle = "Customer Login";
                string expectedTextInElement = "Please enter a valid email address (Ex: johndoe@domain.com).";
                string actualTextInElement = accountPage.AlertInvalidEmailAddress.Text;

                Assert.Multiple(
                    () => Assert.Equal(expectedTitle, driver.Title),
                    () => Assert.Equal(expectedTextInElement, actualTextInElement));
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

        [Fact]
        [Trait("Login", "Test Case 6")]
        public void SQLInjectionAttackInLoginAndPasswordFields()
        {
            try
            {
                // Arrange
                browserUtilities
                    .StartBrowser();

                // Act
                menuBar
                    .ClickOnSignInButton();

                loginPage
                    .FillEmailField("SELECT * FROM users WHERE username = 'username' AND password = 'password")
                    .FillPasswordField("SELECT * FROM users WHERE username = 'username' AND password = 'password")
                    .ClickOnSignInButton();

                // Assert
                string expectedTitle = "Customer Login";
                string expectedTextInElement = "Please enter a valid email address (Ex: johndoe@domain.com).";
                string actualTextInElement = accountPage.AlertInvalidEmailAddress.Text;

                Assert.Multiple(
                    () => Assert.Equal(expectedTitle, driver.Title),
                    () => Assert.Equal(expectedTextInElement, actualTextInElement));
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

        [Fact]
        [Trait("Login", "Test Case 7")]
        public void SQLInjectionAttackInPasswordField()
        {
            try
            {
                // Arrange
                browserUtilities
                    .StartBrowser();

                // Act
                menuBar
                    .ClickOnSignInButton();

                loginPage
                    .FillEmailField(UserData.EmailAdress)
                    .FillPasswordField("SELECT * FROM users WHERE username = 'username' AND password = 'password")
                    .ClickOnSignInButton();

                // Assert
                string expectedTitle = "Customer Login";
                string expectedTextInElement = "The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later.";
                string actualTextInElement = accountPage.AlertAccountSignIncorrect.Text;

                Assert.Multiple(
                    () => Assert.Equal(expectedTitle, driver.Title),
                    () => Assert.Equal(expectedTextInElement, actualTextInElement));
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

    }
}

