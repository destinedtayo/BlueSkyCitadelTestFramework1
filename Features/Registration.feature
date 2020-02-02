@Smoke
Feature: Registration
	In order to giftrete.com
	I need to register
	Background:
	#1	#9
		Given I navigate to the website
	#2	#10
		And I click on the register button

Scenario: Registration
	#3
	When I enter the first name
	#4
		And I enter the last name
	#5
		And I enter the password
	#6
		And I enter the confirm password
	#7
		And I click the sign up button
	#8
	Then I should be logged in

Scenario: Registration Negative Test
	When I enter the first name
		And I enter the last name
		And I enter the password
		And I enter a wrong password for the confirm password
		And I click the sign up button
	Then I should not be logged in
		And my name is displayed

Scenario: Registration Negative Test with Parameter
	When I enter the first name "Tayo"
		And I enter the last name "Ojo"
		And I enter the password "my secure password"
		And I enter a wrong password for the confirm password
		And I click the sign up button
	Then I should not be logged in
		And my name is displayed

		Scenario: Registration Negative Test with Parameter2
	When I enter the first name "(FirstName)"
		And I enter the last name "(LastName)"
		And I enter the password "(password)"
		And I enter a wrong password "<ConfirmPassword>" for the confirm password
		And I click the sign up button
	Then I should not be logged in
		And my name is displayed

		Examples:
		| Firstname | Lastname | Password     | ConfirmPass  |
		| Tayo      | Ojo      | MySecurePass | MySecurePass |
		| Tayo1     | Ojo2     | MySecurePass | MySecurePass |