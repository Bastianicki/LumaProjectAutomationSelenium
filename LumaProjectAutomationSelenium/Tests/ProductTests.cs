using LumaProjectAutomationSelenium.Enums;
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

namespace LumaProjectAutomationSelenium.Tests
{
    public class ProductTests
    {
        private readonly IWebDriver driver = new ChromeDriver(@"C:\\bin");
        private readonly BrowserUtilities browserUtilities;
        private readonly LoginPage loginPage;
        private readonly MenuBar menuBar;
        private readonly WomenPage womenPage;
        private readonly SearchPage search;
        private readonly ProductPage productPage;

        public ProductTests()
        {
            browserUtilities = new BrowserUtilities(driver);
            loginPage = new LoginPage(driver);
            menuBar = new MenuBar(driver);
            search = new SearchPage(driver);
            productPage = new ProductPage(driver);
            womenPage = new WomenPage(driver);
        }

        [Fact]
        [Trait("Test Case 1", "Review")]
        public void VerifyThatReviewIsSubmittedSuccesfully()
        {
            try
            {
                // Arrange
                browserUtilities
                    .StartBrowser();

                // Act
                menuBar
                    .ClickOnWomenMenuItem();

                womenPage
                    .SelectMainCategory(MainCategory.Tops)
                    .SelectStyleOfTops(StyleOfTops.Pullover);

                search
                    .ClickOnFirstItemFiltered();

                productPage
                    .ClickOnReviewsTab()
                    .SelectStarRating(StarRating.FiveStar)
                    .FillNickNameField()
                    .FillSummaryField()
                    .FillReviewField()
                    .ClickOnSubmitReview();

                // Assert
                string expectedMessage = "You submitted your review for moderation.";
                string actualMessage = productPage.MessageAboutSubmittedReview.Text;
                Assert.Equal(expectedMessage, actualMessage);
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

        [Fact]
        [Trait("Login", "Test Case 2")]
        public void VerifyAddToWishListFunctionality()
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
                    .FillPasswordField(UserData.Password);

                search
                    .SendKeysToSearchField("Breathe-Easy Tank")
                    .ClickOnSearchButton()
                    .ClickOnFirstItemFiltered();
                // in progress

                // Assert
                // in progress

            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }
    }
}
