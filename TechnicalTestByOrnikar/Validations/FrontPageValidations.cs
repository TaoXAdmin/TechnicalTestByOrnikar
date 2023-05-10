using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.PageObjects;
using TechnicalTestByOrnikar.Steps;
using TechnicalTestByOrnikar.Utils;
using TechTalk.SpecFlow.Events;
using TechnicalTestByOrnikar.drivers;

namespace TechnicalTestByOrnikar.Validations
{
     public class FrontPageValidations 
    {
        public static string OrnikarAssuranceAutoUrl = "https://www.ornikar.com/assurance-auto";

        public static string OrnikarHomePageUrl = "https://www.ornikar.com/";

        public static string OrnikarCodePageUrl = "https://www.ornikar.com/code";

        public static string OrnikarPermisPageUrl = "https://www.ornikar.com/permis";

        public static string OrnikarConduiteAccompagneePageUrl = "https://www.ornikar.com/conduite-accompagnee";

        public static string OrnikarConduitePageUrl = "https://www.ornikar.com/conduite";

        public static string OrnikarFinancementCPFPageUrl = "https://www.ornikar.com/permis/demarches/financer-permis/cpf";

        public static string OrnikarSouscriptionPageUrlResetTrue = "https://www.ornikar.com/assurance-auto/souscription?reset=true";

        public static string OrnikarSouscriptionPageUrl = "https://www.ornikar.com/assurance-auto/souscription";


        SeleniumHelper seleniumHelper = new(Driver.chromeDriver);

        public void NavigateToOrnikarAssuranceAuto()
        {
            seleniumHelper.Navigate(OrnikarAssuranceAutoUrl);           
        }

        public bool LandedOnOrnikarAssuranceAutoWebsite()
        {       
            return seleniumHelper.GetCurrentUrl() == OrnikarAssuranceAutoUrl;
        }

        public bool LandedOnOrnikarHomePage()
        {
            return seleniumHelper.GetCurrentUrl() == OrnikarHomePageUrl;
        }

        public bool LandedOnOrnikarCodePage()
        {
            return seleniumHelper.GetCurrentUrl() == OrnikarCodePageUrl;
        }

        public bool LandedOnOrnikarPermisPage()
        {
            return seleniumHelper.GetCurrentUrl() == OrnikarPermisPageUrl;
        }

        public bool LandedOnOrnikarConduiteAccompagneePage()
        {
            return seleniumHelper.GetCurrentUrl() == OrnikarConduiteAccompagneePageUrl;
        }

        public bool LandedOnOrnikarConduitePage()
        {
            return seleniumHelper.GetCurrentUrl() == OrnikarConduitePageUrl;
        }

        public bool LandedOnOrnikarFinancementCPFPage()
        {
            return seleniumHelper.GetCurrentUrl() == OrnikarFinancementCPFPageUrl;
        }

        public bool LandedOnOrnikarSouscriptionPageResetTrue()
        {
            return seleniumHelper.GetCurrentUrl() == OrnikarSouscriptionPageUrlResetTrue;
        }

        public bool LandedOnOrnikarSouscriptionPage()
        {
            return seleniumHelper.GetCurrentUrl() == OrnikarSouscriptionPageUrl;
        }
    }
}
