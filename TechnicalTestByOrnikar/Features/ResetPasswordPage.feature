@ResetPasswordPage @@NonRegressionOrnikarAssurance
Feature: ResetPasswordPage

@ReturnLoginPage
Scenario: [01] - Return to Ornikar Login Page
	Given I am on reset password page
	When I click je me connecte à Ornikar
	Then I am back on login page espace assuré

@ResetPassword
Scenario: [02] - Reset Password
	Given I am on reset password page
	When I fill an Email
	Then I click on je réinitialise mon mot de passe
	And A notification is displayed

@CloseNotification
Scenario: [03] - Close Password Notification
	Given I am on reset password page
	When I Click on close notification
	Then the notification is hidden

Scenario: [04] - Verify Main Displaye of Reset Password Page UI
	Given I am on reset password page
	And I can see Mot de pass oublié title
	And The paragraph is correct
	And Adress Email label is visible
	And Je réninitialise mon mot de passe button text is valid
	And notification text is correct
	
	


