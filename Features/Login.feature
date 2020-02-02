@Smoke
Feature: Login
	As a registered user of giftrete.com
	I want to login
	So that i can get freebies
	Background:
	#1	#6
		Given I navigate to the website
	#2	#7
		And I click on login button

Scenario: Login with valid user details
	#3
	When I enter username
	#4
		And I enter the password
	#5
	Then I am logged in

Scenario: Login with invalid user details
	When I enter username
		And I enter the wrong password
	Then I should not be logged in

Scenario: Login with invalid user details with Parameter1
	When I enter username "destinedtayo"
		And I enter the wrong password "Incorrect Password"
	Then I should not be logged in

Scenario: Login with invalid user details with Parameter2
	When I enter username "destinedtayo"
		And I enter no password "NothingEntered"
	Then I should not be logged in

Scenario: Login with invalid user details with Parameter3
	When I enter wrong username "IncorrectUsername"
		And I enter the password "CorrectPassword"
	Then I should not be logged in

Scenario: Login with invalid user details with Parameter4
	When I enter wrong username "IncorrectUsername"
		And I enter the wrong password "IncorrectPassword"
	Then I should not be logged in

Scenario: Login with invalid user details with Parameter5
	When I enter no username "NothingEntered"
		And I enter the password "CorrectPassword"
	Then I should not be logged in

	Scenario: Login with invalid user details with Parameter6
	When I enter no username "NothingEntered"
		And I enter the wrong password "IncorrectPassword"
	Then I should not be logged in

		Examples:
		| Username          | Password          |
		| destinedtayo      | IncorrectPassword |
		| destinedtayo      | NothingEntered    |
		| IncorrectUsername | CorrectPassword   |
		| IncorrectUsername | IncorrectPassword |
		| NothingEntered    | CorrectPassword   | 
		| NothingEntered    | IncorrectPassword |
	