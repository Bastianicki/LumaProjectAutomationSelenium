using LumaProjectAutomationSelenium.Elements;
using LumaProjectAutomationSelenium.Enums;
using LumaProjectAutomationSelenium.TestData;
using LumaProjectAutomationSelenium.WaitHelpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.Pages
{
    public class ProductPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly ProductElements elements;
        private readonly Actions actions;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            actions = new Actions(driver);
            elements = new ProductElements();
            wait = Wait.GetFluentWait(driver, 10);
        }





        public IWebElement GetDetailsTab => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetDetailsTab));
        public IWebElement GetMoreInformationTab => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetMoreInformationTab));
        public IWebElement GetReviewsTab => wait.Until(ExpectedConditions.ElementToBeClickable(elements.GetReviewsTab));
        public IWebElement MoreInformationTab_Style => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetMoreInformationTab_Style));
        public IWebElement MoreInformationTab_Material => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetMoreInformationTab_Material));
        public IWebElement MoreInformationTab_Pattern => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetMoreInformationTab_Pattern));
        public IWebElement MoreInformationTab_Climate => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetMoreInformationTab_Climate));
        public IWebElement NickName => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetNicknameField));
        public IWebElement Summary => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetSummaryField));
        public IWebElement Review => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetReviewField));
        public IWebElement SubmitReviewButton => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetSubmitReviewButton));
        public IWebElement MessageAboutSubmittedReview => wait.Until(ExpectedConditions.ElementIsVisible(elements.GetMessageAboutSubmittedReview));


        public ProductPage ClickOnDetailsTab()
        {
            GetDetailsTab.Click();
            return this;
        }
        public ProductPage ClickOnMoreInformationTab()
        {
            GetMoreInformationTab.Click();
            return this;
        }
        public ProductPage ClickOnReviewsTab()
        {
            GetReviewsTab.Click();
            return this;
        }

        public ProductPage SelectStarRating(StarRating starRating)
        {

            By by = GetStarRating(starRating);
            //wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();

            IWebElement elementToClick = wait.Until(ExpectedConditions.ElementToBeClickable(by));

            int xOffset = 50;
            actions.MoveToElement(elementToClick, xOffset, 0).Click().Perform();

            //actions.MoveToElement(elementToClick).Click().Perform();
            return this;
        }

        public By GetStarRating(StarRating starRating)
        {
            switch (starRating)
            {
                case StarRating.OneStar:
                    return elements.GetRating_1;
                case StarRating.TwoStar:
                    return elements.GetRating_2;
                case StarRating.ThreeStar:
                    return elements.GetRating_3;
                case StarRating.FourStar:
                    return elements.GetRating_4;
                case StarRating.FiveStar:
                    return elements.GetRating_5;
                default:
                    throw new ArgumentException($"Invalid star rating: {starRating}");
            }
        }

        public ProductPage FillNickNameField(string nickName)
        {
            NickName.SendKeys(nickName);
            return this;
        }

        public ProductPage FillNickNameField()
        {
            return FillNickNameField(RandomData.GenerateRandomFirstName());
        }

        public ProductPage FillSummaryField(string summary = "Opinion about the product")
        {
            Summary.SendKeys(summary);
            return this;
        }

        public ProductPage FillReviewField(string review)
        {
            Review.SendKeys(review);
            return this;
        }

        public ProductPage FillReviewField()
        {
            return FillReviewField(RandomData.GenerateRandomReview());
        }

        public ProductPage ClickOnSubmitReview()
        {
            SubmitReviewButton.Click();
            return this;
        }
    }
}
