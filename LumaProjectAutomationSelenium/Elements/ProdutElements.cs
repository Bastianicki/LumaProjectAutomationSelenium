using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.Elements
{
    public class ProductElements
    {
        // main part
        private readonly By addToCartButton = By.Id("product-addtocart-button");
        private readonly By addToWishListButton = By.XPath("//div[@class='product-addto-links']//child::a[@class= 'action towishlist']");
        private readonly By addToCompare = By.XPath("//div[@class='product-addto-links']//child::a[@class='action tocompare']");


        // bottom part
        private readonly By detailsTab = By.Id("tab-label-description-title");

        private readonly By moreInformationTab = By.Id("tab-label-additional-title");

        private readonly By moreInformationTab_Style = By.XPath("//div[@id='additional']//following::td[@data-th='Style']");
        private readonly By moreInformationTab_Material = By.XPath("//div[@id='additional']//following::td[@data-th='Material']");
        private readonly By moreInformationTab_Pattern = By.XPath("//div[@id='additional']//following::td[@data-th='Pattern']");
        private readonly By moreInformationTab_Climate = By.XPath("//div[@id='additional']//following::td[@data-th='Climate']");

        private readonly By reviewsTab = By.Id("tab-label-reviews-title");
        private readonly By rating_1 = By.Id("Rating_1_label");
        private readonly By rating_2 = By.Id("Rating_2_label");
        private readonly By rating_3 = By.Id("Rating_3_label");
        private readonly By rating_4 = By.Id("Rating_4_label");
        private readonly By rating_5 = By.Id("Rating_5_label");
        private readonly By nicknameField = By.Id("nickname_field");
        private readonly By summaryField = By.Id("summary_field");
        private readonly By reviewField = By.Id("review_field");
        private readonly By submitReviewButton = By.XPath("//button[@type='submit' and @class='action submit primary']");
        private readonly By messageAboutSubmittedReview = By.CssSelector("div[data-ui-id='message-success']");

        public By GetDetailsTab => detailsTab;
        public By GetMoreInformationTab => moreInformationTab;
        public By GetMoreInformationTab_Style => moreInformationTab_Style;
        public By GetMoreInformationTab_Material => moreInformationTab_Material;
        public By GetMoreInformationTab_Pattern => moreInformationTab_Pattern;
        public By GetMoreInformationTab_Climate => moreInformationTab_Climate;
        public By GetReviewsTab => reviewsTab;
        public By GetRating_1 => rating_1;
        public By GetRating_2 => rating_2;
        public By GetRating_3 => rating_3;
        public By GetRating_4 => rating_4;
        public By GetRating_5 => rating_5;
        public By GetNicknameField => nicknameField;
        public By GetSummaryField => summaryField;
        public By GetReviewField => reviewField;
        public By GetSubmitReviewButton => submitReviewButton;
        public By GetMessageAboutSubmittedReview => messageAboutSubmittedReview;
    }
}
