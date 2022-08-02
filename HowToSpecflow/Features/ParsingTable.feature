Feature: ParsingTable
	Simple calculator for adding two numbers

Scenario: null
	Given I have an agent:
	| Name | RegisteredDate | Salary | IsActive |
	| null | null           | null   | null     |
	Then agent name is 'null'
	And agent registered date is 'null'
	And agent salary is 'null'
	And agent activation is 'null'

Scenario: empty string
	Given I have an agent:
	| Name | RegisteredDate | Salary | IsActive |
	|      |                |        |          |
	Then agent name is ''
	And agent registered date is 'null'
	And agent salary is 'null'
	And agent activation is 'null'

Scenario: with values
	Given I have an agent:
	| Name | Salary | RegisteredDate |
	| A    | 123.4  | 2022-05-05     |
	Then agent name is 'A'
	And agent salary is '123.4'
	And agent registered date is '2022-05-05'

Scenario: empty string2
	Given I have an agent:
	| Name |
	| A    |
	Then agent name is 'A'
	And agent registered date is 'null'
	And agent salary is 'null'
	And agent activation is 'null'