@E2ESubcription
Feature: E2ESubcription

	Scenario: Parcours Souscription Assurance Principale
		Given I am on Souscription page
		And I clicked on déjà enrigistré option "<déjà enrigistré option>"
		When I click on Rechercher par marque
		Then I am on search by brand form
		And I enter a brand "<brand>"
		And I am on search model form
		And I click on model list
		And I select a model "<model>"
		And I am on puissance fiscale form
		And I select my puissance fiscale "<puissance fiscale>"
		And I am on carburant/énergie form
		And I select my carburant "<carburant>"
		And I am on date de mise en circulation
		And I fill date de mise en circulation "<date de mise en circulation>"
		And I click on Continuer
		And I am on Quelle est sa version
		And I select version "<version>"
		And my vehicle is found
		And I click on Confirmer
		And I am on date d'achat form
		And I fill date d achat "<date d achat>"
		And I click on Continuer button
		And I am on date d'assurance du véhicule form
		And I fill date d asssurance souhaité "<date d asssurance souhaité>"
		And I click on Continuer button
		And I am on votre véhicule est-il assuré form
		And I select véhicule déjà assuré option "<véhicule déjà assuré option>"
		And I am on Depuis quand êtes-vous chez votre assureur actuel form
		And I click on ancien assureur date option "<ancien assureur date option>"
		And I am on Quand votre contrat arrive-t-il à échéance form
		And I select date dernière échéance "<date dernière échéance>"
		And I click on Continuer button
		And I am on Comment l'avez vous financé form
		And I select financement option "<financement option>"
		And I click on Continuer button
		And I am on date du permis
		And I fill date du permis "<date du permis>"
		And I click on Continuer button
		And I am on où votre premis de conduire a-t-il été délivré form
		And I select pays permis délivré "<pays permis délivré>"
		And I am on Avez-vous fait de la conduite accompagnée form
		And I click on conduite accompagnée option "<conduite accompagnée option>"
		And I am on Dans quel cadre utilisez-vous votre véhicule form
		And I select utilisation du véhicule option "<utilisation du véhicule option>"
		And I am on combien de kilomètres faites-vous par an form
		And I select km estimé "<km estimé>"
		And I click on Continuer button
		And I am on Le soir, où sera garé votre véhicule form
		And I select parking option "<parking option>"
		And I click on Continuer button
		And I am on Dans quelle ville form
		And I fill postalcode "<postalcode>"
		And I click on Continuer button
		And I am on Vous loger dans... form
		And I select residence option "<residence option>"
		And I am on Êtes-vous propriétaire de votre logement form
		And I select propriétaire résidence option "<propriétaire résidence option>"
		And I am on La carte grise du véhicule est-elle uniquement à votre nom form
		And I select carte grise nom option "<carte grise nom option>"
		And I am on Avez-vous été assuré 
		And I select déjà assuré option "<déjà assuré option>"
		And I click on Continuer button
		And I am on Quel est votre bonus malus form
		And I select  bonus malus option "<bonus malus option>"
		And I click on Continuer button
		And I am on Votre contrat a-t-il été résilié par votre assureur
		And I select contrat resilié option "<contrat resilié option>"
		And I am on Votre permis de conduire a-t-il été suspendu ou annulé 
		And I select permis de conduire état option "<permis de conduire état option>"
		And I am on Avez-vous déclaré des sinistres form
		And I click on sinistres option "<sinistres option>"
		And I am on Souhaitez-vous qu'un autre conducteur bénéficie de vos garanties form
		And I select autre bénéficiaire option "<autre bénéficiaire option>"
		And I am on Informations resumé
		And the infos displayed are correct
		And I click on Confirmer on résumé page
		And I am on il ne vous reste plus qu'à remplir ces dernières informations form
		And I fill firstname "<firstname>" and lastname "<lastname>"
		And I fill civility "<civility>"
		And I fill birthdate "<birthdate>" and birthcity "<birthcity>"
		And I select birthcountry "<birthcountry>"
		And I select profession "<profession>"
		And I select statut marital "<statut marital>"
		And I fill email "<email>"
		And I fill mobile number "<mobile number>"
		And I fill adresse "<adresse>"
		And I click on J’accepte la politique de confidentialité d’Ornikar
		And I click on newsletter option "<newsletter option>"
		And I click on Obtenir mon tarif
		And I obtain quotation

		Examples: 
		| déjà enrigistré option | brand      | model   | puissance fiscale | carburant | date de mise en circulation | version     | date d achat | date d asssurance souhaité | véhicule déjà assuré option | ancien assureur date option | date dernière échéance | financement option | date du permis | pays permis délivré | conduite accompagnée option | utilisation du véhicule option                            | km estimé | parking option                        | postalcode | city     | residence option | propriétaire résidence option | carte grise nom option | déjà assuré option                   | bonus malus option       | contrat resilié option | permis de conduire état option | sinistres option | autre bénéficiaire option | firstname | lastname | civility | birthdate  | birthcity | birthcountry | profession | statut marital | email                      | mobile number | adresse                                     | newsletter option |
		| Non                    | VOLKSWAGEN | GOLF IV | 9CV               | ESSENCE   | 01-01-2019                  | 1.8 GTI 150 | 01-01-2019   | 01-07-2023                 | Oui à mon nom               | Depuis plus d'un an         | Juin					 | Au comptant        | 01-01-2015     | En France           | Oui                         | Pour des trajets privés entre mon domicile et mon travail | 15000     | Dans la rue ou dans un parking public | 75019      | Paris 19 | Un appartement   | Non                           | Oui                    | Oui, en continu sur toute la période | 1.00, ni bonus, ni malus | Non                    | Non                            | Non, aucun       | Non                       | John      | Testeur  | M.       | 01-01-1991 | Paris     | France       | Salarié    | Je vis seul·e  | randomcryptouser@gmail.com | 0635247146    | 5 Rue du Champ de Mars, 75007 Paris, France | true				 |
		| Oui                    | RENAULT    |         |                   |           |                             |             |              |                            |                             |                             |						 |                    |                |                     |                             |                                                           |           |                                       |            |          |                  |                               |                        |                                      |                          |                        |                                |                  |                           |           |          |          |            |           |              |            |                |                            |               |                                             |                   |