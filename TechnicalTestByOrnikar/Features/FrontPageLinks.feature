	@Links @NonRegressionOrnikarAssurance
Feature: [FrontPage - Links]

	@ConnectFrontOffice
Scenario: [01] - Connect to front-office Ornikar Assurance-Auto
	Given I try to access Ornikar Assurance-Auto front-office
	When I reach the website the current url is correct

	@HomePageLink
Scenario: [02] - Reach Home Page from Ornikar Assurance-Auto Page
	Given I am on Ornikar Assurance-Auto front-office
	When  I click on home button
	Then I am on Ornikar home page

	@CodePageLink
Scenario: [03] - Reach Code Page from Ornikar Assurance-Auto Page
	Given I am on Ornikar Assurance-Auto front-office
	When I click on code de la route button
	Then I am on code page

	@PermisBLink
Scenario: [04] - Reach Permis-B Page from Ornikar Assurance-Auto Page
	Given I am on Ornikar Assurance-Auto front-office
	When I click on context-menu
	Then I click on Permis-B
	And I am on Permis page

	@ConduiteAccompagneeLink
Scenario: [05] - Conduite Accompagnée Page from Ornikar Assurance-Auto Page
	Given I am on Ornikar Assurance-Auto front-office
	When I click on context-menu
	Then I click on conduite accompagnée
	And I am on conduite accompagnée page

	@ConduitePageLink
Scenario: [06] - Reach Conduite Page from Ornikar Assurance-Auto Page
	Given I am on Ornikar Assurance-Auto front-office
	When I click on context-menu
	Then I click on conduite
	And I am on conduite page

	@FinancementCPFLink
Scenario: [07] - Reach Financement CPF Page from Ornikar Assurance-Auto Page
	Given I am on Ornikar Assurance-Auto front-office
	When I click on context-menu
	Then I click on financement CPF
	And I am on financement CPF page

	@AssuranceAutoLink
Scenario: [08] - Reach Assurance-Auto Page from another Page of Ornikar
	Given I am on Ornikar Assurance-Auto front-office
	And I move to another Ornikar's page
	When I click on Assurance auto
	Then I am back on Assurante-auto front page

	@LoginLink
Scenario: [09] - Reach Login Page from Assurance-Auto Page
	Given I am on Ornikar Assurance-Auto front-office
	When I click on Connexion
	Then I am on login page

	@SouscriptionLink
Scenario: [10] - Reach Souscription Page from Assurance-Auto Page
	Given I am on Ornikar Assurance-Auto front-office
	When I click J'obtiens mon tarif
	Then I am on souscription page

	@SoucriptionLinkContinue
Scenario: [11] - Reach Souscription Page from  Assurance-Auto Page Continue Case
	Given I am on Ornikar Assurance-Auto front-office
	And I have already started a quotation
	When I click on Je reprends mon devis
	Then I am on souscription page without reset
	And previous action has been saved
