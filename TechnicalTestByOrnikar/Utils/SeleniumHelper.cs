using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V110.Page;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTestByOrnikar.Utils
{
    public class SeleniumHelper
    {
        public IWebDriver Driver;

        private readonly Actions clicker;

        private readonly WebDriverWait webDriverWait;


        public SeleniumHelper(IWebDriver driver)
        {
            this.Driver = driver;

            this.Driver.Manage().Window.Maximize();

            this.webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void WaitPageRedirect(string url)
        {
            this.webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlToBe(url));
        }

        public void WaitElementVisibility(By locator) 
        {
            this.webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public void WaitElementInvisibility(By locator) 
        {
            this.webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        public bool VerifyIfElementExists(By locator) 
        {
            try 
            {
                this.webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public bool MovetoPage(By locator, By webElemment, By focus)
        {
            try
            {
                this.webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                return true;
            }
            catch (WebDriverTimeoutException) 
            {
                this.webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(webElemment));

                this.Driver.FindElement(focus).SendKeys(Keys.Tab);
                return false;
            }
        }
        
        publlic void

    }
}
