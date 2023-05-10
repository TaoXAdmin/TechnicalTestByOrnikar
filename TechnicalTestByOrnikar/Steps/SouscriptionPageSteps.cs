using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.drivers;
using TechTalk.SpecFlow;

namespace TechnicalTestByOrnikar.Steps
{
    [Binding]
   class SouscriptionPageSteps
    {

        [Given(@"I enter Souscription Page Url in browser")]
        public void GivenIEnterSouscriptionPageUrlInBrowser()
        {
            throw new PendingStepException();
        }

        [When(@"I reach the Souscription Page the Url is correct")]
        public void WhenIReachTheSouscriptionPageTheUrlIsCorrect()
        {
            throw new PendingStepException();
        }

        [When(@"I click Non")]
        public void WhenIClickNon()
        {
            throw new PendingStepException();
        }

        [Then(@"I am on next question page trouver votre véhicule")]
        public void ThenIAmOnNextQuestionPageTrouverVotreVehicule()
        {
            throw new PendingStepException();
        }

        [When(@"I click Oui")]
        public void WhenIClickOui()
        {
            throw new PendingStepException();
        }

        [Then(@"I have the login form view")]
        public void ThenIHaveTheLoginFormView()
        {
            throw new PendingStepException();
        }

        [Given(@"I clicked Oui")]
        public void GivenIClickedOui()
        {
            throw new PendingStepException();
        }

        [When(@"I fill Email and Password")]
        public void WhenIFillEmailAndPassword()
        {
            throw new PendingStepException();
        }

        [Then(@"I click on connect")]
        public void ThenIClickOnConnect()
        {
            throw new PendingStepException();
        }

        [When(@"I click on forgotten password button")]
        public void WhenIClickOnForgottenPasswordButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I am on password remind page")]
        public void ThenIAmOnPasswordRemindPage()
        {
            throw new PendingStepException();
        }

        [When(@"I click on Connexion avec Facebook")]
        public void WhenIClickOnConnexionAvecFacebook()
        {
            throw new PendingStepException();
        }

        [Then(@"I am on Facebook Login page")]
        public void ThenIAmOnFacebookLoginPage()
        {
            throw new PendingStepException();
        }

        [When(@"I click on Rechercher par plaque")]
        public void WhenIClickOnRechercherParPlaque()
        {
            throw new PendingStepException();
        }

        [Then(@"I am on search by plate number form")]
        public void ThenIAmOnSearchByPlateNumberForm()
        {
            throw new PendingStepException();
        }

        [Then(@"I enter a plate number")]
        public void ThenIEnterAPlateNumber()
        {
            throw new PendingStepException();
        }

        [Then(@"the vehicle is found")]
        public void ThenTheVehicleIsFound()
        {
            throw new PendingStepException();
        }

        [Then(@"I enter an  invalid plate number")]
        public void ThenIEnterAnInvalidPlateNumber()
        {
            throw new PendingStepException();
        }

        [Then(@"The website informs me my plate number is invalid")]
        public void ThenTheWebsiteInformsMeMyPlateNumberIsInvalid()
        {
            throw new PendingStepException();
        }


        [AfterTestRun]
        public static void CleanUp()
        {
            Thread.Sleep(3000);
            Driver.chromeDriver.Quit();
        }
    }
}
