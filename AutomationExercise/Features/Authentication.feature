Feature: Authentication
	Simple calculator for adding two numbers

@smoke
Scenario: User can log in 
	Given User opens sign in page 
	And user enters correct credentials 
	When user submits login form 
	Then user is logged in


	Scenario: User can sign up
	Given User opens sign in page
	And enters 'Nada' name and valid email address
	And user lick on SignUp button 
	When user fills in all required fields
	And submits the sign up form
	Then user will get 'Account Created!' successs message 
	And user is logged in 


	Scenario: User can delete their account
	Given user register an account with 'Nada' name
	When user selects options for deleting account
	Then account is deleted with 'Account Deleted!' message