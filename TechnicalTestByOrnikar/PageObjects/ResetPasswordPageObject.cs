using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.drivers;
using TechnicalTestByOrnikar.Utils;

namespace TechnicalTestByOrnikar.PageObjects
{
    class ResetPasswordPageObject
    {
        SeleniumHelper seleniumHelper = new(Driver.chromeDriver);

        //Email  elements and action
        private static string EmailTest = "testOrnikar@ornikar.com";

        private static string EmailLabelText = "Adresse email";

        private static readonly By EmailField = By.CssSelector("input[id='email']");

        private static readonly By EmailLabel = By.CssSelector("label[for='email']");

        private IWebElement EmailFieldElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(EmailField);
            }
        }

        private IWebElement EmailLabelElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(EmailLabel);
            }
        }

        public void ClickEmailField()
        {
            seleniumHelper.WaitElementExists(EmailField);
            EmailFieldElement.Click();
        }

        public void WriteEmailTest()
        {
            EmailFieldElement.SendKeys(EmailTest);
        }

        public bool IsValidEmailLabel()
        {
            return EmailLabelElement.Text.Equals(EmailLabelText);
        }

        //Reset  Password button element and action
        private static readonly By ResetPasswordButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[2]/div/div/form/button");
        private static string ResetPasswordButtonText = "Je réinitialise mon mot de passe";

        private IWebElement ResetPasswordButtonElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(ResetPasswordButton);
            }
        }


        public void ClickResetPasswordButton()
        {
            seleniumHelper.WaitElementExists(ResetPasswordButton);
            ResetPasswordButtonElement.Click();
        }

        public bool IsValidButtonResetText()
        {
            return ResetPasswordButtonElement.Text.Equals(ResetPasswordButtonText);
        }


        //Back to Ornikar button element and  action
        private static readonly By BackToOrnikarLoginPageButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[2]/footer/p/span/a");

        private IWebElement BackToOrnikarButtonLoginPageElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(BackToOrnikarLoginPageButton);
            }
        }

        public void ClickBackToOrnikarButtonLoginPage()
        {
            seleniumHelper.WaitElementExists(BackToOrnikarLoginPageButton);
            BackToOrnikarButtonLoginPageElement.Click();
        }

      //Notification after sending request element and action
        private static string NotificationText = @"Un lien de réinitialisation de votre mot de passe a été envoyé à l'adresse " + EmailTest + ". Si vous n'avez reçu aucun email de notre part, merci de vérifier vos spams et de nous contacter si celui-ci n'a pas été reçu.";

        private static readonly By NotificationResetPassword = By.XPath("//*[@id=\"root\"]/div/div/div[1]/div/div");

        private static readonly By CloseNotification = By.XPath("//*[@id=\"root\"]/div/div/div[1]/div/div/div[2]/button");

        private static readonly By SvgCloseNotification = By.XPath("//*[@id=\"root\"]/div/div/div[1]/div/div/div[2]/button/div/div/svg");

        private IWebElement NotificationResetPasswordElement
        {
            get
            {
                seleniumHelper.WaitElementExists(NotificationResetPassword);
                return Driver.chromeDriver.FindElement(NotificationResetPassword);
            }
        }

        private IWebElement CloseNotificationButton
        {
            get
            {
                return  Driver.chromeDriver.FindElement(CloseNotification);
            }
        }

        public void ClickOnCloseNotification()
        {
            seleniumHelper.WaitElementExists(CloseNotification);
            CloseNotificationButton.Click();
        }

        public bool VerifyNotificationResetPasswordPresence()
        {
            return seleniumHelper.VerifyIfElementExists(NotificationResetPassword);
        }

        public bool VerifyNotificationTextDisplay()
        {
            var debug = NotificationResetPasswordElement.Text;
            debug = @"" + debug + "";
            return debug.Equals(NotificationText);
        }

        public bool VerifyNotificationIsClosed()
        {
            return seleniumHelper.VerifyIfElementExists(NotificationResetPassword);
        }


        //Rest of UI Test
        //Mot de passe oublié element
        private static readonly By MotDePasseOublieTitle = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[2]/div/div/h3");
        private static string MotDePasseOublieLabel = "Mot de passe oublié";

        private IWebElement MotDePasseOublieTitleElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(MotDePasseOublieTitle);
            }
        }

        public bool IsMotDePasseOublieValid()
        {
            return MotDePasseOublieTitleElement.Text.Equals(MotDePasseOublieLabel);
        }

        //Paragraph mot de passe oublié   element
        private static readonly By ParagraphMotDePasseOublie = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[2]/div/div/p");
        private static string ParagraphMotDePasseOublieText = "Renseignez l'adresse email de votre compte Ornikar," +
                                                              " nous vous enverrons un lien pour que vous puissiez choisir un nouveau mot de passe.";

        private IWebElement ParagraphMotDePasseOublieElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(ParagraphMotDePasseOublie);
            }
        }

        public bool IsParagraphTextMotDePasseOublieValid()
        {
            return ParagraphMotDePasseOublieElement.Text.Equals(ParagraphMotDePasseOublieText);
        }
    }



}
