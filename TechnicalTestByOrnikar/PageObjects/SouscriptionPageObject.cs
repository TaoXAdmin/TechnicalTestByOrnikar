using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.DevTools.V110.CSS;
using OpenQA.Selenium.DevTools.V110.Debugger;
using OpenQA.Selenium.DevTools.V110.DOM;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.drivers;
using TechnicalTestByOrnikar.Utils;

namespace TechnicalTestByOrnikar.PageObjects
{
    public class SouscriptionPageObject
    {
        SeleniumHelper seleniumHelper = new(Driver.chromeDriver);

        //Ornikar logo, cookies element and action
        private static readonly By OrnikarLogo = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[1]/div[1]/a");

        private static readonly By ContinuerAccepterLesCookies = By.XPath("//*[@id=\"axeptio_btn_acceptAll\"]");

        private IWebElement OrnikarLogoButton
        {
            get
            {
                seleniumHelper.WaitElementExists(OrnikarLogo);
                return Driver.chromeDriver.FindElement(OrnikarLogo);
            }
        }

        public void ClickOnOrnikarLogoButton()
        {
            OrnikarLogoButton.Click();
        }

        public void ClickContinuerAccepterLesCookies()
        {
            seleniumHelper.WaitElementExists(ContinuerAccepterLesCookies);
            Driver.chromeDriver.FindElement(ContinuerAccepterLesCookies).Click();
        }



        //AlreadyRegister Answer Buttons
        private static readonly By OuiAnswer = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/div/div[2]/div/div[2]/div/div[1]");

        private static readonly By NonAnswer = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/div/div[2]/div/div[2]/div/div[2]");

        private IWebElement OuiAnswerButton
        {
            get
            {
                seleniumHelper.WaitElementExists(OuiAnswer);
                return Driver.chromeDriver.FindElement(OuiAnswer);
            }
        }

        private IWebElement NonAnswerButton
        {
            get
            {
                seleniumHelper.WaitElementExists(NonAnswer);
                return Driver.chromeDriver.FindElement(NonAnswer);
            }
        }

        public void ClickOnOuiAnswerButton()
        {
            OuiAnswerButton.Click();
        }

        public void ClickOnNonAnswerButton()
        {
            NonAnswerButton.Click();
        }

        //Search Choices Plate/Brand Elements and Actions
        private static readonly By SearchByNumberPlate = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div[1]");

        private static readonly By SearchByBrand = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div[2]");

        private static readonly By QuelleEstLaMarqueDeVotreVéhicule = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By BrandField = By.CssSelector("input[name='vehiculeMarque']");

        private static readonly By DebugSelection = By.TagName("ul");

        private IWebElement QuelleEstLaMarqueDeVotreVéhiculeTitle
        {
            get
            {
                return Driver.chromeDriver.FindElement(QuelleEstLaMarqueDeVotreVéhicule);
            }
        }

        private IWebElement BrandFieldElement
        {
            get
            {
                seleniumHelper.WaitElementExists(BrandField);
                return Driver.chromeDriver.FindElement(BrandField);
            }
        }

        private IWebElement SearchByNumberPlateButton
        {
            get
            {
                seleniumHelper.WaitElementExists(SearchByNumberPlate);
                return Driver.chromeDriver.FindElement(SearchByNumberPlate);
            }
        }

        private IWebElement SearchByBrandButton
        {
            get
            {
                seleniumHelper.WaitElementExists(SearchByBrand);
                return Driver.chromeDriver.FindElement(SearchByBrand);
            }
        }
        public void ClickOnSearchByNumberPlateButton()
        {
            seleniumHelper.WaitElementExists(SearchByNumberPlate);
            SearchByNumberPlateButton.Click();
        }

        public void ClickOnSearchByBrandButton()
        {
            seleniumHelper.WaitElementExists(SearchByBrand);
            SearchByBrandButton.Click();
        }

        public void ClicKOnBrandField()
        {
            seleniumHelper.WaitElementExists(BrandField);
            BrandFieldElement.Click();
        }

        public void SelectVehicleBrand(string brand)
        {
            SelectElement BrandSelection = new(BrandFieldElement);
            BrandSelection.SelectByText(brand);
        }

        public void WriteVehicleBrand(string brand)
        {
            BrandFieldElement.SendKeys(brand);
            Thread.Sleep(1000);
            Driver.chromeDriver.FindElement(DebugSelection).Click();
        }

        public bool VerifyIfSavedActionsFromPreviousQuotation()
        {
            return seleniumHelper.VerifyIfElementExists(SearchByNumberPlate);
        }

        public bool VerifyIfIAmOnSearchBrandForm()
        {
            return seleniumHelper.VerifyIfElementExists(QuelleEstLaMarqueDeVotreVéhicule);
        }

        //Model element and Actions
        private static readonly By DeQuelModeleSAgitIl = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By ModelField = By.CssSelector("input[name='vehiculeModele']");

        private IWebElement ModelFieldElement
        {
            get
            {
                seleniumHelper.WaitElementExists(ModelField);
                return Driver.chromeDriver.FindElement(ModelField);
            }
        }

        public void ClickOnModelField()
        {
            ModelFieldElement.Click();
        }

        public void WriteVehicleModel(string model)
        {
            Thread.Sleep(1000);
            ModelFieldElement.SendKeys(model);
            ClickOnModelField();
            Thread.Sleep(1000);
            Driver.chromeDriver.FindElement(DebugSelection).Click();
        }

        public bool VerifyIfIAmOnSearchModelForm()
        {
            return seleniumHelper.VerifyIfElementExists(DeQuelModeleSAgitIl);
        }

        //Puissance fiscale  element and Actions
        private static readonly By QuelleEstSaPuisssanceFiscale = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By PuissanceFiscaleList = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div");


        private IWebElement PuissanceFiscaleSelect
        {
            get
            {
                seleniumHelper.WaitElementExists(PuissanceFiscaleList);
                return Driver.chromeDriver.FindElement(PuissanceFiscaleList);
            }
        }

        public void SelectPuissanceFiscale(string puissance)
        {
            seleniumHelper.WaitElementToBeClickable(PuissanceFiscaleList);
            Thread.Sleep(1000);
            PuissanceFiscaleSelect.Click();
            Thread.Sleep(1000);
            seleniumHelper.WaitElementExists(By.XPath("//div[contains(text(), '" + puissance + "')]"));
            Driver.chromeDriver.FindElement(By.XPath("//div[contains(text(), '" + puissance + "')]")).Click();
        }


        public bool VerifyIfIAmOnPuissanceFiscaleForm()
        {
            return seleniumHelper.VerifyIfElementExists(QuelleEstSaPuisssanceFiscale);
        }

