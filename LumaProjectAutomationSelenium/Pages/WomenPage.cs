using LumaProjectAutomationSelenium.Elements;
using LumaProjectAutomationSelenium.Enums;
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
    public class WomenPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly WomenElements womenElements;

        public WomenPage(IWebDriver driver)
        {
            this.driver = driver;
            womenElements = new WomenElements();
            wait = Wait.GetFluentWait(driver, 10);
        }

        // CATEGORY
        public WomenPage SelectMainCategory(MainCategory category)
        {
            By by = GetMainCategory(category);
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetMainCategory(MainCategory category)
        {
            switch (category)
            {
                case MainCategory.Tops:
                    return womenElements.GetTops;
                case MainCategory.Bottoms:
                    return womenElements.GetBottoms;
                default:
                    throw new ArgumentException($"Invalid category: {category}");
            }
        }

        // CATEGORY (Shopping Options)
        public WomenPage SelectCategoryOfTops(CategoryOfTops categoryOfTops)
        {
            By by = GetCategoryOfTops(categoryOfTops);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetCategoryFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetCategoryOfTops(CategoryOfTops categoryOfTops)
        {
            switch (categoryOfTops)
            {
                case CategoryOfTops.Jackets:
                    return womenElements.GetJackets;
                case CategoryOfTops.HoodiesAndSweatshirts:
                    return womenElements.GetHoodiesAndSweatshirts;
                case CategoryOfTops.Tees:
                    return womenElements.GetTees;
                case CategoryOfTops.BrasAndTanks:
                    return womenElements.GetBrasAndTanks;
                default:
                    throw new ArgumentException($"Invalid category: {categoryOfTops}");
            }
        }

        // STYLE (Shopping Options)
        public WomenPage SelectStyleOfTops(StyleOfTops styleOfTops)
        {
            By by = GetStyleOfTops(styleOfTops);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetStyleFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetStyleOfTops(StyleOfTops styleOfTops)
        {
            switch (styleOfTops)
            {
                case StyleOfTops.Insulated:
                    return womenElements.GetInsulated;
                case StyleOfTops.Jacket:
                    return womenElements.GetJacket;
                case StyleOfTops.Lightweight:
                    return womenElements.GetLightweight;
                case StyleOfTops.Hooded:
                    return womenElements.GetHooded;
                case StyleOfTops.HeavyDuty:
                    return womenElements.GetHeavyDuty;
                case StyleOfTops.RainCoat:
                    return womenElements.GetRainCoat;
                case StyleOfTops.HardShell:
                    return womenElements.GetHardShell;
                case StyleOfTops.SoftShell:
                    return womenElements.GetSoftShell;
                case StyleOfTops.Windbreaker:
                    return womenElements.GetWindbreaker;
                case StyleOfTops.QuarterZip:
                    return womenElements.GetQuarterZip;
                case StyleOfTops.FullZip:
                    return womenElements.GetFullZip;
                case StyleOfTops.Reversible:
                    return womenElements.GetReversible;
                case StyleOfTops.Bra:
                    return womenElements.GetBra;
                case StyleOfTops.Sweatshirt:
                    return womenElements.GetSweatshirt;
                case StyleOfTops.Tank:
                    return womenElements.GetTank;
                case StyleOfTops.Tee:
                    return womenElements.GetTee;
                case StyleOfTops.Pullover:
                    return womenElements.GetPullover;
                case StyleOfTops.Hoodie:
                    return womenElements.GetHoodie;
                case StyleOfTops.Camisole:
                    return womenElements.GetCamisole;
                default:
                    throw new ArgumentException($"Invalid category: {styleOfTops}");
            };
        }

        //SIZE (Shopping Options)
        public WomenPage SelectSizeOfTops(SizeOfTops sizeOfTops)
        {
            By by = GetSizeOfTops(sizeOfTops);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetSizeFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetSizeOfTops(SizeOfTops sizeOfTops)
        {
            switch (sizeOfTops)
            {
                case SizeOfTops.XS:
                    return womenElements.GetXS;
                case SizeOfTops.S:
                    return womenElements.GetS;
                case SizeOfTops.M:
                    return womenElements.GetM;
                case SizeOfTops.L:
                    return womenElements.GetL;
                case SizeOfTops.XL:
                    return womenElements.GetXL;
                default:
                    throw new ArgumentException($"Invalid category: {sizeOfTops}");
            };
        }

        // PRICE
        public WomenPage SelectPriceOfTops(PriceOfTops priceOfTops)
        {
            By by = GetPriceOfTops(priceOfTops);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetPriceFiler)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetPriceOfTops(PriceOfTops priceOfTops)
        {
            switch (priceOfTops)
            {
                case PriceOfTops.BetweenTwentyAndTwentyNine:
                    return womenElements.GetBetweenTwentyAndTwentyNine;
                case PriceOfTops.BetweenThirtyAndThirtyNine:
                    return womenElements.GetBetweenThirtyAndThirtyNine;
                case PriceOfTops.BetweenFortyAndFortyNine:
                    return womenElements.GetBetweenFortyAndFortyNine;
                case PriceOfTops.BetweenFiftyAndFiftyNine:
                    return womenElements.GetBetweenFiftyAndFiftyNine;
                case PriceOfTops.BetweenSixtyAndSixtyNine:
                    return womenElements.GetBetweenSixtyAndSixtyNine;
                case PriceOfTops.BetweenSeventyAndSeventyNine:
                    return womenElements.GetetweenSeventyAndSeventyNine;
                case PriceOfTops.BetweenEightyAndAbove:
                default:
                    throw new ArgumentException($"Invalid category: {priceOfTops}");
            };
        }

        // COLOR
        public WomenPage SelectColorOfTops(Enums.Color colorOfTops)
        {
            By by = GetColorOfTops(colorOfTops);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetColorFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetColorOfTops(Enums.Color colorOfTops)
        {
            switch (colorOfTops)
            {
                case Enums.Color.Black:
                    return womenElements.GetBlack;
                case Enums.Color.Blue:
                    return womenElements.GetBlue;
                case Enums.Color.Brown:
                    return womenElements.GetBrown;
                case Enums.Color.Gray:
                    return womenElements.GetGray;
                case Enums.Color.Green:
                    return womenElements.GetGreen;
                case Enums.Color.Orange:
                    return womenElements.GetOrange;
                case Enums.Color.Purple:
                    return womenElements.GetPurple;
                case Enums.Color.Red:
                    return womenElements.GetRed;
                case Enums.Color.White:
                    return womenElements.GetWhite;
                case Enums.Color.Yellow:
                    return womenElements.GetYellow;
                default:
                    throw new ArgumentException($"Invalid category: {colorOfTops}");
            };
        }

        // MATERIAL
        public WomenPage SelectMaterialOfTops(MaterialOfTops materialOfTops)
        {
            By by = GetMaterialOfTops(materialOfTops);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetMaterialFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetMaterialOfTops(MaterialOfTops materialOfTops)
        {
            switch (materialOfTops)
            {
                case MaterialOfTops.CoconaPerformanceFabric:
                    return womenElements.GetCoconaPerformanceFabric;
                case MaterialOfTops.Cotton:
                    return womenElements.GetCotton;
                case MaterialOfTops.Fleece:
                    return womenElements.GetFleece;
                case MaterialOfTops.Hemp:
                    return womenElements.GetHemp;
                case MaterialOfTops.Jersey:
                    return womenElements.GetJersey;
                case MaterialOfTops.LumaTech:
                    return womenElements.GetLumaTech;
                case MaterialOfTops.Mesh:
                    return womenElements.GetMesh;
                case MaterialOfTops.Lycra:
                    return womenElements.GetLycra;
                case MaterialOfTops.Nylon:
                    return womenElements.GetNylon;
                case MaterialOfTops.Microfiber:
                    return womenElements.GetMicrofiber;
                case MaterialOfTops.Polyester:
                    return womenElements.GetPolyester;
                case MaterialOfTops.Spandex:
                    return womenElements.GetSpandex;
                case MaterialOfTops.HeatTec:
                    return womenElements.GetHeatTec;
                case MaterialOfTops.EverCool:
                    return womenElements.GetEverCool;
                case MaterialOfTops.OrganicCotton:
                    return womenElements.GetOrganicCotton;
                case MaterialOfTops.Tencel:
                    return womenElements.GetTencel;
                case MaterialOfTops.CoolTech:
                    return womenElements.GetCoolTech;
                case MaterialOfTops.Wool:
                    return womenElements.GetWool;
                default:
                    throw new ArgumentException($"Invalid category: {materialOfTops}");
            };
        }

        // ECO COLLECTION
        public WomenPage SelectEcoCollection(Answer answer)
        {
            By by = GetEcoCollection(answer);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetEcoCollectionFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetEcoCollection(Answer answer)
        {
            switch (answer)
            {
                case Answer.Yes:
                    return womenElements.GetEcoCollection_Yes;
                case Answer.No:
                    return womenElements.GetEcoCollection_No;
                default:
                    throw new ArgumentException($"Invalid category: {answer}");
            };
        }

        // PERFORMANCE FABRIC
        public WomenPage SelectPerformanceFabric(Answer answer)
        {
            By by = GetPerformanceFabric(answer);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetPerformanceFabricFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }
        public By GetPerformanceFabric(Answer answer)
        {
            switch (answer)
            {
                case Answer.Yes:
                    return womenElements.GetPerformanceFabric_Yes;
                case Answer.No:
                    return womenElements.GetPerformanceFabric_No;
                default:
                    throw new ArgumentException($"Invalid category: {answer}");
            };
        }

        // ERIN RECOMMENTS
        public WomenPage SelectErinRecommends(Answer answer)
        {
            By by = GetErinRecommends(answer);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetErinRecommendsFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }
        public By GetErinRecommends(Answer answer)
        {
            switch (answer)
            {
                case Answer.Yes:
                    return womenElements.GetErinRecommends_Yes;
                case Answer.No:
                    return womenElements.GetErinRecommends_No;
                default:
                    throw new ArgumentException($"Invalid category: {answer}");
            };
        }

        // NEW
        public WomenPage SelectNew(Answer answer)
        {
            By by = GetNew(answer);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetNewFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }
        public By GetNew(Answer answer)
        {
            switch (answer)
            {
                case Answer.Yes:
                    return womenElements.GetNew_Yes;
                case Answer.No:
                    return womenElements.GetNew_No;
                default:
                    throw new ArgumentException($"Invalid category: {answer}");
            };
        }

        // SALE
        public WomenPage SelectSale(Answer answer)
        {
            By by = GetSale(answer);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetSaleFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetSale(Answer answer)
        {
            switch (answer)
            {
                case Answer.Yes:
                    return womenElements.GetSale_Yes;
                case Answer.No:
                    return womenElements.GetSale_No;
                default:
                    throw new ArgumentException($"Invalid category: {answer}");
            };
        }

        // PATTERN
        public WomenPage SelectPatternOfTops(Pattern pattern)
        {
            By by = GetPatternOfTops(pattern);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetPatternFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetPatternOfTops(Pattern pattern)
        {
            switch (pattern)
            {
                case Pattern.CheckedPatern:
                    return womenElements.GetCheckedPatern;
                case Pattern.ColorBlocked:
                    return womenElements.GetColorBlocked;
                case Pattern.Solid:
                    return womenElements.GetSolid;
                case Pattern.Striped:
                    return womenElements.GetStriped;
                default:
                    throw new ArgumentException($"Invalid category: {pattern}");
            };
        }

        // CLIMATE
        public WomenPage SelectClimateOfTops(Climate climate)
        {
            By by = GetClimateOfTops(climate);
            wait.Until(ExpectedConditions.ElementToBeClickable(womenElements.GetClimateFilter)).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(by)).Click();
            return this;
        }

        public By GetClimateOfTops(Climate climate)
        {
            switch (climate)
            {
                case Climate.AllWheather:
                    return womenElements.GetAllWheather;
                case Climate.Cold:
                    return womenElements.GetCold;
                case Climate.Cool:
                    return womenElements.GetCool;
                case Climate.Indoor:
                    return womenElements.GetIndoor;
                case Climate.Mild:
                    return womenElements.GetMild;
                case Climate.Rainy:
                    return womenElements.GetRainy;
                case Climate.Spring:
                    return womenElements.GetSpring;
                case Climate.Warm:
                    return womenElements.GetWarm;
                case Climate.Windy:
                    return womenElements.GetWindy;
                case Climate.Wintry:
                    return womenElements.GetWintry;
                default:
                    throw new ArgumentException($"Invalid category: {climate}");
            };
        }
    }
}
