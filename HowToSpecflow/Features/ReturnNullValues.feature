Feature: ReturnNullValues

Scenario: Null user-defined  type
	Given I have 'null' user
		Then 'null' user is not registered

Scenario: Null int  type
	Given I have a lucky number 'null' 
		Then my lucky number is null

Scenario: Null DateTime  type
	Given I have a lucky date 'null' 
		Then my lucky date is null

	#not the best
Scenario: Null string type
	Given I have a lucky string 'null' 
		Then my lucky string is null