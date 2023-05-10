using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.drivers;
using TechnicalTestByOrnikar.Utils;

namespace TechnicalTestByOrnikar.Validations
{
    class SouscriptionPageValidations
    {
        public static string OrnikarSouscriptionPageUrl = "https://www.ornikar.com/assurance-auto/souscription";

        public static string OrnikarSouscriptionPageUrlResetTrue = "https://www.ornikar.com/assurance-auto/souscription?reset=true";

        SeleniumHelper seleniumHelper = new(Driver.chromeDriver);

        public void NavigateToOrnikarSouscriptionPage()
        {
            Driver.chromeDriver.Manage().Window.Maximize();
            seleniumHelper.Navigate(OrnikarSouscriptionPageUrl);
        }

        public void NavigateToOrnikarSouscriptionPageResetTrue()
        {
            Driver.chromeDriver.Manage().Window.Maximize();
            seleniumHelper.Navigate(OrnikarSouscriptionPageUrlResetTrue);

        }

        public bool LandedOnOrnikarSouscriptionPage()
        {
            return seleniumHelper.GetCurrentUrl().Equals(OrnikarSouscriptionPageUrl);
        }
        public bool LandedOnOrnikarSouscriptionPageResetTrue()
        {
            return seleniumHelper.GetCurrentUrl().Equals(OrnikarSouscriptionPageUrlResetTrue);
        }
    }
}
