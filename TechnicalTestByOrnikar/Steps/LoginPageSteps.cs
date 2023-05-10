using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.drivers;
using TechnicalTestByOrnikar.PageObjects;
using TechnicalTestByOrnikar.Validations;
using TechTalk.SpecFlow;

namespace TechnicalTestByOrnikar.Steps
{
    [Binding]
     class LoginPageSteps
    {
        LoginPageEspaceAssureObject loginPageEspaceAssureObject = new();

        LoginPageEspaceAssureValidations loginPageEspaceAssureValidations = new();

        FrontPageValidations frontPageValidations = new();

        FrontPageObject frontPageObject = new();

        [Given(@"I enter Espace Assure Url in browser")]
        public void GivenIEnterEspaceAssureUrlInBrowser()
        {
            loginPageEspaceAssureValidations.NavigateToOrnikarEspaceAssureLoginPage();
        }

        [When(@"I reach the website the Url is correct")]
        public void WhenIReachTheWebsiteTheUrlIsCorrect()
        {
            Assert.That(loginPageEspaceAssureValidations.LandedOnEspaceAssureLoginPage());
        }


        [Given(@"I am on Espace Assure login page")]
        public void GivenIAmOnEspaceAssureLoginPage()
        {
            loginPageEspaceAssureValidations.NavigateToOrnikarEspaceAssureLoginPage();
            Assert.That(loginPageEspaceAssureValidations.LandedOnEspaceAssureLoginPage());
        }

        [When(@"I fill credentials")]
        public void WhenIFillCredentials()
        {
            loginPageEspaceAssureObject.ClickEmailField();
            loginPageEspaceAssureObject.WriteEmailTest();
            loginPageEspaceAssureObject.ClickPasswordField();
            loginPageEspaceAssureObject.WritePassword();
        }

        [When(@"I click on connect button")]
        public void WhenIClickOnConnectButton()
        {
            loginPageEspaceAssureObject.ClickConnectButton();
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            Assert.That(!loginPageEspaceAssureObject.VerifyIfLoginFailed());
        }

        [When(@"I fill an invalid format Email")]
        public void WhenIFillAnInvalidFormatEmail()
        {
            loginPageEspaceAssureObject.ClickEmailField();
            loginPageEspaceAssureObject.WriteInvalidEmail();
        }

        [Then(@"the page display a warning msg")]
        public void ThenThePageDisplayAWarningMsg()
        {
            Assert.That(loginPageEspaceAssureObject.VerifyInvalidEmailMessagePresence());
        }

        [When(@"I click on show password button")]
        public void WhenIClickOnShowPasswordButton()
        {
            loginPageEspaceAssureObject.ClickShowPassword();
        }

        [Then(@"the passsword is visible")]
        public void ThenThePassswordIsVisible()
        {
            Assert.That(loginPageEspaceAssureObject.IsPasswordVisible());
        }

        [When(@"I click on J'ai oublié mon mot de passe")]
        public void WhenIClickOnJaiOublieMonMotDePasse()
        {
            loginPageEspaceAssureObject.ClickForgottenPasswordButton();
        }

        [Then(@"I am on reset-password page")]
        public void ThenIAmOnReset_PasswordPage()
        {
            Assert.That(loginPageEspaceAssureValidations.LandedOnResetPasswordPage());
        }


        [AfterTestRun]
        public static void CleanUp()
        {
            Thread.Sleep(3000);
            Driver.chromeDriver.Quit();
        }
    }
}