        //Carburant/Energie Elements and  Actions
        private static readonly By QuelEstSonCarburant = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By CarburantList = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div");

        public void SelectCarburant(string carburant)
        {
            seleniumHelper.WaitElementExists(CarburantList);
            Thread.Sleep(1000);
            Driver.chromeDriver.FindElement(CarburantList).Click();
            Thread.Sleep(1000);
            seleniumHelper.WaitElementExists(By.XPath("//div[contains(text(), '" + carburant + "')]"));
            Driver.chromeDriver.FindElement(By.XPath("//div[contains(text(), '" + carburant + "')]")).Click();
        }

        public bool VerifyIAmOnCarburantForm()
        {
            return seleniumHelper.VerifyIfElementExists(QuelEstSonCarburant);
        }

        //Date de mise en circulation Elements and Actions
        private static readonly By QuelleEstSaDateDeMiseEnCirculation = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By Jours = By.CssSelector("input[id='vehiculeMiseEnCirculation-day']");

        private static readonly By Mois = By.CssSelector("input[id='vehiculeMiseEnCirculation-month']");

        private static readonly By Annee = By.CssSelector("input[id='vehiculeMiseEnCirculation-year']");

        private IWebElement JoursField
        {
            get
            {
                seleniumHelper.WaitElementExists(Jours);
                return Driver.chromeDriver.FindElement(Jours);
            }
        }
        private IWebElement MoisField
        {
            get
            {
                seleniumHelper.WaitElementExists(Mois);
                return Driver.chromeDriver.FindElement(Mois);
            }
        }
        private IWebElement AnneeField
        {
            get
            {
                seleniumHelper.WaitElementExists(Annee);
                return Driver.chromeDriver.FindElement(Annee);
            }
        }
        public void FillDateDeMiseEnCirculation(string date)
        {
            string jours = date.Substring(0, 2);
            string mois = date.Substring(3, 2);
            string annee = date.Substring(6, 4);
            JoursField.Click();
            JoursField.SendKeys(jours);
            MoisField.Click();
            MoisField.SendKeys(mois);
            AnneeField.Click();
            AnneeField.SendKeys(annee);
        }

        public bool VerifyIAmOnDateDeMiseEnCirculationForm()
        {
            return seleniumHelper.VerifyIfElementExists(QuelleEstSaDateDeMiseEnCirculation);
        }

        //Version element and Actions
        private static readonly By QuelleEstSaVersion = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By VersionVehicleList = By.CssSelector("input[name='vehiculeVersion']");

        public void SelectVehicleVersion(string version)
        {
            seleniumHelper.WaitElementExists(VersionVehicleList);
            Driver.chromeDriver.FindElement(VersionVehicleList).Click();
            Thread.Sleep(1000);
            Driver.chromeDriver.FindElement(VersionVehicleList).SendKeys(version);
            Thread.Sleep(1000);
            Driver.chromeDriver.FindElement(DebugSelection).Click();
        }

        public bool VerifyIfIAmOnVersionForm()
        {
            return seleniumHelper.VerifyIfElementExists(QuelleEstSaVersion);
        }

        //Found Vehicle Elements and Actions
        private static readonly By NousAvonsTrouveVotreVehicule = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By CardVehicleBrandAndModel = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/h5");

        private static readonly By CardVehicleCarburant = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/ul/li[1]/span");

        private static readonly By CardVehiclePuissance = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/ul/li[2]/span");

        private static readonly By CardVehicleDateMiseEnCirculation = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/ul/li[3]/span");

        private static readonly By CardVehicleVersion = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/ul/li[4]/span");

        public bool VerifyIfVehicleIsFound()
        {
            return seleniumHelper.VerifyIfElementExists(NousAvonsTrouveVotreVehicule);
        }

        //Date d'achat element and action
        private static readonly By IndiquezLaDateDachat = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By JoursAchat = By.CssSelector("input[id='vehiculeAcquisition-day']");

        private static readonly By MoisAchat = By.CssSelector("input[id='vehiculeAcquisition-month']");

        private static readonly By AnneeAchat = By.CssSelector("input[id='vehiculeAcquisition-year']");

        private IWebElement JoursAchatField
        {
            get
            {
                seleniumHelper.WaitElementExists(JoursAchat);
                return Driver.chromeDriver.FindElement(JoursAchat);
            }
        }
        private IWebElement MoisAchatField
        {
            get
            {
                seleniumHelper.WaitElementExists(MoisAchat);
                return Driver.chromeDriver.FindElement(MoisAchat);
            }
        }
        private IWebElement AnneeAchatField
        {
            get
            {
                seleniumHelper.WaitElementExists(AnneeAchat);
                return Driver.chromeDriver.FindElement(AnneeAchat);
            }
        }

        public void FillDateDAchat(string date)
        {
            string jours = date.Substring(0, 2);
            string mois = date.Substring(3, 2);
            string annee = date.Substring(6, 4);
            JoursAchatField.Click();
            JoursAchatField.SendKeys(jours);
            MoisAchatField.Click();
            MoisAchatField.SendKeys(mois);
            AnneeAchatField.Click();
            AnneeAchatField.SendKeys(annee);
        }

        public bool VerifyIAmOnDateDAchatForm()
        {
            return seleniumHelper.VerifyIfElementExists(QuelleEstSaDateDeMiseEnCirculation);
        }

        //Date d'assurance element and action
        private static readonly By QuandSouhaitezVousAssurer = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By JoursAssurance = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/div[2]/div/div/div[1]/div/input");

        private static readonly By MoisAssurance = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/div[2]/div/div/div[2]/div/input");

        private static readonly By AnneeAssurance = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/div[2]/div/div/div[3]/div/input");

        private IWebElement JoursAssuranceField
        {
            get
            {
                seleniumHelper.WaitElementExists(JoursAssurance);
                return Driver.chromeDriver.FindElement(JoursAssurance);
            }
        }
        private IWebElement MoisAssuranceField
        {
            get
            {
                seleniumHelper.WaitElementExists(MoisAssurance);
                return Driver.chromeDriver.FindElement(MoisAssurance);
            }
        }
        private IWebElement AnneeAssuranceField
        {
            get
            {
                seleniumHelper.WaitElementExists(AnneeAssurance);
                return Driver.chromeDriver.FindElement(AnneeAssurance);
            }
        }

        public void FillDateDAssurance(string date)
        {
            string jours = date.Substring(0, 2);
            string mois = date.Substring(3, 2);
            string annee = date.Substring(6, 4);
            JoursAssuranceField.Click();
            JoursAssuranceField.SendKeys(jours);
            MoisAssuranceField.Click();
            MoisAssuranceField.SendKeys(mois);
            AnneeAssuranceField.Click();
            AnneeAssuranceField.SendKeys(annee);
        }

