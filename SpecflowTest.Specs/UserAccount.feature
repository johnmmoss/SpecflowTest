Feature: UserAccountFeature
	In order to be able to use the site
	As a user
	I want to be able to manage my account

Scenario: User can register to use the site
	Given I am on the register page
	And I have entered the following deatails into the form:
	| User name | Password    |
	| johnmmoss | P@ssword123 |
	When I press register
	Then a new account is created
