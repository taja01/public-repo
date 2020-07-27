Feature: Search

@wiki_pedia @google @search
Scenario: 42
	Given I am on the google page
	
	When I enter '42' to the search field
	And I hit the search button
		Then Search result page is loaded

	When I select from the result which contain 'Phrases_from_The_Hitchhiker'
		Then wikipedia page is loaded
		And the title contains 'Phrases from The Hitchhiker's Guide to the Galaxy'
		And there are more than '0' H2 headline(s)
		And there are more than '0' H3 headline(s)