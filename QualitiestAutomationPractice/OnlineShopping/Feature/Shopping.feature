Feature: Online Shopping

@mytag
Scenario: Order T-Shirt
	Given I'm logged in to the Automation Practice webpage
	When I select the T-Shirts link
	And I add item to the shopping cart
	And I proceed to checkout
	When I sign into my account
	And I enter the address details 
	And I enter the shipping details
	And I select the payment method
	Then I should be able to confirm my order



Scenario: Update Personal Information (First Name) in My Account
	Given I'm logged in to the Automation Practice webpage
	When I select My Account link
	And I click My Personal Information tab
	And I save the details
	Then the personal information should be updated successfully