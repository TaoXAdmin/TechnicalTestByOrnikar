using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;

namespace TechnicalTestByOrnikar.Utils
{
    public class BaseSetup
    {
        public static IWebDriver GetBrowserInstance()
        {
            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddArgument("disablle-infobars");

            chromeOptions.AddArgument("--disable-site-isolation-trials");

            chromeOptions.AddArgument("--ignore-certificate-errors");

            chromeOptions.AddArgument("--test-type");

            chromeOptions.AddArgument("--verbose");

            chromeOptions.AddArgument("--no-sandbox");

            chromeOptions.AcceptInsecureCertificates = true;

            ChromeDriverService service = ChromeDriverService.CreateDefaultService(".");

            IWebDriver  driver  = new ChromeDriver(service, chromeOptions);

            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
