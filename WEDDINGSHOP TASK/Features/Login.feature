Feature: Login
	As a registered user of weddingshop.com
	I would like to login 
	So that I create a list

@mytag
Scenario: Login
	Given I navigate to www. weddingshop.com
	And I click on Login link
	And I enter Email address
	And I enter  my Password 
	And I click on Login
	Then the weddingshop homepage should be displayed

