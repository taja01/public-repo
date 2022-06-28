Feature: StringTest

Scenario: Empty string
	Given I have a lucky string '' 
		Then my lucky string is empty

Scenario Outline: String with value
	Given I have a lucky string '<myString>' 
		Then my lucky string is '<myString>'

	Examples: 
	| myString |
	| apple    |
	|          | 
	