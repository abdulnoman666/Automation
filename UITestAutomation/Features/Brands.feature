Feature: Brands

 Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application
@Brands
	
	Scenario:  Brands 
	Given User clicks the ProfileIcon on the Dashboard Page
	And User selects the Brands option from the drop down menu of the ProfileIcon
	And User validates the following UI Controls on the Brand Page
	| UI Controls  |
	| Add Brand    |
	| Update Brand |
	| Delete Brand |
	| Refresh      |
	
    And  User clicks the Add Brand Icon on the Brand Page
	And User validates the following fields on the Brand Page
	| Fields     |
	| Brand Name |
	| Charter    |
	| Email      |
	| Address    |
	| City       |
	| State      |
	| Zip        |
	| Phone      |
	| Fax        |
	
   When User clicks the save Button on the Brand Page
   Then User will be able to see the new information in the fields on the Brand Page