        public bool VerifyIAmOnDateDAssuranceForm()
        {
            return seleniumHelper.VerifyIfElementExists(QuandSouhaitezVousAssurer);
        }

        //Vehicle Already Inssured Form element and actions
        private static readonly By VotreVehiculeEstIlAssure = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[1]/div[1]/div/div");

        private static readonly By OuiAMonNom = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]");

        private static readonly By OuiMaisPasAMonNom = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div[2]");

        private static readonly By Non = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[3]/div");

        private IWebElement OuiAMonNomRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(OuiAMonNom);
                return Driver.chromeDriver.FindElement(OuiAMonNom);
            }
        }

        private IWebElement OuiMaisPasAMonNomRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(OuiMaisPasAMonNom);
                return Driver.chromeDriver.FindElement(OuiMaisPasAMonNom);
            }
        }

        private IWebElement NonRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(Non);
                return Driver.chromeDriver.FindElement(Non);
            }
        }

        public void ClickOnRatio(string ratioMsg)
        {
            switch (ratioMsg)
            {
                case "Oui à mon nom":
                    OuiAMonNomRatio.Click();
                    break;

                case "Oui, mais pas à mon nom":
                    OuiAMonNomRatio.Click();
                    break;

                case "Non":
                    OuiAMonNomRatio.Click();
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOnDejaAssureForm()
        {
            return seleniumHelper.VerifyIfElementExists(VotreVehiculeEstIlAssure);
        }

        //AssureurActuel Element and Action
        private static readonly By VotreAssureurActuel = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By DepuisPlusDunAn = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By DepuisMoinsDunAn = By.CssSelector("input[id='vehiculeAssureDepuis-1']");

        private IWebElement DepuisPlusDunAnRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(DepuisPlusDunAn);
                return Driver.chromeDriver.FindElement(DepuisPlusDunAn);
            }
        }

        private IWebElement DepuisMoinsDunAnRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(DepuisMoinsDunAn);
                return Driver.chromeDriver.FindElement(DepuisMoinsDunAn);
            }
        }

        public void ClickOnRatioAncienAssureur(string ratioMsg)
        {
            switch (ratioMsg)
            {
                case "Depuis plus d'un an":
                    Thread.Sleep(1000);
                    DepuisPlusDunAnRatio.Click();
                    Thread.Sleep(1000);
                    break;

                case "Depuis moins d'un an":
                    DepuisMoinsDunAnRatio.Click();
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmAncienAssureurForm()
        {
            return seleniumHelper.VerifyIfElementExists(VotreAssureurActuel);
        }

        //Derniere Echéance Element and Actions
        private static readonly By QuandVotreContratArriveTIlAEcheance = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By MoisDerniereEcheance = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/div");

        private static readonly By JeNeConnaisPasCetteDate = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[3]/button");

        public void SelectMoisDerniereEcheancce(string mois)
        {
            seleniumHelper.WaitElementExists(MoisDerniereEcheance);
            Driver.chromeDriver.FindElement(MoisDerniereEcheance).Click();
            seleniumHelper.WaitElementExists(By.XPath("//div[contains(text(), '" + mois + "')]"));
            Driver.chromeDriver.FindElement(By.XPath("//div[contains(text(), '" + mois + "')]")).Click();
        }
        public bool VerifyIAmOnDerniereEcheanceForm()
        {
            return seleniumHelper.VerifyIfElementExists(QuandVotreContratArriveTIlAEcheance);
        }

        //Financement Vehicle Element and Actions
        private static readonly By CommentLAvezVousFinance = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By AuComptant = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private IWebElement AuComptantRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(AuComptant);
                return Driver.chromeDriver.FindElement(AuComptant);
            }
        }

        public void ClickOnRatioFinancement(string answer)
        {
            switch (answer)
            {
                case "Au comptant":
                    AuComptantRatio.Click();
                    Thread.Sleep(1500);
                    break;

                case "À crédit":
                    //a finir
                    break;

                case "En location longue durée (LLD)":
                    //a finir
                    break;

                case "En location avec option d'achat (LOA)":
                    //a finir
                    break;

                case "Autre (héritage, don...)":
                    //a finir
                    break;

                default:
                    break;
            }
        }
        public bool VerifyIAmOnFinancementForm()
        {
            return seleniumHelper.VerifyIfElementExists(CommentLAvezVousFinance);
        }

        //Date de Permis element and action
        private static readonly By QuelleDateAvezVousEuVotrePermis = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By JoursPermis = By.CssSelector("input[id='primaryDriver.licenseDate-day']");

        private static readonly By MoisPermis = By.CssSelector("input[id='primaryDriver.licenseDate-month");

        private static readonly By AnneePermis = By.CssSelector("input[id='primaryDriver.licenseDate-year");

        private IWebElement JoursPermisField
        {
            get
            {
                seleniumHelper.WaitElementExists(JoursPermis);
                return Driver.chromeDriver.FindElement(JoursPermis);
            }
        }
        private IWebElement MoisPermisField
        {
            get
            {
                seleniumHelper.WaitElementExists(MoisPermis);
                return Driver.chromeDriver.FindElement(MoisPermis);
            }
        }
        private IWebElement AnneePermisField
        {
            get
            {
                seleniumHelper.WaitElementExists(AnneePermis);
                return Driver.chromeDriver.FindElement(AnneePermis);
            }
        }

        public void FillDateDePermis(string date)
        {
            string jours = date.Substring(0, 2);
            string mois = date.Substring(3, 2);
            string annee = date.Substring(6, 4);
            JoursPermisField.Click();
            JoursPermisField.SendKeys(jours);
            MoisPermisField.Click();
            MoisPermisField.SendKeys(mois);
            AnneePermisField.Click();
            AnneePermisField.SendKeys(annee);
        }

        public bool VerifyIAmOnDateDePermisForm()
        {
            return seleniumHelper.VerifyIfElementExists(QuandSouhaitezVousAssurer);
        }

        //Provenance Permis délivré Element and Actions
        private static readonly By OuVotrePermisDeConduire = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By EnFrance = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private IWebElement EnFranceRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(EnFrance);
                return Driver.chromeDriver.FindElement(EnFrance);
            }
        }

        public void ClickOnRatioPermis(string answer)
        {
            switch (answer)
            {
                case "En France":
                    EnFranceRatio.Click();
                    Thread.Sleep(1500);
                    break;

                case "Dans un autre pays d'Europe":
                    //a finir
                    break;

                case "Autre":
                    //a finir
                    break;

                default:
                    break;
            }
        }
        public bool VerifyIAmOnProvenancePermisForm()
        {
            return seleniumHelper.VerifyIfElementExists(OuVotrePermisDeConduire);
        }

        //ConduiteAccompagnee Element and Action
        private static readonly By ConduiteAccompagnee = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By OuiConduiteAccompagnee = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By NonConduiteAccompagnee = By.CssSelector("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private IWebElement OuiConduiteAccompagneeRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(OuiConduiteAccompagnee);
                return Driver.chromeDriver.FindElement(OuiConduiteAccompagnee);
            }
        }

        private IWebElement NonConduiteAccompagneeRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(NonConduiteAccompagnee);
                return Driver.chromeDriver.FindElement(NonConduiteAccompagnee);
            }
        }

        public void ClickOnRatioConduiteAccompagnee(string ratioMsg)
        {
            switch (ratioMsg)
            {
                case "Oui":
                    OuiConduiteAccompagneeRatio.Click();
                    Thread.Sleep(1000);
                    break;

                case "Non":
                    NonConduiteAccompagneeRatio.Click();
                    Thread.Sleep(1000);
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmConduiteAccompagneeForm()
        {
            return seleniumHelper.VerifyIfElementExists(ConduiteAccompagnee);
        }

        //Utilisation Vehicle Element and Actions
        private static readonly By CadreUtilisezVousVotreVehicle = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By PourDesTrajetsPrivesUniquement = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By PourDesTrajetsPrivesEntreMonDomicileEtMonTravail = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private static readonly By PourDesTrajetsPrivésEtDesTrajetsProOccasionnels = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[3]/div");

        private static readonly By PourDesTrajetsToutDeplacements = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[4]/div");

        private IWebElement PourDesTrajetsPrivesUniquementRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(PourDesTrajetsPrivesUniquement);
                return Driver.chromeDriver.FindElement(PourDesTrajetsPrivesUniquement);
            }
        }
        private IWebElement PourDesTrajetsPrivesEntreMonDomicileEtMonTravailRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(PourDesTrajetsPrivesEntreMonDomicileEtMonTravail);
                return Driver.chromeDriver.FindElement(PourDesTrajetsPrivesEntreMonDomicileEtMonTravail);
            }
        }
        private IWebElement PourDesTrajetsPrivésEtDesTrajetsProOccasionnelsRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(PourDesTrajetsPrivésEtDesTrajetsProOccasionnels);
                return Driver.chromeDriver.FindElement(PourDesTrajetsPrivésEtDesTrajetsProOccasionnels);
            }
        }
        private IWebElement PourDesTrajetsToutDeplacementsRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(PourDesTrajetsToutDeplacements);
                return Driver.chromeDriver.FindElement(PourDesTrajetsToutDeplacements);
            }
        }

        public void ClickOnRatioUtilisationVehicle(string answer)
        {
            switch (answer)
            {
                case "Pour des trajets privés uniquement":
                    PourDesTrajetsPrivesUniquementRatio.Click();
                    Thread.Sleep(1000);
                    break;

                case "Pour des trajets privés entre mon domicile et mon travail":
                    PourDesTrajetsPrivesEntreMonDomicileEtMonTravailRatio.Click();
                    break;

                case "Pour des trajets privés et des trajets professionnels occasionnels":
                    PourDesTrajetsPrivésEtDesTrajetsProOccasionnelsRatio.Click();
                    break;

                case "Pour des trajets tous déplacements":
                    PourDesTrajetsToutDeplacementsRatio.Click();
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOnUtilisationVehicleForm()
        {
            return seleniumHelper.VerifyIfElementExists(CadreUtilisezVousVotreVehicle);
        }

        //Kilomètres par an elements and action
        private static readonly By CombienDeKmParAn = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By SliderKm = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div");

        public static int GetPixelsToMove(IWebElement Slider, decimal Amount, decimal SliderMax, decimal SliderMin)
        {
            int pixels = 0;
            decimal tempPixels = Slider.Size.Width;
            tempPixels = tempPixels / (SliderMax - SliderMin);
            tempPixels = tempPixels * (Amount - SliderMin);
            pixels = Convert.ToInt32(tempPixels);
            return pixels;
        }

        private IWebElement Slider
        {
            get
            {
                seleniumHelper.WaitElementExists(SliderKm);
                return Driver.chromeDriver.FindElement(SliderKm);
            }
        }

        public static int PixelsToMove(IWebElement Slider,string Km)
        {
            return GetPixelsToMove(Slider, int.Parse(Km), 50000, 1000);
        }

        private static readonly Actions SliderAction = new (Driver.chromeDriver);

        public void SelectKm(string km)
        {
            SliderAction.Click(Slider).MoveByOffset((-(int)Slider.Size.Width / 2), 0).MoveByOffset(PixelsToMove(Slider, km), 0).Release().Perform();
        }

        public  bool VerifiyIfIAmOnKmForm()
        {

            return seleniumHelper.VerifyIfElementExists(CombienDeKmParAn);
        }

        //OuGareVotreVehicle elements and  Actions
        private static readonly By LeSoirOuSeraGareVotreVehicle = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By DansLaRueOuDansUnParkingPublic = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By DansUnParkingPrive = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private static readonly By DansUnBoxPriveClos = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[3]/div");

        private IWebElement DansLaRueOuDansUnParkingPublicRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(DansLaRueOuDansUnParkingPublic);
                return Driver.chromeDriver.FindElement(DansLaRueOuDansUnParkingPublic);
            }
        }
        private IWebElement DansUnParkingPriveRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(DansUnParkingPrive);
                return Driver.chromeDriver.FindElement(DansUnParkingPrive);
            }
        }
        private IWebElement DansUnBoxPriveClosRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(DansUnBoxPriveClos);
                return Driver.chromeDriver.FindElement(DansUnBoxPriveClos);
            }
        }

        public void ClickOnRatioParkingVehicle(string answer)
        {
            switch (answer)
            {
                case "Dans la rue ou dans un parking public":
                    DansLaRueOuDansUnParkingPublicRatio.Click();
                    Thread.Sleep(1000);
                    break;

                case "Dans un parking privé clos (par exemple le parking d'une résidence à ciel ouvert mais fermé par une grille)":
                    DansUnParkingPriveRatio.Click();
                    break;

                case "Dans un box privé clos":
                    DansUnBoxPriveClosRatio.Click();
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOnParkingVehicleForm()
        {
            return seleniumHelper.VerifyIfElementExists(LeSoirOuSeraGareVotreVehicle);
        }

        //Parking Ville elements and Actions
        private static readonly By DansQuelleVille = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By CodePostal = By.CssSelector("input[id='parkingCodePostal']");

        private static readonly By Ville = By.CssSelector("");

        private IWebElement CodePostalField
        {
            get
            {
                seleniumHelper.WaitElementExists(CodePostal);
                return Driver.chromeDriver.FindElement(CodePostal);
            }
        }

        public void FillCodePostal(string codePostal)
        {
            CodePostalField.Click();
            CodePostalField.SendKeys(codePostal);
            Thread.Sleep(1500);
        }

        public bool VerifyIAmOnParkingVilleForm()
        {
            return seleniumHelper.VerifyIfElementExists(DansQuelleVille);
        }

        //Logement elements and Actions
        private static readonly By VousLogezDans = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By UneMaison = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By UnAppartement = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private static readonly By Autre = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[3]/div");

        private IWebElement UneMaisonRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(UneMaison);
                return Driver.chromeDriver.FindElement(UneMaison);
            }
        }
        private IWebElement UnAppartementRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(UnAppartement);
                return Driver.chromeDriver.FindElement(UnAppartement);
            }
        }
        private IWebElement AutreRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(Autre);
                return Driver.chromeDriver.FindElement(Autre);
            }
        }

        public void ClickOnRatioResidence(string answer)
        {
            switch (answer)
            {
                case "Une maison":
                    UneMaisonRatio.Click();
                    Thread.Sleep(1000);
                    break;

                case "Un appartement":
                    UnAppartementRatio.Click();
                    Thread.Sleep(1000);
                    break;

                case "Autre":
                    AutreRatio.Click();
                    Thread.Sleep(1000);
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOnResidenceForm()
        {
            return seleniumHelper.VerifyIfElementExists(VousLogezDans);
        }

        //OwnerResidence Element and Action
        private static readonly By ProprietaireDeVotreLogement = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By OuiOwner = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By NonOwner = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private IWebElement OuiOwnerRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(OuiOwner);
                return Driver.chromeDriver.FindElement(OuiOwner);
            }
        }

        private IWebElement NonOwnerRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(NonOwner);
                return Driver.chromeDriver.FindElement(NonOwner);
            }
        }

        public void ClickOnRatioOwnerResidence(string ratioMsg)
        {
            switch (ratioMsg)
            {
                case "Oui":
                    OuiOwnerRatio.Click();
                    break;

                case "Non":
                    NonOwnerRatio.Click();
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOwnerResidenceForm()
        {
            return seleniumHelper.VerifyIfElementExists(ProprietaireDeVotreLogement);
        }

        //CarteGriseAVotreNom Element and Action
        private static readonly By CarteGriseAVotreNom = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By OuiAlone = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By NonAlone = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private IWebElement OuiAloneRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(OuiAlone);
                return Driver.chromeDriver.FindElement(OuiAlone);
            }
        }

        private IWebElement NonAloneRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(NonAlone);
                return Driver.chromeDriver.FindElement(NonAlone);
            }
        }

        public void ClickOnRatioAloneCarteGrise(string ratioMsg)
        {
            switch (ratioMsg)
            {
                case "Oui":
                    Thread.Sleep(1000);
                    OuiAloneRatio.Click();
                    break;

                case "Non":
                    Thread.Sleep(1000);
                    NonAloneRatio.Click();
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOnAloneCarteGriseForm()
        {
            return seleniumHelper.VerifyIfElementExists(CarteGriseAVotreNom);
        }

        //AssurancePeriode Element and Actions
        private static readonly By AvezVousEteAssurePeriode = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By NonJamaisAssureDeMavie = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By NonPasSurCettePeriode = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private static readonly By OuiMaisPasPendantTouteLaPeriode = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[3]/div");

        private static readonly By OuiEnContinuSurTouteLaPeriode = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[4]/div");

        private IWebElement NonJamaisAssureDeMavieRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(NonJamaisAssureDeMavie);
                return Driver.chromeDriver.FindElement(NonJamaisAssureDeMavie);
            }
        }
        private IWebElement NonPasSurCettePeriodeRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(NonPasSurCettePeriode);
                return Driver.chromeDriver.FindElement(NonPasSurCettePeriode);
            }
        }
        private IWebElement OuiMaisPasPendantTouteLaPeriodeRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(OuiMaisPasPendantTouteLaPeriode);
                return Driver.chromeDriver.FindElement(OuiMaisPasPendantTouteLaPeriode);
            }
        }
        private IWebElement OuiEnContinuSurTouteLaPeriodeRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(OuiEnContinuSurTouteLaPeriode);
                return Driver.chromeDriver.FindElement(OuiEnContinuSurTouteLaPeriode);
            }
        }

        public void ClickOnRatioPeriodeAssurance(string answer)
        {
            switch (answer)
            {
                case "Non, je n'ai jamais été assuré de ma vie":
                    NonJamaisAssureDeMavieRatio.Click();
                    break;

                case "Non, pas sur cette période":
                    NonPasSurCettePeriodeRatio.Click();
                    break;

                case "Oui, mais pas pendant toute la période":
                    OuiMaisPasPendantTouteLaPeriodeRatio.Click();
                    break;

                case "Oui, en continu sur toute la période":
                    OuiEnContinuSurTouteLaPeriodeRatio.Click();
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOnPeriodeAssuranceForm()
        {
            return seleniumHelper.VerifyIfElementExists(AvezVousEteAssurePeriode);
        }

        //Bonus Malus element and Actions
        private static readonly By QuelEstVotreBonusMalus = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By BonusMalus = By.CssSelector("input[name='primaryDriver.crm']");

        private IWebElement BonusMalusElement
        {
            get
            {
                seleniumHelper.WaitElementExists(BonusMalus);
                return Driver.chromeDriver.FindElement(BonusMalus);
            }
        }

        public void ClickOnBonusMalusField()
        {
            BonusMalusElement.Click();
        }

        public void WriteBonusMalus(string bonusMalus)
        {
            ClickOnBonusMalusField();
            BonusMalusElement.SendKeys(bonusMalus);
            Thread.Sleep(1000);
            Driver.chromeDriver.FindElement(DebugSelection).Click();
        }

        public bool VerifyIfIAmOnSearchBonusMalusForm()
        {
            return seleniumHelper.VerifyIfElementExists(QuelEstVotreBonusMalus);
        }

        //ContratResilie Element and Action
        private static readonly By VotreContratATIlEteResilie = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By OuiContratResilie = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private static readonly By NonContratResilie = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private IWebElement OuiContratResilieRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(OuiContratResilie);
                return Driver.chromeDriver.FindElement(OuiContratResilie);
            }
        }

        private IWebElement NonContratResilieRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(NonContratResilie);
                return Driver.chromeDriver.FindElement(NonContratResilie);
            }
        }

        public void ClickOnRatioContratResilie(string ratioMsg)
        {
            switch (ratioMsg)
            {
                case "Oui":
                    Thread.Sleep(1000);
                    OuiContratResilieRatio.Click();
                    break;

                case "Non":
                    Thread.Sleep(1000);
                    NonContratResilieRatio.Click();
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOnContratResilieForm()
        {
            return seleniumHelper.VerifyIfElementExists(VotreContratATIlEteResilie);
        }

        //PermisSuspendu elements and Actions
        private static readonly By VotrePermisDeConduire = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By NonPermisSuspendu = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By OuiSuspendu       = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private static readonly By OuiAnnule = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[3]/div");

        private IWebElement NonPermisSuspenduRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(NonPermisSuspendu);
                return Driver.chromeDriver.FindElement(NonPermisSuspendu);
            }
        }
        private IWebElement OuiSuspenduRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(OuiSuspendu);
                return Driver.chromeDriver.FindElement(OuiSuspendu);
            }
        }
        private IWebElement OuiAnnuleRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(OuiAnnule);
                return Driver.chromeDriver.FindElement(OuiAnnule);
            }
        }

        public void ClickOnRatioPermisSuspendu(string answer)
        {
            switch (answer)
            {
                case "Non":
                    Thread.Sleep(1000);
                    NonPermisSuspenduRatio.Click();
                    Thread.Sleep(1000);
                    break;

                case "Oui, suspendu":
                    Thread.Sleep(1000);
                    OuiSuspenduRatio.Click();
                    Thread.Sleep(1000);
                    break;

                case "Oui, annulé":
                    Thread.Sleep(1000);
                    OuiAnnuleRatio.Click();
                    Thread.Sleep(1000);
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOnPermisSuspenduForm()
        {
            return seleniumHelper.VerifyIfElementExists(VotrePermisDeConduire);
        }

        //Sinistres elements and Actions
        private static readonly By AvesVousDeclareDesSinitres = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div/div/h4");

        private static readonly By NonAucunSinistre = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By OuiUnSinistre = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private static readonly By OuiPlusieursSinistres = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[3]/div");

        private IWebElement NonAucunSinistreRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(NonAucunSinistre);
                return Driver.chromeDriver.FindElement(NonAucunSinistre);
            }
        }
        private IWebElement OuiUnSinistreRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(OuiUnSinistre);
                return Driver.chromeDriver.FindElement(OuiUnSinistre);
            }
        }
        private IWebElement OuiPlusieursSinistresRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(OuiPlusieursSinistres);
                return Driver.chromeDriver.FindElement(OuiPlusieursSinistres);
            }
        }

        public void ClickOnRatioSinistres(string answer)
        {
            switch (answer)
            {
                case "Non, aucun":
                    NonAucunSinistreRatio.Click();
                    Thread.Sleep(1000);
                    break;

                case "Oui, un":
                    OuiUnSinistreRatio.Click();
                    Thread.Sleep(1000);
                    break;

                case "Oui, plusieurs":
                    OuiPlusieursSinistresRatio.Click();
                    Thread.Sleep(1000);
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOnSinistresForm()
        {
            return seleniumHelper.VerifyIfElementExists(AvesVousDeclareDesSinitres);
        }

        //AutreConducteur Element and Action
        private static readonly By AutreConducteurBeneficie = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By OuiAutreConducteur = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[1]/div");

        private static readonly By NonAutreConducteur = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div/div/label[2]/div");

        private IWebElement OuiAutreConducteurRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(OuiAutreConducteur);
                return Driver.chromeDriver.FindElement(OuiAutreConducteur);
            }
        }

        private IWebElement NonAutreConducteurRatio
        {
            get
            {
                seleniumHelper.VerifyIfElementExists(NonAutreConducteur);
                return Driver.chromeDriver.FindElement(NonAutreConducteur);
            }
        }

        public void ClickOnRatioAutreConducteur(string ratioMsg)
        {
            switch (ratioMsg)
            {
                case "Oui":
                    Thread.Sleep(1000);
                    OuiAutreConducteurRatio.Click();
                    break;

                case "Non":
                    Thread.Sleep(1000);
                    NonAutreConducteurRatio.Click();
                    break;

                default:
                    break;
            }
        }

        public bool VerifyIAmOnAutreConducteurForm()
        {
            return seleniumHelper.VerifyIfElementExists(AutreConducteurBeneficie);
        }

        //Infos résumé élément and actions
        private static readonly By TarifPret = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[1]/div[2]/div/h4");

        private static readonly By MonVehicule = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div[1]/span");

        private static readonly By MaConduiteTypeTrajet = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div[2]/span");

        private static readonly By MaConduiteLocalisation = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div[3]/span");

        private static readonly By MesInfos = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div[4]/span");

        private static readonly By ConfirmerResume = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[2]/button/div");

        private static readonly By Socials = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/footer/div[1]/div[2]/div[2]");

        private IWebElement ConfirmerResumeButton
        {
            get
            {
                seleniumHelper.WaitElementExists(ConfirmerResume);
                return Driver.chromeDriver.FindElement(ConfirmerResume);
            }
        }

        private IWebElement SocialsElement
        {
            get
            {
                seleniumHelper.WaitElementExists(Socials);
                return Driver.chromeDriver.FindElement(Socials);
            }
        }


        public void MoveToConfirmerButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.chromeDriver;
            js.ExecuteScript("arguments[0].click();", ConfirmerResumeButton);
        }

        public void ClickOnConfirmerResumeButton()
        {
            Thread.Sleep(5000);
            ConfirmerResumeButton.Click();
        }


        public bool VerifyIfIAmOnTarifPret()
        {
            return seleniumHelper.VerifyIfElementExists(TarifPret);
        }

        //Identité Form Element and Actions
        private static readonly By Prenom = By.CssSelector("input[id='primaryDriver.firstName']");

        private static readonly By Nom = By.CssSelector("input[id='primaryDriver.lastName']");

        private static readonly By M = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div[2]/div[1]/div[2]/label[1]/div");

        private static readonly By Mme = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div[2]/div[1]/div[2]/label[2]/div");

        private static readonly By JourDeNaissance = By.CssSelector("input[id='primaryDriver.birthDate-day']");

        private static readonly By MoisDeNaissance = By.CssSelector("input[id='primaryDriver.birthDate-month']");

        private static readonly By AnneeDeNaissance = By.CssSelector("input[id='primaryDriver.birthDate-year']");

        private static readonly By VilleDeNaissance = By.CssSelector("input[id='primaryDriver.birthCity']");

        private static readonly By PaysDeNaisssance = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div[3]/div[2]/div[2]");

        private static readonly By Profession = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div[4]/div[1]/div/div[2]");

        private static readonly By StatutMarital = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[1]/div[4]/div[2]/div/div[2]");

        private static readonly By EmailSub = By.CssSelector("input[id='subscriberEmail']");

        private static readonly By NumeroMobile = By.CssSelector("input[name='subscriberPhone']");

        private static readonly By Adresse = By.XPath("//*[@id=\"downshift-4-input\"]");

        private static readonly By AccepteCGU = By.XPath("//*[@id=\"privacyPolicyAccepted\"]");

        private static readonly By AccepteNewsletter = By.XPath("//*[@id=\"hasAcceptedCommercialCommunication\"]");

        private static readonly By ObtenirMonTarif = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[2]/button");

        private IWebElement PrenomField
        {
            get
            {
                seleniumHelper.WaitElementExists(Prenom);
                return Driver.chromeDriver.FindElement(Prenom);
            }
        }

        private IWebElement NomField
        {
            get
            {
                seleniumHelper.WaitElementExists(Nom);
                return Driver.chromeDriver.FindElement(Nom);
            }
        }
        private IWebElement MRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(M);
                return Driver.chromeDriver.FindElement(M);
            }
        }
        private IWebElement MmeRatio
        {
            get
            {
                seleniumHelper.WaitElementExists(Mme);
                return Driver.chromeDriver.FindElement(Mme);
            }
        }
        private IWebElement JourDeNaissanceField
        {
            get
            {
                seleniumHelper.WaitElementExists(JourDeNaissance);
                return Driver.chromeDriver.FindElement(JourDeNaissance);
            }
        }
        private IWebElement MoisDeNaissanceField
        {
            get
            {
                seleniumHelper.WaitElementExists(MoisDeNaissance);
                return Driver.chromeDriver.FindElement(MoisDeNaissance);
            }
        }
        private IWebElement AnneeDeNaissanceField
        {
            get
            {
                seleniumHelper.WaitElementExists(AnneeDeNaissance);
                return Driver.chromeDriver.FindElement(AnneeDeNaissance);
            }
        }
        private IWebElement VilleDeNaissanceField
        {
            get
            {
                seleniumHelper.WaitElementExists(VilleDeNaissance);
                return Driver.chromeDriver.FindElement(VilleDeNaissance);
            }
        }
        private IWebElement PaysDeNaisssanceSelect
        {
            get
            {
                seleniumHelper.WaitElementExists(PaysDeNaisssance);
                return Driver.chromeDriver.FindElement(PaysDeNaisssance);
            }
        }
        private IWebElement ProfessionSelect
        {
            get
            {
                seleniumHelper.WaitElementExists(Profession);
                return Driver.chromeDriver.FindElement(Profession);
            }
        }
        private IWebElement StatutMaritalSelect
        {
            get
            {
                seleniumHelper.WaitElementExists(StatutMarital);
                return Driver.chromeDriver.FindElement(StatutMarital);
            }
        }
        private IWebElement EmailSubField
        {
            get
            {
                seleniumHelper.WaitElementExists(EmailSub);
                return Driver.chromeDriver.FindElement(EmailSub);
            }
        }
        private IWebElement NumeroMobileField
        {
            get
            {
                seleniumHelper.WaitElementExists(NumeroMobile);
                return Driver.chromeDriver.FindElement(NumeroMobile);
            }
        }

        private IWebElement AdresseField
        {
            get
            {
                seleniumHelper.WaitElementExists(Adresse);
                return Driver.chromeDriver.FindElement(Adresse);
            }
        }

        private IWebElement AccepteCGUCheckBox
        {
            get
            {
                seleniumHelper.WaitElementExists(AccepteCGU);
                return Driver.chromeDriver.FindElement(AccepteCGU);
            }
        }

        private IWebElement AccepteNewsletterCheckBox
        {
            get
            {
                seleniumHelper.WaitElementExists(AccepteNewsletter);
                return Driver.chromeDriver.FindElement(AccepteNewsletter);
            }
        }

        private IWebElement ObtenirMonTarifButton
        {
            get
            {
                seleniumHelper.WaitElementExists(ObtenirMonTarif);
                return Driver.chromeDriver.FindElement(ObtenirMonTarif);
            }
        }

        public void FillPrenomAndNomm(string prenom, string nom)
        {
            PrenomField.Click();
            PrenomField.SendKeys(prenom);
            Thread.Sleep(500);
            NomField.Click();
            NomField.SendKeys(nom);
        }

        public void SelectCivility(string civility)
        {
            switch (civility)
            {
                case "M.":
                    MRatio.Click();
                    Thread.Sleep(500);
                    break;

                case "Mme.":
                    MmeRatio.Click();
                    Thread.Sleep(500);
                    break;

                default:
                    break;
            }
        }

        public void FillBirthdateAndBirthcity(string birthdate,string birthcity) 
        {
            string jours = birthdate.Substring(0, 2);
            string mois = birthdate.Substring(3, 2);
            string annee = birthdate.Substring(6, 4);
            JourDeNaissanceField.Click();
            JourDeNaissanceField.SendKeys(jours);
            MoisDeNaissanceField.Click();
            MoisDeNaissanceField.SendKeys(mois);
            AnneeDeNaissanceField.Click();
            AnneeDeNaissanceField.SendKeys(annee);
            Thread.Sleep(500);
            VilleDeNaissanceField.Click();
            VilleDeNaissanceField.SendKeys(birthcity);
            Thread.Sleep(500);
        }

        public void SelectPaysDeNaissance(string pays)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.chromeDriver;
            PaysDeNaisssanceSelect.Click();
            seleniumHelper.WaitElementExists(By.XPath("//div[contains(text(), '" + pays + "')]"));
            js.ExecuteScript("arguments[0].click();", Driver.chromeDriver.FindElement(By.XPath("//div[contains(text(), '" + pays + "')]")));
            Thread.Sleep(500);
        }

        public void SelectProfession(string profession)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.chromeDriver;
            ProfessionSelect.Click();
            seleniumHelper.WaitElementExists(By.XPath("//div[contains(text(), '" + profession + "')]"));
            js.ExecuteScript("arguments[0].click();", Driver.chromeDriver.FindElement(By.XPath("//div[contains(text(), '" + profession + "')]")));
            Thread.Sleep(500);
        }

        public void SelectStatutMarital(string statutMarital)
        {
            StatutMaritalSelect.Click();
            seleniumHelper.WaitElementExists(By.XPath("//div[contains(text(), '" + statutMarital + "')]"));
            Driver.chromeDriver.FindElement(By.XPath("//div[contains(text(), '" + statutMarital + "')]")).Click();
            Thread.Sleep(500);
        }

        public void FillEmailSub(string email)
        {
            EmailSubField.Click();
            EmailSubField.SendKeys(email);
            Thread.Sleep(500);
        }

        public void FillNumeroMobile(string numero)
        {
            NumeroMobileField.Click();
            NumeroMobileField.SendKeys(numero);
            Thread.Sleep(500);
        }

        public void FillAdressePostal(string adresse)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.chromeDriver;
            js.ExecuteScript("arguments[0].scrollIntoView();", ObtenirMonTarifButton);
            Thread.Sleep(1000);
            AdresseField.Click();
            AdresseField.SendKeys(adresse);
            Thread.Sleep(1000);
            Driver.chromeDriver.FindElement(DebugSelection).Click();
        }

        public void CheckCgu()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.chromeDriver;
            js.ExecuteScript("arguments[0].click();", AccepteCGUCheckBox);
            Thread.Sleep(500);
        }

        public void CheckNewsletter(string option)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.chromeDriver;

            switch (option)
            {
                case "true":
                    js.ExecuteScript("arguments[0].click();", AccepteNewsletterCheckBox);
                    Thread.Sleep(500);
                    break;

                default:
                    break;
            }
        }

        public void ClickOnObtenirMonTarifButton()
        {
            Thread.Sleep(3500);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.chromeDriver;
            js.ExecuteScript("arguments[0].click();", ObtenirMonTarifButton);
        }

        public bool VerifyIAmOnIdForm()
        {
            return seleniumHelper.VerifyIfElementExists(Prenom);
        }

        //Final Quotation Page Element and Actions
        private static readonly By ComparisonSection = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div/div[1]");

        public bool VerifiyIfIAmOnComparison()
        {
            seleniumHelper.WaitElementExists(ComparisonSection);
            return seleniumHelper.VerifyIfElementExists(ComparisonSection);
        }

        //Save and finish later Elements and Actions
        private static readonly By EnregistrerEtFinirPlusTard = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[1]/div[1]/div/div");

        private static readonly By NotificationSavedForLater = By.XPath("");

        private IWebElement EnregistrerEtFinirPlusTardButton
        {
            get
            {
                return Driver.chromeDriver.FindElement(EnregistrerEtFinirPlusTard);
            }
        }

        public void ClickOnEnregistrerEtFinirPlusTardButton()
        {
            seleniumHelper.WaitElementExists(EnregistrerEtFinirPlusTard);
            EnregistrerEtFinirPlusTardButton.Click();
        }

        //Alert Pop-Up element and action
        public void AcceptAlert()
        {
            Driver.chromeDriver.SwitchTo().Alert().Accept();
        }

        //login elemment and action
        private static string TestEmail = "randomcryptouser@gmail.com";
        private static string Password = "Test!12345678";

        private static readonly By EmailField = By.CssSelector("input[id='email']");
        private static readonly By PasswordField = By.CssSelector("input[id='password']");
        private static readonly By JeMeConnecte = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/div/div[2]/div/div/div/form/div[5]/button");
        private static readonly By ForgottenPassword = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/div/div[2]/div/div/div/form/div[6]/a");
        private static readonly By ConnexionAvecFacebook = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/div/div[2]/div/div/div/div[2]");
        private static readonly By SeSouvenirDeMoi = By.CssSelector("input[id='remember-checkbox-id']");

        private IWebElement EmailFieldElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(EmailField);
            }
        }

        private IWebElement PasswordFieldElement
        {
            get
            {
                return Driver.chromeDriver.FindElement(PasswordField);
            }
        }

        private IWebElement JemeConnecteButton
        {
            get
            {
                return Driver.chromeDriver.FindElement(JeMeConnecte);
            }
        }

        private IWebElement ForgottenPasswordButton
        {
            get
            {
                return Driver.chromeDriver.FindElement(ForgottenPassword);
            }
        }

        private IWebElement ConnexionAvecFacebookButton
        {
            get
            {
                return Driver.chromeDriver.FindElement(ConnexionAvecFacebook);
            }
        }

        private IWebElement SeSouvenirDeMoiCheckBox
        {
            get
            {
                return Driver.chromeDriver.FindElement(SeSouvenirDeMoi);
            }
        }
      
        public void ClickOnEmailField()
        {
            seleniumHelper.WaitElementExists(EmailField);
            EmailFieldElement.Click();
        }

        public void ClickOnPasswordField()
        {
            seleniumHelper.WaitElementExists(PasswordField);
            PasswordFieldElement.Click();
        }

        public void ClickOnJeMeConnecteButton()
        {
            seleniumHelper.WaitElementExists(JeMeConnecte);
            JemeConnecteButton.Click();
        }

        public void ClickOnForgottenPassword()
        {
            seleniumHelper.WaitElementExists(ForgottenPassword);
            ForgottenPasswordButton.Click();
        }

        public void ClickOnConnexionAvecFacebook()
        {
            seleniumHelper.WaitElementExists(ConnexionAvecFacebook);
            ConnexionAvecFacebookButton.Click();
        }

        public void ClickOnSeSouvenirDeMoiCheckBox()
        {
            seleniumHelper.WaitElementExists(SeSouvenirDeMoi);
            SeSouvenirDeMoiCheckBox.Click();
        }

        public void WriteEmail()
        {
            PasswordFieldElement.SendKeys(TestEmail);
        }

        public void WritePassword()
        {
            PasswordFieldElement.SendKeys(Password);
        }

        //Continuer and Confirmer Button
        private static readonly By Continuer = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[3]/button");

        private static readonly By Confirmer = By.XPath("//*[@id=\"__next\"]/div/div[1]/div[2]/form/div[2]/div/div[2]/button");
        private IWebElement ContinuerButton
        {
            get
            {
                return Driver.chromeDriver.FindElement(Continuer);
            }
        }

        private IWebElement ConfirmerButton
        {
            get
            {
                return Driver.chromeDriver.FindElement(Confirmer);
            }
        }

        public void ClickOnContinuerButton()
        {
            seleniumHelper.WaitElementExists(Continuer);
            ContinuerButton.Click();
        }

        public void ClickOnConfirmerButton()
        {
            seleniumHelper.WaitElementExists(Confirmer);
            Thread.Sleep(10000);
            ConfirmerButton.Click();
        }

    }
}
