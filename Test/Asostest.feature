Feature: Asostest
	In order to sign in Asos
	As a user I am able to sign in
	

@SMOKE
Scenario: Asos sign in
	Given I naviagte to Asos
	When I click on sign in
	And I  entered the user details
	Then I am able to signin 
