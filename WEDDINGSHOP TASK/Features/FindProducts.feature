Feature: FindProducts
	As a registered user
	I am logged in to www.weddingshop.com
	As a customer with upcoming wedding
	I want to be able to find products to my taste


@mytag
Scenario: Search for products by description and Budget
	Given I navigate to www. weddingshop.com
	When I click on search for "candles" and filter by price
	Then I see more candles displayed