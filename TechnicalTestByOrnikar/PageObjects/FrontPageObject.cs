using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V110.Audits;
using OpenQA.Selenium.DevTools.V110.Page;
using OpenQA.Selenium.DevTools.V110.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.Steps;
using TechnicalTestByOrnikar.Utils;
using TechnicalTestByOrnikar.Validations;
using TechnicalTestByOrnikar.drivers;

namespace TechnicalTestByOrnikar.PageObjects
{
    public class FrontPageObject 
    {
        SeleniumHelper seleniumHelper = new(Driver.chromeDriver);

        //////////////First Top Vertical Line of elements (mainly  NavBar)

        //Home Element refs and actions
        private static readonly By HomeLink = By.CssSelector("a[data-testid='go-to-home']");

        private IWebElement HomeLinkAction
        {
            get
            {
                return Driver.chromeDriver.FindElement(HomeLink);
            }
        }

        public void ClickHomeButton()
        {
            seleniumHelper.WaitElementExists(HomeLink);
            HomeLinkAction.Click();
        }

        //Home Element refs and actions

        private static readonly By TheoryLink = By.CssSelector("a[data-testid='go-to-theory']");

        private static readonly By DriverLicenseMenuContainer = By.CssSelector("a[data-testid='open-menu-permis-de-conduire']");

        private static readonly By PermisBLink = By.CssSelector("a[data-testid='go-to-permis-b']");

        private static readonly By ConduitAccompagneeLink = By.CssSelector("a[data-testid='go-to-conduite-accompagnee']");

        private static readonly By ConduiteLink = By.CssSelector("a[data-testid='go-to-conduite-a-la-carte']");

        private static readonly By CPFLink = By.CssSelector("a[data-testid='go-to-financement-cpf']");

        private static readonly By InsurancePageLink = By.CssSelector("a[data-testid='go-to-insurance']");

        private static readonly By ConnexionBtn = By.CssSelector("div[data-testid='connection-button']");

        //////////////Second part is Hook advertisement, happy man picture and begin online quotation 

        private static readonly By HappyManPicutre = By.XPath("//*[@id=\"quote\"]/div/img");

        private static readonly By HookAdsTitle = By.XPath("//*[@id=\"quote\"]/div/div/div[1]/h1");

        private static readonly By QuotationContainer = By.XPath("//*[@id=\"quote\"]/div/div/div[2]/div");

        private static readonly By StartingOffer = By.XPath("//*[@id=\"quote\"]/div/div/div[2]/div/div[1]");

        private static readonly By StartingOfferSideInfo = By.XPath("//*[@id=\"quote\"]/div/div/div[2]/div/div[1]/div[5]/div/div");

        private static readonly By StartQuotationLink = By.XPath("//*[@id=\"quote\"]/div/div/div[2]/div/div[2]/div/a[1]");

        private static readonly By ContinueQuotationLink = By.XPath("//*[@id=\"quote\"]/div/div/div[2]/div/div[2]/div/a[2]");

        private static readonly By RatingContainer = By.XPath("//*[@id=\"quote\"]/div/div/div[3]/div");

        private static readonly By StarsImg = By.XPath("//*[@id=\"quote\"]/div/div/div[3]/div/img");

        private static readonly By SatisfactionLabel = By.XPath("//*[@id=\"quote\"]/div/div/div[3]/div/div/div[1]");

        private static readonly By SatisfactionLabelSideInfo = By.XPath("//*[@id=\"quote\"]/div/div/div[3]/div/div/div[2]/div/div");

        //////////////Third part wil be dedicated to the online chat

        private static readonly By ChatImgBtn = By.XPath("//*[@id=\"crisp-chatbox\"]/div/a/span[2]/span/span[1]/span/span");

        private static readonly By ChatExitBtn = By.XPath("//*[@id=\"crisp-chatbox\"]/div/div/div[1]/div/span[2]/span/span");

        private static readonly By ChatTextArea = By.XPath("//*[@id=\"crisp-chatbox\"]/div/div/div[2]/div/div[5]/form/textarea");

        private static readonly By OrnikarUserAdmin = By.XPath("//*[@id=\"cc-1hzo\"]/div/div[1]/div/div/span[2]");

        private static readonly By OrnikarChatWelcomeMessage = By.XPath("//*[@id=\"cc-1hzo\"]/div/div[1]/div/div/span[3]/span/span[1]/span/div");

        private static readonly By ChatInsertEmojiAction = By.XPath("//*[@id=\"crisp-chatbox\"]/div/div/div[2]/div/div[6]/div/span[1]/span[1]");

        private static readonly By ChatInsertFile = By.XPath("//*[@id=\"crisp-chatbox\"]/div/div/div[2]/div/div[6]/div/span[2]/span[2]/input");

        private static readonly By SmileySelection = By.XPath("//*[@id=\"crisp-chatbox\"]/div/div/div[2]/div/div[5]/div/div[2]/a[1]");

        private static readonly By GIFsSelection = By.XPath("//*[@id=\"crisp-chatbox\"]/div/div/div[2]/div/div[5]/div/div[2]/a[2]");

        //////////////4TH part shows 3 cards explaining why chosing OrinkarInsurance

        private static readonly By SectionLabelBenefits = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/h2");

        private static readonly By EasierCardContainer = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[1]");

        private static readonly By EasierCardIllustration = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[1]/div[1]/img");

        private static readonly By EasierCardLabel = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[1]/div[2]/h3");

        private static readonly By EasierCardParagraph = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[1]/div[2]/div");

        private static readonly By MoreEfficientCardContainer = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[2]");

        private static readonly By MoreEfficientCardIllustration = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[2]/div[1]/img");

        private static readonly By MoreEfficientCardLabel = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[2]/div[2]/h3");

        private static readonly By MoreEfficientCardParagraph = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[2]/div[2]/div");

        private static readonly By MindfulCardContainer = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[3]");

        private static readonly By MindfulCardIllustration = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[3]/div[1]/img");

        private static readonly By MindfulCardLabel = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[3]/div[2]/h3");

        private static readonly By MindfulCardParagraph = By.XPath("//*[@id=\"__next\"]/div/div/main/div[2]/div/div/div[3]/div[2]/div");

        //////////////5th part represents description and informations of their future car insurance we have cards display as well

        private static readonly By DiscoverTitleSection = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/h2");

        private static readonly By DiscoverShortParagraph = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[1]");

        private static readonly By CivilResponsabilityCardContainer = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[1]");

        private static readonly By CivilResponsabilityCardLogo = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[1]/div[1]/div/svg");

        private static readonly By CivilResponsabilityCardLabel = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[1]/div[2]/h3");

        private static readonly By CivilResponsabilityCardParagraph = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[1]/div[2]/div");

        private static readonly By CivilResponsabilityCardRefundLabel = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[1]/div[3]/div[1]");

        private static readonly By CivilResponsabilityCardRefundAmounts = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[1]/div[3]/div[2]");

        private static readonly By DriverProtectionCardContainer = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[3]");

        private static readonly By DriverProtectionCardLogo = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[3]/div[1]/div/svg");

        private static readonly By DriverProtectionCardLabel = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[3]/div[2]/h3");

        private static readonly By DriverProtectionCardParagraph = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[3]/div[2]/div");

        private static readonly By DriverProtectionCardRefundLabel = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[3]/div[3]/div[1]");

        private static readonly By DriverProtectionCardRefundAmounts = By.XPath("//*[@id=\"__next\"]/div/div/main/div[3]/div/div[2]/div[3]/div[3]/div[2]");

        //////////////6th part is 

    }
}
