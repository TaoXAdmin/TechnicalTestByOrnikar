Feature: [FrontPage]

@WebSiteAvaibilities
Scenario: [01] - Connect to front-office Ornikar Assurance-Auto
	Given I try to access Ornikar Assurance-Auto front-office
	When I reach the website the current url is correct

Scenario: [02] - Reach Home Page from Ornikar Assurance-Auto Page
	Given I am connected to Ornikar Assurance-Auto front-office
	When  I click on home button
	Then I am on Ornikar home page

Scenario: [03] - Reach Code Page from Ornikar Assurance-Auto Page
	Given I am connected to Ornikar Assurance-Auto front-office
	When I click on code de la route button
	Then I am on code page

Scenario: [04] - Reach Permis-B Page from Ornikar Assurance-Auto Page
	Given I am connected to Ornikar Assurance-Auto front-office
	When I click on context-menu and Permis-B button is clickable
	Then I click on Permis-B
	And I am on Permis page

Scenario: [05] - Conduite Accompagnée Page from Ornikar Assurance-Auto Page
	Given I am connected to Ornikar Assurance-Auto front-office
	When I click on context-menu and conduite accompagnée button is clickable
	Then I click on conduite accompagnée
	And I am on conduite accompagnée page

Scenario: [06] - Reach Conduite Page from Ornikar Assurance-Auto Page
	Given I am connected to Ornikar Assurance-Auto front-office
	When I click on context-menu and conduite button is clickable
	Then I click on conduite
	And I am on conduite page

Scenario: [07] - Reach Financement CPF Page from Ornikar Assurance-Auto Page
	Given I am connected to Ornikar Assurance-Auto front-office
	When I click on context-menu and financement CPF button is clickable
	Then I click on financement CPF
	And I am on financement CPF page