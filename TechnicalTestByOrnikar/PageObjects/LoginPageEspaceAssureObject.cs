using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.DevTools.V110.Audits;
using OpenQA.Selenium.DevTools.V110.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.drivers;
using TechnicalTestByOrnikar.Utils;

namespace TechnicalTestByOrnikar.PageObjects
{
    public class LoginPageEspaceAssureObject
    {
        SeleniumHelper seleniumHelper = new(Driver.chromeDriver);

        //Container of the form, OrnikarLogo element and action, and result of connection  
        private static readonly By OrnikarLogo = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[1]/a/svg");

        private static readonly By OrnikarEspaceAssureLink = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[1]/a");

        private static readonly By FormContainer = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[2]/div/div");

        private static readonly By LoginFailedInfo = By.XPath("//*[@id=\"root\"]/div/div/div[1]/div/div/div/div[2]");

        private IWebElement LoginFailedInfoElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(LoginFailedInfo);
            }
        }

        public bool VerifyIfLoginFailed()
        {
            return seleniumHelper.VerifyIfElementExists(LoginFailedInfo);
        }

        //Email elements and actions
        private static string EmailTest = "testOrnikar@ornikar.com";

        private static string EmailLabelText = "Adresse email";

        private static readonly By EmailLabel = By.CssSelector("label[for='email']");

        private static readonly By EmailField = By.CssSelector("input[id='email']");

        private static readonly By InvalidEmailInputMsg = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[2]/div/div/div/form/div[1]/div[3]/div");

        private  IWebElement EmailLabelElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(EmailLabel);
            }
        }

        private IWebElement EmailFieldElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(EmailField);
            }
        }
        public bool VerifyEmailFieldLabelText()
        {
            return EmailLabelElement.Text.Equals(EmailLabelText);
        }

        public bool VerifyEmailFieldPresence()
        {
            return seleniumHelper.VerifyIfElementExists(EmailField);
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

        public void WriteInvalidEmail()
        {
            EmailFieldElement.SendKeys(EmailTest.Replace("@","#"));
        }

        public bool VerifyInvalidEmailMessagePresence()
        {
            return seleniumHelper.VerifyIfElementExists(InvalidEmailInputMsg);
        }

        //Password elements and actions
        private static String Password = "123456";

        private static String PasswordLabelText = "Mot de passe";

        private static readonly By PasswordLabel = By.CssSelector("label[for='password']");

        private static readonly By PasswordField = By.CssSelector("input[id='password']");

        private static readonly By ShowPasswordButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[2]/div/div/div/form/div[2]/div[2]/div/button");

        private static readonly By ShowPasswordLogo = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[2]/div/div/div/form/div[2]/div[2]/div/button/div/svg");

        private static readonly By ForgottenPasswordButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[2]/div/div/div/form/div[4]/a");

        private IWebElement PasswordLabelElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(PasswordLabel);
            }
        }

        private IWebElement PasswordFieldElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(PasswordField);
            }
        }

        private IWebElement ShowPasswordButtonElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(ShowPasswordButton);
            }
        }

        private IWebElement ForgottenPasswordButtonElement
        {
            get
            {

                return Driver.chromeDriver.FindElement(ForgottenPasswordButton);
            }
        }

        public bool VerifyPasswordLabelText()
        {
            return PasswordLabelElement.Text.Equals(PasswordLabelText);
        }

        public bool VerifyPasswordFieldPresence()
        {
            return seleniumHelper.VerifyIfElementExists(PasswordField);
        }

        public bool VerifyShowPasswordPresence()
        {
            return seleniumHelper.VerifyIfElementExists(ShowPasswordButton);
        }

        public void ClickPasswordField()
        {
            seleniumHelper.WaitElementExists(PasswordField);
            PasswordFieldElement.Click();
        }
        
        public void WritePassword()
        {
            PasswordFieldElement.SendKeys(Password);
        }

        public void ClickShowPassword()
        {
            seleniumHelper.WaitElementExists(ShowPasswordButton);
            ShowPasswordButtonElement.Click();
        }

        public void ClickForgottenPasswordButton()
        {
            seleniumHelper.WaitElementExists(ForgottenPasswordButton);
            ForgottenPasswordButtonElement.Click();
        }

        public string GetPasswordTypeAttribut()
        {
            return PasswordFieldElement.GetAttribute("type");
        }

        public bool IsPasswordVisible()
        {
            return GetPasswordTypeAttribut().Equals("text");
        }

        //Connect Button Element and Action
        private static readonly By ConnectButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/main/div[2]/div/div/div/form/div[3]/button");

        private IWebElement ConnectButtonElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(ConnectButton);
            }
        }

        public bool VerifyConnectButtonPresence()
        {
            return seleniumHelper.VerifyIfElementExists(ConnectButton);
        }

        public void ClickConnectButton()
        {
            seleniumHelper.VerifyIfElementExists(ConnectButton);
            ConnectButtonElement.Click();
        }
    }
}
