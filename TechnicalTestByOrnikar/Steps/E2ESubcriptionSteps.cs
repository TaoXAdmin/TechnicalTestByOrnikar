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
     class E2ESubcriptionSteps
    {

        SouscriptionPageValidations souscriptionPageValidations = new ();
        SouscriptionPageObject souscriptionPageObject = new ();

        [Given(@"I am on Souscription page")]
        public void GivenIAmOnSouscriptionPage()
        {
            souscriptionPageValidations.NavigateToOrnikarSouscriptionPageResetTrue();
            Assert.That(souscriptionPageValidations.LandedOnOrnikarSouscriptionPageResetTrue());
            Thread.Sleep(1000);
            souscriptionPageObject.ClickContinuerAccepterLesCookies();
        }

        [Given(@"I clicked on déjà enrigistré option ""([^""]*)""")]
        public void GivenIClickedOnDejaEnrigistreOption(string non)
        {
            switch (non)
            {
                case "Oui":
                    souscriptionPageObject.ClickOnOuiAnswerButton();
                    break;

                case "Non":
                    souscriptionPageObject.ClickOnNonAnswerButton();
                    break;

                default:
                    break;
            }
        }

        [When(@"I click on Rechercher par marque")]
        public void WhenIClickOnRechercherParMarque()
        {
            souscriptionPageObject.ClickOnSearchByBrandButton();
        }

        [Then(@"I am on search by brand form")]
        public void ThenIAmOnSearchByBrandForm()
        {
            Assert.That(souscriptionPageObject.VerifyIfIAmOnSearchBrandForm());
        }

        [Then(@"I enter a brand ""([^""]*)""")]
        public void ThenIEnterABrand(string vOLKSWAGEN)
        {
            souscriptionPageObject.ClicKOnBrandField();
            souscriptionPageObject.WriteVehicleBrand(vOLKSWAGEN);
        }

        [Then(@"I am on search model form")]
        public void ThenIAmOnSearchModelForm()
        {
            Assert.That(souscriptionPageObject.VerifyIfIAmOnSearchModelForm());
        }

        [Then(@"I click on model list")]
        public void ThenIClickOnModelList()
        {
            souscriptionPageObject.ClickOnModelField();
        }

        [Then(@"I select a model ""([^""]*)""")]
        public void ThenISelectAModel(string p0)
        {
            souscriptionPageObject.WriteVehicleModel(p0);
        }

        [Then(@"I am on puissance fiscale form")]
        public void ThenIAmOnPuissanceFiscaleForm()
        {
            Assert.That(souscriptionPageObject.VerifyIfIAmOnPuissanceFiscaleForm());
        }


        [Then(@"I select my puissance fiscale ""([^""]*)""")]
        public void ThenISelectMyPuissanceFiscale(string p0)
        {
            souscriptionPageObject.SelectPuissanceFiscale(p0);
        }

        [Then(@"I click on Continuer button")]
        public void ThenIClickOnContinuerButton()
        {
            souscriptionPageObject.ClickOnContinuerButton();
        }

        [Then(@"I am on carburant/énergie form")]
        public void ThenIAmOnCarburantEnergieForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnCarburantForm());
        }

        [Then(@"I select my carburant ""([^""]*)""")]
        public void ThenISelectMyCarburant(string eSSENCE)
        {
            souscriptionPageObject.SelectCarburant(eSSENCE);
        }

        [Then(@"I am on date de mise en circulation")]
        public void ThenIAmOnDateDeMiseEnCirculation()
        {
            souscriptionPageObject.VerifyIAmOnDateDeMiseEnCirculationForm();
        }

        [Then(@"I fill date de mise en circulation ""([^""]*)""")]
        public void ThenIFillDateDeMiseEnCirculation(string p0)
        {
            souscriptionPageObject.FillDateDeMiseEnCirculation(p0);
        }
        [Then(@"I click on Continuer")]
        public void ThenIClickOnContinuer()
        {
            souscriptionPageObject.ClickOnContinuerButton();
        }


        [Then(@"I am on Quelle est sa version")]
        public void ThenIAmOnQuelleEstSaVersion()
        {
            Assert.That(souscriptionPageObject.VerifyIfIAmOnVersionForm());
        }

        [Then(@"I select version ""([^""]*)""")]
        public void ThenISelectVersion(string p0)
        {
            souscriptionPageObject.SelectVehicleVersion(p0);
        }

        [Then(@"my vehicle is found")]
        public void ThenMyVehicleIsFound()
        {
            Assert.That(souscriptionPageObject.VerifyIfVehicleIsFound());
        }

        [Then(@"I click on Confirmer")]
        public void ThenIClickOnConfirmer()
        {
            souscriptionPageObject.ClickOnConfirmerButton();
        }

        [Then(@"I am on date d'achat form")]
        public void ThenIAmOnDateDachatForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnDateDAchatForm());
        }

        [Then(@"I fill date d achat ""([^""]*)""")]
        public void ThenIFillDateDAchat(string p0)
        {
            souscriptionPageObject.FillDateDAchat(p0);
        }

        [Then(@"I am on date d'assurance du véhicule form")]
        public void ThenIAmOnDateDassuranceDuVehiculeForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnDateDAssuranceForm());
        }

        [Then(@"I fill date d asssurance souhaité ""([^""]*)""")]
        public void ThenIFillDateDAsssuranceSouhaite(string p0)
        {
            souscriptionPageObject.FillDateDAssurance(p0);
        }

        [Then(@"I am on votre véhicule est-il assuré form")]
        public void ThenIAmOnVotreVehiculeEst_IlAssureForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnDejaAssureForm());
        }

        [Then(@"I select véhicule déjà assuré option ""([^""]*)""")]
        public void ThenISelectVehiculeDejaAssureOption(string p0)
        {
            souscriptionPageObject.ClickOnRatio(p0);
        }

        [Then(@"I am on Depuis quand êtes-vous chez votre assureur actuel form")]
        public void ThenIAmOnDepuisQuandEtes_VousChezVotreAssureurActuelForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmAncienAssureurForm());
        }

        [Then(@"I click on ancien assureur date option ""([^""]*)""")]
        public void ThenIClickOnAncienAssureurDateOption(string p0)
        {
            souscriptionPageObject.ClickOnRatioAncienAssureur(p0);
        }

        [Then(@"I am on Quand votre contrat arrive-t-il à échéance form")]
        public void ThenIAmOnQuandVotreContratArrive_T_IlAEcheanceForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnDerniereEcheanceForm());
        }

        [Then(@"I select date dernière échéance ""([^""]*)""")]
        public void ThenISelectDateDerniereEcheance(string p0)
        {
            souscriptionPageObject.SelectMoisDerniereEcheancce(p0);
        }

        [Then(@"I am on Comment l'avez vous financé form")]
        public void ThenIAmOnCommentLavezVousFinanceForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnFinancementForm());

        }

        [Then(@"I select financement option ""([^""]*)""")]
        public void ThenISelectFinancementOption(string p0)
        {
            souscriptionPageObject.ClickOnRatioFinancement(p0);
        }

        [Then(@"I am on date du permis")]
        public void ThenIAmOnDateDuPermis()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnDateDePermisForm());
        }

        [Then(@"I fill date du permis ""([^""]*)""")]
        public void ThenIFillDateDuPermis(string p0)
        {
            souscriptionPageObject.FillDateDePermis(p0);
        }

        [Then(@"I am on où votre premis de conduire a-t-il été délivré form")]
        public void ThenIAmOnOuVotrePremisDeConduireA_T_IlEteDelivreForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnProvenancePermisForm());
        }

        [Then(@"I select pays permis délivré ""([^""]*)""")]
        public void ThenISelectPaysPermisDelivre(string p0)
        {
            souscriptionPageObject.ClickOnRatioPermis(p0);
        }

        [Then(@"I am on Avez-vous fait de la conduite accompagnée form")]
        public void ThenIAmOnAvez_VousFaitDeLaConduiteAccompagneeForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmConduiteAccompagneeForm());
        }

        [Then(@"I click on conduite accompagnée option ""([^""]*)""")]
        public void ThenIClickOnConduiteAccompagneeOption(string oui)
        {
            souscriptionPageObject.ClickOnRatioConduiteAccompagnee(oui);
        }

        [Then(@"I am on Dans quel cadre utilisez-vous votre véhicule form")]
        public void ThenIAmOnDansQuelCadreUtilisez_VousVotreVehiculeForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnUtilisationVehicleForm());
        }

        [Then(@"I select utilisation du véhicule option ""([^""]*)""")]
        public void ThenISelectUtilisationDuVehiculeOption(string p0)
        {
            souscriptionPageObject.ClickOnRatioUtilisationVehicle(p0);
        }

        [Then(@"I am on combien de kilomètres faites-vous par an form")]
        public void ThenIAmOnCombienDeKilometresFaites_VousParAn()
        {
            Assert.That(souscriptionPageObject.VerifiyIfIAmOnKmForm());
        }

        [Then(@"I select km estimé ""([^""]*)""")]
        public void ThenISelectKmEstime(string p0)
        {
            souscriptionPageObject.SelectKm(p0);
        }

        [Then(@"I am on Le soir, où sera garé votre véhicule form")]
        public void ThenIAmOnLeSoirOuSeraGareVotreVehiculeForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnParkingVehicleForm());
        }

        [Then(@"I select parking option ""([^""]*)""")]
        public void ThenISelectParkingOption(string p0)
        {
            souscriptionPageObject.ClickOnRatioParkingVehicle(p0);
        }

        [Then(@"I am on Dans quelle ville form")]
        public void ThenIAmOnDansQuelleVilleForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnParkingVilleForm());

        }

        [Then(@"I fill postalcode ""([^""]*)""")]
        public void ThenIFillPostalcode(string p0)
        {
            souscriptionPageObject.FillCodePostal(p0);
        }

        [Then(@"I am on Vous loger dans\.\.\. form")]
        public void ThenIAmOnVousLogerDans_Form()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnResidenceForm());
        }

        [Then(@"I select residence option ""([^""]*)""")]
        public void ThenISelectResidenceOption(string p0)
        {
            souscriptionPageObject.ClickOnRatioResidence(p0);
        }

        [Then(@"I am on Êtes-vous propriétaire de votre logement form")]
        public void ThenIAmOnEtes_VousProprietaireDeVotreLogementForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOwnerResidenceForm());
        }

        [Then(@"I select propriétaire résidence option ""([^""]*)""")]
        public void ThenISelectProprietaireResidenceOption(string non)
        {
           souscriptionPageObject.ClickOnRatioOwnerResidence(non);
        }

        [Then(@"I am on La carte grise du véhicule est-elle uniquement à votre nom form")]
        public void ThenIAmOnLaCarteGriseDuVehiculeEst_ElleUniquementAVotreNomForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnAloneCarteGriseForm());
        }

        [Then(@"I select carte grise nom option ""([^""]*)""")]
        public void ThenISelectCarteGriseNomOption(string oui)
        {
           souscriptionPageObject.ClickOnRatioAloneCarteGrise(oui);
        }

        [Then(@"I am on Avez-vous été assuré")]
        public void ThenIAmOnAvez_VousEteAssure()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnPeriodeAssuranceForm());
        }

        [Then(@"I select déjà assuré option ""([^""]*)""")]
        public void ThenISelectDejaAssureOption(string p0)
        {
            souscriptionPageObject.ClickOnRatioPeriodeAssurance(p0);
        }

        [Then(@"I am on Quel est votre bonus malus form")]
        public void ThenIAmOnQuelEstVotreBonusMalusForm()
        {
            Assert.That(souscriptionPageObject.VerifyIfIAmOnSearchBonusMalusForm());
        }

        [Then(@"I select  bonus malus option ""([^""]*)""")]
        public void ThenISelectBonusMalusOption(string p0)
        {
            souscriptionPageObject.WriteBonusMalus(p0);
        }

        [Then(@"I am on Votre contrat a-t-il été résilié par votre assureur")]
        public void ThenIAmOnVotreContratA_T_IlEteResilieParVotreAssureur()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnContratResilieForm());
        }

        [Then(@"I select contrat resilié option ""([^""]*)""")]
        public void ThenISelectContratResilieOption(string non)
        {
            souscriptionPageObject.ClickOnRatioContratResilie(non);
        }

        [Then(@"I am on Votre permis de conduire a-t-il été suspendu ou annulé")]
        public void ThenIAmOnVotrePermisDeConduireA_T_IlEteSuspenduOuAnnule()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnPermisSuspenduForm());

        }

        [Then(@"I select permis de conduire état option ""([^""]*)""")]
        public void ThenISelectPermisDeConduireEtatOption(string non)
        {
            souscriptionPageObject.ClickOnRatioPermisSuspendu(non);
        }

        [Then(@"I am on Avez-vous déclaré des sinistres form")]
        public void ThenIAmOnAvez_VousDeclareDesSinistresForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnSinistresForm());
        }

        [Then(@"I click on sinistres option ""([^""]*)""")]
        public void ThenIClickOnSinistresOption(string p0)
        {
            souscriptionPageObject.ClickOnRatioSinistres(p0);
        }

        [Then(@"I am on Souhaitez-vous qu'un autre conducteur bénéficie de vos garanties form")]
        public void ThenIAmOnSouhaitez_VousQuunAutreConducteurBeneficieDeVosGarantiesForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnAutreConducteurForm());
        }

        [Then(@"I select autre bénéficiaire option ""([^""]*)""")]
        public void ThenISelectAutreBeneficiaireOption(string non)
        {
            souscriptionPageObject.ClickOnRatioAutreConducteur(non);
        }

        [Then(@"I am on Informations resumé")]
        public void ThenIAmOnInformationsResume()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnContratResilieForm());
        }

        [Then(@"the infos displayed are correct")]
        public void ThenTheInfosDisplayedAreCorrect()
        {

        }

        [Then(@"I click on Confirmer on résumé page")]
        public void ThenIClickOnConfirmerOnResumePage()
        {
            souscriptionPageObject.MoveToConfirmerButton();
          // souscriptionPageObject.ClickOnConfirmerResumeButton();
        }


        [Then(@"I am on il ne vous reste plus qu'à remplir ces dernières informations form")]
        public void ThenIAmOnIlNeVousRestePlusQuaRemplirCesDernieresInformationsForm()
        {
            Assert.That(souscriptionPageObject.VerifyIAmOnIdForm());
        }

        [Then(@"I fill firstname ""([^""]*)"" and lastname ""([^""]*)""")]
        public void ThenIFillFirstnameAndLastname(string john, string testeur)
        {
            souscriptionPageObject.FillPrenomAndNomm(john, testeur);
        }

        [Then(@"I fill civility ""([^""]*)""")]
        public void ThenIFillCivility(string p0)
        {
            souscriptionPageObject.SelectCivility(p0);
        }

        [Then(@"I fill birthdate ""([^""]*)"" and birthcity ""([^""]*)""")]
        public void ThenIFillBirthdateAndBirthcity(string p0, string paris)
        {
            souscriptionPageObject.FillBirthdateAndBirthcity(p0, paris);
        }

        [Then(@"I select birthcountry ""([^""]*)""")]
        public void ThenISelectBirthcountry(string france)
        {
            souscriptionPageObject.SelectPaysDeNaissance(france);
        }

        [Then(@"I select profession ""([^""]*)""")]
        public void ThenISelectProfession(string salarié)
        {
            souscriptionPageObject.SelectProfession(salarié);
        }

        [Then(@"I select statut marital ""([^""]*)""")]
        public void ThenISelectStatutMarital(string p0)
        {
            souscriptionPageObject.SelectStatutMarital(p0);
        }

        [Then(@"I fill email ""([^""]*)""")]
        public void ThenIFillEmail(string p0)
        {
            souscriptionPageObject.FillEmailSub(p0);
        }

        [Then(@"I fill mobile number ""([^""]*)""")]
        public void ThenIFillMobileNumber(string p0)
        {
            souscriptionPageObject.FillNumeroMobile(p0);
        }

        [Then(@"I fill adresse ""([^""]*)""")]
        public void ThenIFillAdresse(string p0)
        {
            souscriptionPageObject.FillAdressePostal(p0);
        }

        [Then(@"I click on J’accepte la politique de confidentialité d’Ornikar")]
        public void ThenIClickOnJAccepteLaPolitiqueDeConfidentialiteDOrnikar()
        {
            souscriptionPageObject.CheckCgu();
        }

        [Then(@"I click on newsletter option ""([^""]*)""")]
        public void ThenIClickOnNewsletterOption(string p0)
        {
            souscriptionPageObject.CheckNewsletter(p0);
        }

        [Then(@"I click on Obtenir mon tarif")]
        public void ThenIClickOnObtenirMonTarif()
        {
            souscriptionPageObject.ClickOnObtenirMonTarifButton();
        }

        [Then(@"I obtain quotation")]
        public void ThenIObtainQuotation()
        {
            Assert.That(souscriptionPageObject.VerifiyIfIAmOnComparison());
        }


        [AfterTestRun]
        public static void CleanUp()
        {
            Thread.Sleep(3000);
            Driver.chromeDriver.Quit();
        }
    }
}
