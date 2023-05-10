@SouscriptionAssurancePage @NonRegressionOrnikarAssurance
Feature: SouscriptionAssurancePage


	Scenario: [01] - Reach Souscription Page by Url
		Given I enter Souscription Page Url in browser
		When I reach the Souscription Page the Url is correct

	Scenario: [02] - Answer Ornikar Not Already Registered User
		Given I am on Souscription page
		When I click Non
		Then I am on next question page trouver votre véhicule

	Scenario: [03] - Answer Ornikar Already Registered User
		Given I am on Souscription page
		When I click Oui
		Then I have the login form view

	Scenario: [04] - Connect to Ornikar from Souscription Page
		Given I am on Souscription page
		And I clicked Oui
		When I fill Email and Password
		Then I click on connect
		Then I am on next question page trouver votre véhicule

	Scenario: [05] - Forgot password on Login from Souscription Page
		Given I am on Souscription page
		And I clicked Oui
		When I click on forgotten password button
		Then I am on password remind page

	Scenario: [06] - Connect with Facebook from Souscription Page
		Given I am on Souscription page
		And I clicked Oui
		When I click on Connexion avec Facebook
		Then I am on Facebook Login page

	Scenario: [07] - Search by Plate Number the vehicle is success
		Given I am on Souscription page
		And I clicked on Non
		When I click on Rechercher par plaque
		Then I am on search by plate number form
		And I enter a plate number
		And I click on Confirmer
		And the vehicle is found

	Scenario: [08] - Search by Plate Number the vehicle is failed
		Given I am on Souscription page
		And I clicked Non
		When I click on Rechercher par plaque
		Then I am on search by plate number form
		And  I enter an  invalid plate number
		And The website informs me my plate number is invalid




