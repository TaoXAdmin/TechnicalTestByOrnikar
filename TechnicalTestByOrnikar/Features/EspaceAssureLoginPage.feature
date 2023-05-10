	@LoginPage @NonRegressionOrnikarAssurance
Feature: EspaceAssureLoginPage

	@GoToLoginPage
Scenario: [01] - Reach Espace Assure Ornikar Login Page by Url
	Given I enter Espace Assure Url in browser
	When I reach the website the Url is correct

	@ConnectEspaceAssure
Scenario: [02] - Connect to Espace Assure Ornikar
	Given I am on Espace Assure login page
	When I fill credentials
	And I click on connect button
	Then I am logged in

	@InvalidEmailMsg
Scenario: [03] - Connect to Espace Assure Ornikar Invalid email format
	Given I am on Espace Assure login page
	When I fill an invalid format Email
	And I click on connect button
	Then the page display a warning msg

	@PasswordVisible
Scenario: [04] - Show Password in Password Field
	Given I am on Espace Assure login page
	When I fill credentials
	And I click on show password button
	Then the passsword is visible

	@ForgottenPassword
Scenario:[05] - Click on Forgotten Password
	Given I am on Espace Assure login page
	When  I click on J'ai oublié mon mot de passe
	Then I am on reset-password page

