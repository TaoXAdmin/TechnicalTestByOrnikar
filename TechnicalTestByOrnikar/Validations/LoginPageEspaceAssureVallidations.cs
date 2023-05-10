using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TechnicalTestByOrnikar.drivers;
using TechnicalTestByOrnikar.Utils;

namespace TechnicalTestByOrnikar.Validations
{
    public class LoginPageEspaceAssureValidations
    {
        public static string OrnikarAssuranceLoginPagePartialUrl = "https://espace-assure.ornikar.com/";

        public static string OrnikarAssuranceLoginPageUrl = "https://espace-assure.ornikar.com/login?redirect_action=vitrine_login&redirect_action=logout";

        public static string OrnikarAssuranceResetPasswordUrl = "https://espace-assure.ornikar.com/reset-password";

        SeleniumHelper seleniumHelper = new(Driver.chromeDriver);

        public void NavigateToOrnikarEspaceAssureLoginPage()
        {
            seleniumHelper.Navigate(OrnikarAssuranceLoginPageUrl);
        }

        public void NavigateToOrnikarEspaceAssureResetPasswordPage()
        {
            seleniumHelper.Navigate(OrnikarAssuranceResetPasswordUrl);
        }

        public bool LandedOnEspaceAssureLoginPage()
        {
            return seleniumHelper.GetCurrentUrl().Contains(OrnikarAssuranceLoginPagePartialUrl);
        }

        public bool LandedOnResetPasswordPage()
        {
            return seleniumHelper.GetCurrentUrl().Equals(OrnikarAssuranceResetPasswordUrl);
        }

    }
}
