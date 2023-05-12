Feature: Search
As a user I want to able to serach specific products

@mytag
Scenario: User can search specific products
	Given User is on products page 
	When User types a term in the search box
	And clicks on search icon 
	Then Searched Products section will appear 