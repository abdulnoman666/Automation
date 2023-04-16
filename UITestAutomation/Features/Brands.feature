Feature: Brands

 Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application
@Brands
	
	Scenario:  Brands 
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Brands option from the drop down menu of the ProfileIcon
	And User validates the following UI Controls on the Brand Page
	| UI Controls  |
	| New Case     |
	| Update Brand |
	| Delete Brand |
	| Refresh      |
	| Action       |
	| Brand Name   |
	| Email        |
	| Address      |
	| City         |
	| State        |
	| Zip          |
	| Phone        |
	| Fax          |
	| Charter      |
	| Logo         |    
    And  User clicks the Add Brand Icon on the Brand Page
	And User validates the following fields on the Brand Page
	| Fields           |
	| Select Logo File |
	| Brand Name       |
	| Charter          |
	| Email            |
	| Address          |
	| City             |
	| State            |
	| Zip              |
	| Phone            |
	| Fax              |
	| Save             |
	| Close            |
	| Cross Button     |