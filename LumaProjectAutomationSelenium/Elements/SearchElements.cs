using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.Elements
{
    public class SearchElements
    {
        private readonly By searchField = By.Id("search");
        private readonly By searchButton = By.XPath("//button[@type='submit' and @title='Search']");


        private readonly By firstItemFiltered = By.CssSelector("//ol[@class='products list items product-items']//child::li[1]");
        private readonly By secondItemFiltered = By.CssSelector("//ol[@class='products list items product-items']//child::li[1]");
        private readonly By thirdItemFiltered = By.CssSelector("//ol[@class='products list items product-items']//child::li[1]");
        private readonly By fourthItemFiltered = By.CssSelector("//ol[@class='products list items product-items']//child::li[1]");
        private readonly By fifthItemFiltered = By.CssSelector("//ol[@class='products list items product-items']//child::li[1]");
        private readonly By sixthItemFiltered = By.CssSelector("//ol[@class='products list items product-items']//child::li[1]");

        public By GetSearchField => searchField;
        public By GetSearchButton => searchButton;

        public By GetFirstItemFiltered => firstItemFiltered;
        public By GetSecondItemFiltered => secondItemFiltered;
        public By GetThirdItemFiltered => thirdItemFiltered;
        public By GetFourthItemFiltered => fourthItemFiltered;
        public By GetFifthItemFiltered => fifthItemFiltered;
        public By GetSixthItemFiltered => sixthItemFiltered;
    }
}
