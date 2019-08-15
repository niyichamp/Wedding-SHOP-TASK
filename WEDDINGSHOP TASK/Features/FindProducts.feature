Feature: FindProducts
	As a registered user
	I am logged in to www.weddingshop.com
	As a customer with upcoming wedding
	I want to be able to find products to my taste


@mytag
Scenario: Search for products by description and Budget
	Given I want candles in the £20-£39 price range
	When I click on search for "candles" and filter by price
	Then candles priced between £20-£39 should be displayed
