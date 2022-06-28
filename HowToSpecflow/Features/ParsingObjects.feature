Feature: ParsingObjects

Scenario: Single object
	Given I have a dog:
	| name  | age |
	| Cezar | 3   |
		Then I have one dog object where name is 'Cezar', '3' years old

Scenario: Multiple objects
	Given I have more dogs:
	| name  | age |
	| Cezar | 3   |
	| Hades | 6   |
	| Zeus  | 5   |
		Then the '1'. dog name is 'Cezar', '3' years old
		And the '2'. dog name is 'Hades', '6' years old
		And the '3'. dog name is 'Zeus', '5' years old

Scenario: Using step transformers
	Given I have 'User1' user
		Then user email addres is 'user1@test.com'

Scenario Outline: Parsing enum
	Given I have a '<animal>' enum
		Then enum is Dog

	Examples: 
	| animal |
	| dog    |
	| Dog    |
	| DOG    |