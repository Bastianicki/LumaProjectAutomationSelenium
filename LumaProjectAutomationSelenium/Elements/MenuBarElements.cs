using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.Elements
{
    public class MenuBarElements
    {

        private readonly By signInButton = By.XPath("//div[@class='panel header']//child::li[@class='authorization-link']//child::a");
        private readonly By createAnAccount = By.XPath("//div[@class='panel header']//child::li[3]//child::a");
        private readonly By welcomeMessage = By.XPath("//div[@class='panel header']//child::li[1]//child::span");
        private readonly By whatsNewMenuItem = By.Id("ui-id-3n");
        private readonly By womenMenuItem = By.Id("ui-id-4");
        private readonly By menMenuItem = By.Id("ui-id-5");
        private readonly By gearMenuItem = By.Id("ui-id-6");
        private readonly By trainingMenuItem = By.Id("ui-id-7");
        private readonly By saleMenuItem = By.Id("ui-id-8");

        public By GetSignInButton => signInButton;
        public By GetCreateAnAccount => createAnAccount;
        public By GetWelcomeMessage => welcomeMessage;
        public By GetWhatsNewMenuItem => whatsNewMenuItem;
        public By GetWomenMenuItem => womenMenuItem;
        public By GetMenMenuItem => menMenuItem;
        public By GetGearMenuItem => gearMenuItem;
        public By GetTrainingMenuItem => trainingMenuItem;
        public By GetSaleMenuItem => saleMenuItem;
    }
}
