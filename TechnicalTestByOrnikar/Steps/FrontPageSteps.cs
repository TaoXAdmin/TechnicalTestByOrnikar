using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.PageObjects;
using TechnicalTestByOrnikar.Validations;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechnicalTestByOrnikar.Utils;
using TechnicalTestByOrnikar.drivers;

namespace TechnicalTestByOrnikar.Steps
{
    [Binding]
    class FrontPageSteps
    {
        FrontPageValidations frontPageValidations = new();

        FrontPageObject frontPageObject = new();

        LoginPageEspaceAssureObject loginPageEspaceAssureObject = new();

        LoginPageEspaceAssureValidations loginPageEspaceAssureValidations = new();

        SouscriptionPageObject souscriptionPageObject = new();

        [Given(@"I try to access Ornikar Assurance-Auto front-office")]
        public void GivenITryToAccessOrnikarAssuranceAutoFrontOffice()
        {   
            frontPageValidations.NavigateToOrnikarAssuranceAuto();
        }
        
        [When(@"I reach the website the current url is correct")]
        public void WhenIReachTheWebsiteTheCurrentUrlIsCorrect()
        {
            Assert.That(frontPageValidations.LandedOnOrnikarAssuranceAutoWebsite());
        }
        
        [Given(@"I am on Ornikar Assurance-Auto front-office")]
        public void GivenIAmOnOrnikarAssurance_AutoFront_Office()
        {
            frontPageValidations.NavigateToOrnikarAssuranceAuto();
            Assert.That(frontPageValidations.LandedOnOrnikarAssuranceAutoWebsite());
        }
       
        [When(@"I click on home button")]
        public void WhenIClickOnHomeButton()
        {
            frontPageObject.ClickHomeButton();
        }
        
        [Then(@"I am on Ornikar home page")]
        public void ThenIAmOnOrnikarHomePage()
        {
            Assert.That(frontPageValidations.LandedOnOrnikarHomePage());
        }
        
        [When(@"I click on code de la route button")]
        public void WhenIClickOnCodeDeLaRouteButton()
        {
            frontPageObject.ClickTheoryButton();
        }
        
        [Then(@"I am on code page")]
        public void ThenIAmOnCodePage()
        {
            Assert.That(frontPageValidations.LandedOnOrnikarCodePage());
        }

        [When(@"I click on context-menu")]
        public void WhenIClickOnContext_Menu()
        {
            frontPageObject.ClickDriverLicenseContextMenu();
        }

        [Then(@"I click on Permis-B")]
        public void ThenIClickOnPermis_B()
        {
            frontPageObject.ClickPermisBLink();
        }
        
        [Then(@"I am on Permis page")]
        public void ThenIAmOnPermisPage()
        {
            Assert.That(frontPageValidations.LandedOnOrnikarPermisPage());
        }
               
        [Then(@"I click on conduite accompagnée")]
        public void ThenIClickOnConduiteAccompagnee()
        {
            frontPageObject.ClickConduitAccompagneeLink();
        }
        
        [Then(@"I am on conduite accompagnée page")]
        public void ThenIAmOnConduiteAccompagneePage()
        {
            Assert.That(frontPageValidations.LandedOnOrnikarConduiteAccompagneePage);
        }
        
        [Then(@"I click on conduite")]
        public void ThenIClickOnConduite()
        {
            frontPageObject.ClickConduiteLink();
        }
        
        [Then(@"I am on conduite page")]
        public void ThenIAmOnConduitePage()
        {
            Assert.That(frontPageValidations.LandedOnOrnikarConduitePage());
        }
        
        [Then(@"I click on financement CPF")]
        public void ThenIClickOnFinancementCPF()
        {
            frontPageObject.ClickCPFLink();
        }
        
        [Then(@"I am on financement CPF page")]
        public void ThenIAmOnFinancementCPFPage()
        {
            Assert.That(frontPageValidations.LandedOnOrnikarFinancementCPFPage());
        }
        [Given(@"I move to another Ornikar's page")]
        public void GivenIMoveToAnotherOrnikarsPage()
        {
            frontPageObject.ClickHomeButton();
        }

        [When(@"I click on Assurance auto")]
        public void WhenIClickOnAssuranceAuto()
        {
            frontPageObject.ClickInsurancePageLink();
        }

        [Then(@"I am back on Assurante-auto front page")]
        public void ThenIAmBackOnAssurante_AutoFrontPage()
        {
            Assert.That(frontPageValidations.LandedOnOrnikarAssuranceAutoWebsite());
        }

        [When(@"I click on Connexion")]
        public void WhenIClickOnConnexion()
        {
            frontPageObject.ClickConnexionBtn();
        }

        [Then(@"I am on login page")]
        public void ThenIAmOnLoginPage()
        {
            Assert.That(loginPageEspaceAssureObject.VerifyEmailFieldPresence());
        }

        [When(@"I click J'obtiens mon tarif")]
        public void WhenIClickJobtiensMonTarif()
        {
            frontPageObject.ClickOnJObtiensMonTarifButton();
        }

        [Then(@"I am on souscription page")]
        public void ThenIAmOnSouscriptionPage()
        {
            Assert.That(frontPageValidations.LandedOnOrnikarSouscriptionPageResetTrue());
        }

        [Given(@"I have already started a quotation")]
        public void GivenIHaveAlreadyStartedAQuotation()
        {
            frontPageObject.ClickOnJObtiensMonTarifButton();
            souscriptionPageObject.ClickOnNonAnswerButton();
            souscriptionPageObject.ClickOnEnregistrerEtFinirPlusTardButton();
            souscriptionPageObject.ClickOnOrnikarLogoButton();
            souscriptionPageObject.AcceptAlert();
        }

        [When(@"I click on Je reprends mon devis")]
        public void WhenIClickOnJeReprendsMonDevis()
        {
            frontPageObject.ClickOnJeReprendsMonDevisButton();
        }

        [Then(@"I am on souscription page without reset")]
        public void ThenIAmOnSouscriptionPageWithoutReset()
        {
            Assert.That(frontPageValidations.LandedOnOrnikarSouscriptionPage());
        }

        [Then(@"previous action has been saved")]
        public void ThenPreviousActionHasBeenSaved()
        {
            souscriptionPageObject.VerifyIfSavedActionsFromPreviousQuotation();
        }


        [AfterTestRun]
        public static void CleanUp()
        {
            Thread.Sleep(3000);
            Driver.chromeDriver.Quit();
        }

    }
}

