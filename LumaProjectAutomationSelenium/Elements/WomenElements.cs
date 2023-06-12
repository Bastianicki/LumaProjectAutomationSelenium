using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.Elements
{
    public class WomenElements
    {
        // CATEGORY
        private readonly By Tops = By.XPath("//dl[@id='narrow-by-list2']//child::a[contains(text(),'Tops')]");
        private readonly By Bottoms = By.XPath("//dl[@id='narrow-by-list2']//child::a[contains(text(),'Tops')]");
        public By GetTops => Tops;
        public By GetBottoms => Bottoms;

        // CATEGORY (Shopping Options)
        private readonly By CategoryFilter = By.XPath("//div[@class='filter-options-title' and text()='MainCategory']");
        private readonly By Jackets = By.XPath("//div[@class='filter-options-title' and text()='MainCategory']//following::a[contains(text(),'Jackets')]");
        private readonly By HoodiesAndSweatshirts = By.XPath("//div[@class='categories-menu']//child::strong[1]//following::li[1]");
        private readonly By Tees = By.XPath("//div[@class='categories-menu']//child::strong[1]//following::li[3]");
        private readonly By BrasAndTanks = By.XPath("//div[@class='categories-menu']//child::strong[1]//following::li[4]");
        public By GetCategoryFilter => CategoryFilter;
        public By GetJackets => Jackets;
        public By GetHoodiesAndSweatshirts => HoodiesAndSweatshirts;
        public By GetTees => Tees;
        public By GetBrasAndTanks => BrasAndTanks;

        // STYLE (Shopping Options)
        private readonly By StyleFilter = By.XPath("//div[@class='filter-options-title' and text()='Style']");
        private readonly By Insulated = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Insulated')]");
        private readonly By Jacket = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Jacket')]");
        private readonly By Lightweight = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Lightweight')]");
        private readonly By Hooded = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Hooded')]");
        private readonly By HeavyDuty = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Heavy Duty')]");
        private readonly By RainCoat = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Rain Coat')]");
        private readonly By HardShell = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Hard Shell')]");
        private readonly By SoftShell = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Soft Shell')]");
        private readonly By Windbreaker = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Windbreaker')]");
        private readonly By QuarterZip = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'¼ zip')]");
        private readonly By FullZip = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Full Zip')]");
        private readonly By Reversible = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Reversible')]");
        private readonly By Bra = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Bra')]");
        private readonly By Sweatshirt = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Sweatshirt')]");
        private readonly By Tank = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Tank')]");
        private readonly By Tee = By.XPath("///div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Tee')]");
        private readonly By Pullover = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Pullover')]");
        private readonly By Hoodie = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Hoodie')]");
        private readonly By Camisole = By.XPath("//div[@class='filter-options-title' and text()='Style']//following::a[contains(text(),'Camisole')]");

        public By GetStyleFilter => StyleFilter;
        public By GetInsulated => Insulated;
        public By GetJacket => Jacket;
        public By GetLightweight => Lightweight;
        public By GetHooded => Hooded;
        public By GetHeavyDuty => HeavyDuty;
        public By GetRainCoat => RainCoat;
        public By GetHardShell => HardShell;
        public By GetSoftShell => SoftShell;
        public By GetWindbreaker => Windbreaker;
        public By GetQuarterZip => QuarterZip;
        public By GetFullZip => FullZip;
        public By GetReversible => Reversible;
        public By GetBra => Bra;
        public By GetSweatshirt => Sweatshirt;
        public By GetTank => Tank;
        public By GetTee => Tee;
        public By GetPullover => Pullover;
        public By GetHoodie => Hoodie;
        public By GetCamisole => Camisole;

        // SIZE
        private readonly By sizeFilter = By.XPath("//div[@class='filter-options-title' and text()='Size']");
        private readonly By XS = By.XPath("//div[@class='filter-options-title' and text()='Size']//following::div[contains(text(),'XS')]");
        private readonly By S = By.XPath("//div[@class='filter-options-title' and text()='Size']//following::div[contains(text(),'XS')]");
        private readonly By M = By.XPath("//div[@class='filter-options-title' and text()='Size']//following::div[contains(text(),'XS')]");
        private readonly By L = By.XPath("//div[@class='filter-options-title' and text()='Size']//following::div[contains(text(),'XS')]");
        private readonly By XL = By.XPath("//div[@class='filter-options-title' and text()='Size']//following::div[contains(text(),'XS')]");
        public By GetSizeFilter => sizeFilter;
        public By GetXS => XS;
        public By GetS => S;
        public By GetM => M;
        public By GetL => L;
        public By GetXL => XL;

        // PRICE
        private readonly By priceFilter = By.XPath("//div[@class='filter-options-title' and text()='Price']");
        private readonly By betweenTwentyAndTwentyNine = By.XPath("//div[@class='filter-options-title' and text()='Price']//following::span[contains(text(),'$20.00')]");
        private readonly By betweenThirtyAndThirtyNine = By.XPath("//div[@class='filter-options-title' and text()='Price']//following::span[contains(text(),'$30.00')]");
        private readonly By betweenFortyAndFortyNine = By.XPath("//div[@class='filter-options-title' and text()='Price']//following::span[contains(text(),'$40.00')]");
        private readonly By betweenFiftyAndFiftyNine = By.XPath("//div[@class='filter-options-title' and text()='Price']//following::span[contains(text(),'$50.00')]");
        private readonly By betweenSixtyAndSixtyNine = By.XPath("//div[@class='filter-options-title' and text()='Price']//following::span[contains(text(),'$60.00')]");
        private readonly By betweenSeventyAndSeventyNine = By.XPath("//div[@class='filter-options-title' and text()='Price']//following::span[contains(text(),'$70.00')]");
        private readonly By betweenEightyAndAbove = By.XPath("//div[@class='filter-options-title' and text()='Price']//following::span[contains(text(),'$80.00')]");

        public By GetPriceFiler => priceFilter;
        public By GetBetweenTwentyAndTwentyNine => betweenTwentyAndTwentyNine;
        public By GetBetweenThirtyAndThirtyNine => betweenThirtyAndThirtyNine;
        public By GetBetweenFortyAndFortyNine => betweenFortyAndFortyNine;
        public By GetBetweenFiftyAndFiftyNine => betweenFiftyAndFiftyNine;
        public By GetBetweenSixtyAndSixtyNine => betweenSixtyAndSixtyNine;
        public By GetetweenSeventyAndSeventyNine => betweenSeventyAndSeventyNine;
        public By GetBetweenEightyAndAbove => betweenEightyAndAbove;

        // COLOR
        private readonly By colorFilter = By.XPath("//div[@class='filter-options-title' and text()='Color']");
        private readonly By black = By.XPath("//div[@class='filter-options-title' and text()='Color']//following::a[@aria-label='Black']");
        private readonly By blue = By.XPath("//div[@class='filter-options-title' and text()='Color']//following::a[@aria-label='Blue']");
        private readonly By brown = By.XPath("//div[@class='filter-options-title' and text()='Color']//following::a[@aria-label='Brown']");
        private readonly By gray = By.XPath("//div[@class='filter-options-title' and text()='Color']//following::a[@aria-label='Gray']");
        private readonly By green = By.XPath("//div[@class='filter-options-title' and text()='Color']//following::a[@aria-label='Green']");
        private readonly By orange = By.XPath("//div[@class='filter-options-title' and text()='Color']//following::a[@aria-label='Orange']");
        private readonly By purple = By.XPath("//div[@class='filter-options-title' and text()='Color']//following::a[@aria-label='Purple']");
        private readonly By red = By.XPath("//div[@class='filter-options-title' and text()='Color']//following::a[@aria-label='Red']");
        private readonly By white = By.XPath("//div[@class='filter-options-title' and text()='Color']//following::a[@aria-label='White']");
        private readonly By yellow = By.XPath("//div[@class='filter-options-title' and text()='Color']//following::a[@aria-label='Yellow']");

        public By GetColorFilter => colorFilter;
        public By GetBlack => black;
        public By GetBlue => blue;
        public By GetBrown => brown;
        public By GetGray => gray;
        public By GetGreen => green;
        public By GetOrange => orange;
        public By GetPurple => purple;
        public By GetRed => red;
        public By GetWhite => white;
        public By GetYellow => yellow;

        // MATERIAL
        private readonly By materialFilter = By.XPath("//div[@class='filter-options-title' and text()='Material']");
        private readonly By coconaPerformanceFabric = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Cocona® performance fabric')]");
        private readonly By cotton = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Cotton')][1]");
        private readonly By fleece = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Fleece')]");
        private readonly By hemp = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Hemp')]");
        private readonly By jersey = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Jersey')]");
        private readonly By lumaTech = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'LumaTech™')]");
        private readonly By mesh = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Mesh')]");
        private readonly By lycra = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Lycra®')]");
        private readonly By nylon = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Nylon')]");
        private readonly By microfiber = By.XPath("///div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Microfiber')]");
        private readonly By polyester = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Polyester')]");
        private readonly By spandex = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Spandex')]");
        private readonly By heatTec = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'HeatTec®')]");
        private readonly By everCool = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'EverCool™')]");
        private readonly By organicCotton = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Organic Cotton')]");
        private readonly By tencel = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'TENCEL')]");
        private readonly By coolTech = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'CoolTech™')]");
        private readonly By wool = By.XPath("//div[@class='filter-options-title' and text()='Material']//following::a[contains(text(), 'Wool')]");

        public By GetMaterialFilter => materialFilter;
        public By GetCoconaPerformanceFabric => coconaPerformanceFabric;
        public By GetCotton => cotton;
        public By GetFleece => fleece;
        public By GetHemp => hemp;
        public By GetJersey => jersey;
        public By GetLumaTech => lumaTech;
        public By GetMesh => mesh;
        public By GetLycra => lycra;
        public By GetNylon => nylon;
        public By GetMicrofiber => microfiber;
        public By GetPolyester => polyester;
        public By GetSpandex => spandex;
        public By GetHeatTec => heatTec;
        public By GetEverCool => everCool;
        public By GetOrganicCotton => organicCotton;
        public By GetTencel => tencel;
        public By GetCoolTech => coolTech;
        public By GetWool => wool;

        // ECO COLLECTION
        private readonly By ecoCollectionFilter = By.XPath("//div[@class='filter-options-title' and text()='Eco Collection']");

        private readonly By ecoCollection_Yes = By.XPath("///div[@class='filter-options-title' and text()='Eco Collection']//following::div[1]//child::a[contains(text(), 'Yes')]");
        private readonly By ecoCollection_No = By.XPath("//div[@class='filter-options-title' and text()='Eco Collection']//following::div[1]//child::a[contains(text(), 'No')]");
        public By GetEcoCollectionFilter => ecoCollectionFilter;
        public By GetEcoCollection_Yes => ecoCollection_Yes;
        public By GetEcoCollection_No => ecoCollection_No;

        // PERFORMANCE FABRIC
        private readonly By performanceFabricFilter = By.XPath("//div[@class='filter-options-title' and text()='Performance Fabric']");

        private readonly By getPerformanceFabric_Yes = By.XPath("//div[@class='filter-options-title' and text()='Performance Fabric']//following::div[1]//child::a[contains(text(), 'Yes')]");
        private readonly By getPerformanceFabric_No = By.XPath("//div[@class='filter-options-title' and text()='Performance Fabric']//following::div[1]//child::a[contains(text(), 'No')]");

        public By GetPerformanceFabricFilter => performanceFabricFilter;
        public By GetPerformanceFabric_Yes => getPerformanceFabric_Yes;
        public By GetPerformanceFabric_No => getPerformanceFabric_No;

        // ERIN RECOMMENTS
        private readonly By erinRecommendsFilter = By.XPath("//div[@class='filter-options-title' and text()='Erin Recommends']");

        private readonly By erinRecommends_Yes = By.XPath("//div[@class='filter-options-title' and text()='Erin Recommends']//following::div[1]//child::a[contains(text(), 'Yes')]");
        private readonly By erinRecommends_No = By.XPath("//div[@class='filter-options-title' and text()='Erin Recommends']//following::div[1]//child::a[contains(text(), 'No')]");

        public By GetErinRecommendsFilter => erinRecommendsFilter;
        public By GetErinRecommends_Yes => erinRecommends_Yes;
        public By GetErinRecommends_No => erinRecommends_No;

        // NEW
        private readonly By newFilter = By.XPath("//div[@class='filter-options-title' and text()='New']");
        private readonly By getNew_Yes = By.XPath("//div[@class='filter-options-title' and text()='New']//following::div[1]//child::a[contains(text(), 'Yes')]");
        private readonly By getNew_No = By.XPath("//div[@class='filter-options-title' and text()='New']//following::div[1]//child::a[contains(text(), 'No')]");

        public By GetNewFilter => newFilter;
        public By GetNew_Yes => getNew_Yes;
        public By GetNew_No => getNew_No;

        // SALE
        private readonly By saleFilter = By.XPath("//div[@class='filter-options-title' and text()='Sale']");
        private readonly By sale_Yes = By.XPath("//div[@class='filter-options-title' and text()='Sale']//following::div[1]//child::a[contains(text(), 'Yes')]");
        private readonly By sale_No = By.XPath("//div[@class='filter-options-title' and text()='Sale']//following::div[1]//child::a[contains(text(), 'No')]");

        public By GetSaleFilter => saleFilter;
        public By GetSale_Yes => sale_Yes;
        public By GetSale_No => sale_No;

        // PATTERN
        private readonly By patternFilter = By.XPath("//div[@class='filter-options-title' and text()='Pattern']");
        private readonly By checkedPatern = By.XPath("//div[@class='filter-options-title' and text()='Pattern']//following::a[contains(text(), 'Checked')]");
        private readonly By colorBlocked = By.XPath("//div[@class='filter-options-title' and text()='Pattern']//following::a[contains(text(), 'Color-Blocked')]");
        private readonly By solid = By.XPath("//div[@class='filter-options-title' and text()='Pattern']//following::a[contains(text(), 'Solid')]");
        private readonly By striped = By.XPath("//div[@class='filter-options-title' and text()='Pattern']//following::a[contains(text(), 'Striped')]");

        public By GetPatternFilter => patternFilter;
        public By GetCheckedPatern => checkedPatern;
        public By GetColorBlocked => colorBlocked;
        public By GetSolid => solid;
        public By GetStriped => striped;

        // CLIMATE
        private readonly By climateFilter = By.XPath("//div[@class='filter-options-title' and text()='Climate']");
        private readonly By allWheather = By.XPath("//div[@class='filter-options-title' and text()='Climate']//following::a[contains(text(), 'All-Weather')]");
        private readonly By cold = By.XPath("//div[@class='filter-options-title' and text()='Climate']//following::a[contains(text(), 'Cold')]");
        private readonly By cool = By.XPath("//div[@class='filter-options-title' and text()='Climate']//following::a[contains(text(), 'Cool')]");
        private readonly By indoor = By.XPath("//div[@class='filter-options-title' and text()='Climate']//following::a[contains(text(), 'Indoor')]");
        private readonly By mild = By.XPath("//div[@class='filter-options-title' and text()='Pattern']//following::a[contains(text(), 'Checked')]");
        private readonly By rainy = By.XPath("//div[@class='filter-options-title' and text()='Climate']//following::a[contains(text(), 'Mild')]");
        private readonly By spring = By.XPath("//div[@class='filter-options-title' and text()='Climate']//following::a[contains(text(), 'Spring')]");
        private readonly By warm = By.XPath("//div[@class='filter-options-title' and text()='Climate']//following::a[contains(text(), 'Warm')]");
        private readonly By windy = By.XPath("//div[@class='filter-options-title' and text()='Climate']//following::a[contains(text(), 'Windy')]");
        private readonly By wintry = By.XPath("//div[@class='filter-options-title' and text()='Climate']//following::a[contains(text(), 'Wintry')]");

        public By GetClimateFilter => climateFilter;
        public By GetAllWheather => allWheather;
        public By GetCold => cold;
        public By GetCool => cool;
        public By GetIndoor => indoor;
        public By GetMild => mild;
        public By GetRainy => rainy;
        public By GetSpring => spring;
        public By GetWarm => warm;
        public By GetWindy => windy;
        public By GetWintry => wintry;

    }
}
