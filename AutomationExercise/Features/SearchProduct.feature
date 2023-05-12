Feature: Search
As a user I want to able to serach specific products

@mytag
Scenario: User can search specific products
	Given User is on products page 
	When User types a term in the search box
	And clicks on search icon 
	Then Searched Products section will appear 


	Scenario: Use can add items to the cart 
	Given User is on products page 
	When User types a term in the search box
	And clicks on search icon
	And opens a first search result
	And clicks on add to cart button 
	And proceeds to the cart 
	Then the shopping cart will be displayed with the selected product
