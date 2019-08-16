Feature: Registration
	I would like to register on www.weddingshop.com
	So I can use the site
	

@mytag
Scenario: Registration
Given I navigate to www. weddingshop.com
And I click on create a list
And I enter my title 
And I enter my Firstname
And I enter my Lastname
And I enter where I hear about the site
And I enter my partners title 
And I enter my partner firstname
And I enter my partner lastname
And I enter country location
And I enter address/postcode
And I enter contact number
And I enter wedding date
And I enter number of guest
And I enter Email
And I enter Password
And I Confirm Password
When I click on submit button
Then I should be a registered user