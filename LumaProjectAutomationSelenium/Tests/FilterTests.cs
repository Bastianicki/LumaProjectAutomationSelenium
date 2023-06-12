using LumaProjectAutomationSelenium.Enums;
using LumaProjectAutomationSelenium.Pages;
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
    public class FilterTests
    {
        private readonly IWebDriver driver = new ChromeDriver(@"C:\\bin");
        private readonly BrowserUtilities browserUtilities;
        private readonly MenuBar menuBar;
        private readonly SearchPage search;
        private readonly WomenPage womenPage;
        private readonly ProductPage productPage;
        private readonly Delay delay;

        public FilterTests()S
        {
            browserUtilities = new BrowserUtilities(driver);
            menuBar = new MenuBar(driver);
            search = new SearchPage(driver);
            productPage = new ProductPage(driver);
            womenPage = new WomenPage(driver);
            delay = new Delay(driver);
        }

        [Fact]
        [Trait("Test Case 1", "Woman's Style")]
        public void VerifyThatCorrectProductIsFiltered_WomanTops_Style()
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
                    .SelectStyleOfTops(StyleOfTops.QuarterZip);

                search
                    .ClickOnFirstItemFiltered();

                productPage
                    .ClickOnMoreInformationTab();

                // Assert
                string expectedStyle = "¼ zip";
                string actualStyle = productPage.MoreInformationTab_Style.Text;
                Assert.Contains(expectedStyle, actualStyle);
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

        [Fact]
        [Trait("Test Case 2", "Woman's Material")]
        public void VerifyThatCorrectProductIsFiltered_WomanTops_Material()
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
                    .SelectMaterialOfTops(MaterialOfTops.Wool);

                search
                    .ClickOnFirstItemFiltered();

                productPage
                    .ClickOnMoreInformationTab();

                // Assert
                string expectedMaterial = "Wool";
                string verifiedMateria = productPage.MoreInformationTab_Material.Text;
                Assert.Contains(expectedMaterial, verifiedMateria);
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

        [Fact]
        [Trait("Test Case 3", "Woman's Pattern")]
        public void VerifyThatCorrectProductIsFiltered_WomanTops_Pattern()
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
                    .SelectPatternOfTops(Pattern.Striped);

                search
                    .ClickOnFirstItemFiltered();

                productPage
                    .ClickOnMoreInformationTab();

                // Assert
                string expectedPattern = "Wool";
                string verifiedPattern = productPage.MoreInformationTab_Pattern.Text;
                Assert.Contains(expectedPattern, verifiedPattern);
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

        [Fact]
        [Trait("Test Case 4", "Woman's Climate")]
        public void VerifyThatCorrectProductIsFiltered_WomanTops_Climate()
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
                    .SelectClimateOfTops(Climate.Cool);

                search
                    .ClickOnFirstItemFiltered();

                productPage
                    .ClickOnMoreInformationTab();

                // Assert
                string expectedClimate = "Cool";
                string actualClimate = productPage.MoreInformationTab_Climate.Text;
                Assert.Contains(expectedClimate, actualClimate);
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }

        [Fact]
        [Trait("Test Case 5", "Woman's Mix")]
        public void VerifyThatCorrectProductIsFiltered_WomanTops_Mix()
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
                    .SelectStyleOfTops(StyleOfTops.Sweatshirt)
                    .SelectMaterialOfTops(MaterialOfTops.Fleece)
                    .SelectClimateOfTops(Climate.Indoor)
                    .SelectPatternOfTops(Pattern.Solid);

                search
                    .ClickOnFirstItemFiltered();

                productPage
                    .ClickOnMoreInformationTab();

                // Assert
                string expectedStyle = "Sweatshirt";
                string actualStyle = productPage.MoreInformationTab_Style.Text;

                string expectedMaterial = "Fleece";
                string actualMaterial = productPage.MoreInformationTab_Material.Text;

                string expectedClimate = "Indoor";
                string actualClimate = productPage.MoreInformationTab_Climate.Text;

                string expectedPattern = "Solid";
                string actualPattern = productPage.MoreInformationTab_Pattern.Text;

                Assert.Multiple(
                    () => Assert.Contains(expectedStyle, actualStyle),
                    () => Assert.Contains(expectedMaterial, actualMaterial),
                    () => Assert.Contains(expectedClimate, actualClimate),
                    () => Assert.Contains(expectedPattern, actualPattern));
            }
            finally
            {
                browserUtilities
                    .QuitBrowser();
            }
        }
    }
}
