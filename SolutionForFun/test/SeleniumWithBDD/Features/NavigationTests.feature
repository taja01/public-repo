Feature: NavigationTests

A short summary of the feature

Scenario: Navigate to Demo page from header
	Given I am on the 'MainPage'
	When I click Demo button from the header
	Then 'DemoPage' is loaded

Scenario: Navigate to Demo page from main page content
	Given I am on the 'MainPage'
	When I click Demo button from the main page
	Then 'DemoPage' is loaded

Scenario: Navigate to Pricing page from header
	Given I am on the 'MainPage'
	When I click Pricing button from the header
	Then 'PricingPage' is loaded