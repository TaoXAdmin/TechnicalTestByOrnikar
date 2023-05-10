using OpenQA.Selenium;
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

        private readonly WebDriverWait webDriverWait;

        public SeleniumHelper(IWebDriver driver)
        {
            this.Driver = driver;

            this.Driver.Manage().Window.Maximize();

            this.webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public static  IWebDriver GetCurrentDriver()
        {
            return BaseSetup.GetBrowserInstance();
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

        public void Navigate(string url)
        {
            this.Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
        }

        public void Refresh()
        {
            this.Driver.Navigate().Refresh();
        }

        public void Close()
        {
            this.Driver.Close();
        }

        public void WaitElementExists(By locator)
        {
            this.webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
        }

        public void WaitUntilUrlContains(string partialUrl)
        {
            this.webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(partialUrl));
        }

        public void WaitElementToBeClickable(By webElement)
        {
            this.webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));
        }

        public void FocusElement(IWebElement webElement)
        {
            Actions action = new Actions(this.Driver);

            action.MoveToElement(webElement).Perform();
        }

        public void NewTab()
        {
            ((IJavaScriptExecutor)this.Driver).ExecuteScript("window.open();");
            this.Driver.SwitchTo().Window(this.Driver.WindowHandles[this.Driver.WindowHandles.Count - 1]);
        }

        public void PreviousTab()
        {
            this.Driver.SwitchTo().Window(this.Driver.WindowHandles[1]).Close();
            this.Driver.SwitchTo().Window(this.Driver.WindowHandles[0]);
        }

        public string GetCurrentUrl()
        {
            return this.Driver.Url;
        }

        public void WaitForPageLoad()
        {
            this.webDriverWait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public IWebElement FindElementUsingText(String searchText)
        {
            return this.Driver.FindElement(By.XPath("//*[contains(text(),'" + searchText + "']"));
        }
    }
}
