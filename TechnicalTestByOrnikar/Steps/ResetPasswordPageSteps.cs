using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.drivers;
using TechnicalTestByOrnikar.PageObjects;
using TechnicalTestByOrnikar.Utils;
using TechnicalTestByOrnikar.Validations;
using TechTalk.SpecFlow;

namespace TechnicalTestByOrnikar.Steps
{
    [Binding]
    class ResetPasswordPageSteps
    {
        LoginPageEspaceAssureValidations loginPageEspaceAssureValidations = new();

        ResetPasswordPageObject resetPasswordPageObject = new();

        [Given(@"I am on reset password page")]
        public void GivenIAmOnResetPasswordPage()
        {
            loginPageEspaceAssureValidations.NavigateToOrnikarEspaceAssureResetPasswordPage();
            Assert.That(loginPageEspaceAssureValidations.LandedOnResetPasswordPage());
        }

        [When(@"I click je me connecte à Ornikar")]
        public void WhenIClickJeMeConnecteAOrnikar()
        {
            resetPasswordPageObject.ClickBackToOrnikarButtonLoginPage();
        }

        [Then(@"I am back on login page espace assuré")]
        public void ThenIAmBackOnLoginPageEspaceAssure()
        {
            Assert.That(loginPageEspaceAssureValidations.LandedOnEspaceAssureLoginPage());
        }

        [When(@"I fill an Email")]
        public void WhenIFillAnEmail()
        {
            resetPasswordPageObject.ClickEmailField();
            resetPasswordPageObject.WriteEmailTest();
        }

        [Then(@"I click on je réinitialise mon mot de passe")]
        public void ThenIClickOnJeReinitialiseMonMotDePasse()
        {
            resetPasswordPageObject.ClickResetPasswordButton();
        }

        [Then(@"A notification is displayed")]
        public void ThenANotificationIsDisplayed()
        {
            Assert.That(resetPasswordPageObject.VerifyNotificationResetPasswordPresence());
        }

        [When(@"I Click on close notification")]
        public void WhenIClickOnCloseNotification()
        {
            resetPasswordPageObject.ClickEmailField();
            resetPasswordPageObject.WriteEmailTest();
            resetPasswordPageObject.ClickResetPasswordButton();
            resetPasswordPageObject.ClickOnCloseNotification();
        }

        [Then(@"the notification is hidden")]
        public void ThenTheNotificationIsHidden()
        {
           Assert.That(resetPasswordPageObject.VerifyNotificationIsClosed());
        }

        [Given(@"I can see Mot de pass oublié title")]
        public void GivenICanSeeMotDePassOublieTitle()
        {
            Assert.That(resetPasswordPageObject.IsMotDePasseOublieValid());
        }

        [Given(@"The paragraph is correct")]
        public void GivenTheParagraphIsCorrect()
        {
            Assert.That(resetPasswordPageObject.IsParagraphTextMotDePasseOublieValid());
        }

        [Given(@"Adress Email label is visible")]
        public void GivenAdressEmailLabelIsVisible()
        {
            Assert.That(resetPasswordPageObject.IsValidEmailLabel());
        }

        [Given(@"Je réninitialise mon mot de passe button text is valid")]
        public void GivenJeReninitialiseMonMotDePasseButtonTextIsValid()
        {
            Assert.That(resetPasswordPageObject.IsValidButtonResetText());
        }

        [Given(@"notification text is correct")]
        public void GivenNotificationTextIsCorrect()
        {
            resetPasswordPageObject.ClickEmailField();
            resetPasswordPageObject.WriteEmailTest();
            resetPasswordPageObject.ClickResetPasswordButton();
            Assert.That(resetPasswordPageObject.VerifyNotificationTextDisplay());
        }

        [AfterTestRun]
        public static void CleanUp()
        {
            Thread.Sleep(3000);
            Driver.chromeDriver.Quit();
        }
    }
}
