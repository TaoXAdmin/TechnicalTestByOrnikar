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

namespace TechnicalTestByOrnikar.Steps
{
    [Binding]
    
    class FrontPageSteps
    {
        FrontPageValidations frontPageValidations = new();

        FrontPageObject frontPageObject = new();
        
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
        
        [Given(@"I am connected to Ornikar Assurance-Auto front-office")]
        public void GivenIAmConnectedToOrnikarAssurance_AutoFront_Office()
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
            throw new PendingStepException();
        }
        
        [Then(@"I am on code page")]
        public void ThenIAmOnCodePage()
        {
            throw new PendingStepException();
        }
        
        [When(@"I click on context-menu and Permis-B button is clickable")]
        public void WhenIClickOnContext_MenuAndPermis_BButtonIsClickable()
        {
            throw new PendingStepException();
        }
        
        [Then(@"I click on Permis-B")]
        public void ThenIClickOnPermis_B()
        {
            throw new PendingStepException();
        }
        
        [Then(@"I am on Permis page")]
        public void ThenIAmOnPermisPage()
        {
            throw new PendingStepException();
        }
        
        [When(@"I click on context-menu and conduite accompagnée button is clickable")]
        public void WhenIClickOnContext_MenuAndConduiteAccompagneeButtonIsClickable()
        {
            throw new PendingStepException();
        }
        
        [Then(@"I click on conduite accompagnée")]
        public void ThenIClickOnConduiteAccompagnee()
        {
            throw new PendingStepException();
        }
        
        [Then(@"I am on conduite accompagnée page")]
        public void ThenIAmOnConduiteAccompagneePage()
        {
            throw new PendingStepException();
        }
        
        [When(@"I click on context-menu and conduite button is clickable")]
        public void WhenIClickOnContext_MenuAndConduiteButtonIsClickable()
        {
            throw new PendingStepException();
        }
        
        [Then(@"I click on conduite")]
        public void ThenIClickOnConduite()
        {
            throw new PendingStepException();
        }
        
        [Then(@"I am on conduite page")]
        public void ThenIAmOnConduitePage()
        {
            throw new PendingStepException();
        }
        
        [When(@"I click on context-menu and financement CPF button is clickable")]
        public void WhenIClickOnContext_MenuAndFinancementCPFButtonIsClickable()
        {
            throw new PendingStepException();
        }
        
        [Then(@"I click on financement CPF")]
        public void ThenIClickOnFinancementCPF()
        {
            throw new PendingStepException();
        }
        
        [Then(@"I am on financement CPF page")]
        public void ThenIAmOnFinancementCPFPage()
        {
            throw new PendingStepException();
        }


    }
}

