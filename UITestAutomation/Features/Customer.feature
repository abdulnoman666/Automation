
Feature: Customer
Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@Add
Scenario: Customer
	Given User clicks the Customer Field on the Dashboard page
	And User validates the following UI Controls on Customers Page
		| UI Controls               |
		| Search and set date range |
		| Add Customer              |
		| Links                     |
		| Id                        |
		| Customer Name             |
		| Card Number               |
		| Account Type              |
		| Account                   |
		| Main Phone                |
		| Email                     |
	And User clicks the Add Customer Button on Customers Page
	And User validates the following Fields Add Customer Button Dialog
		| Fields                                      |
		| ID                                          |
		| Cardholder Name                             |
		| Core Customer Key                           |
		| Card Number                                 |
		| Account                                     |
		| Account Status                              |
		| Account Type                                |
		| Customer Type                               |
		| Branch                                      |
		| Charter / Branding                          |
		| Mobile Phone                                |
		| Home Phone                                  |
		| Office Phone                                |
		| Email                                       |
		| Statement Cycle Day (enter 0 for month end) |
		| Statement Cycle Code                        |
		| Statement Date - Next Business Day          |
		| Address                                     |
		| Close                                       |
		| Save                                        |
	And User clicks the Close Button on Add Customer Button Dialog
	And User clicks the Search Button on Customers Page
	And User validates the following Fields on Search Dialog
		| Fields              |
		| Customer Name       |
		| Full Card Number    |
		| Full Account Number |
		| Reset               |
		| Search              |
		| Close               |
	And User enters "singal" in Customer Name field on Search Dialog
	And User clicks the Search Button on Search Dialog
	And User validates the following UIControls on Customer Page
		| UIControls                |
		| Search and set date range |
		| Add Customer              |
		| Links                     |
		| Id                        |
		| Customer Name             |
		| Card Number               |
		| Account Type              |
		| Account                   |
		| Main Phone                |
		| Email                     |
		| Edit                      |
		| Customer Documents        |
		| Copy Customer Record      |
		| View Transactions         |
		| Print Letter              |
	And User clicks the View Transactions on Customer Page
	And User validates the following Fields on Transaction Page
		| Fields                                           |
		| From                                             |
		| To                                               |
		| Load Transactions                                |
		| Search for (enter description, merchant, amount) |
		| Id                                               |
		| Date                                             |
		| Description                                      |
		| Amount                                           |
		| Transaction Code                                 |
		| Pos                                              |
		| Close                                            |
	And User clicks the Close Button on Transaction Page
	And User clicks the Edit Customer on Customer Page
	And User validates the following Fields on Edit Customer Dialog
		| Fields                                      |
		| ID                                          |
		| Cardholder Name                             |
		| Core Customer Key                           |
		| Card Number                                 |
		| Account                                     |
		| Account Status                              |
		| Account Type                                |
		| Customer Type                               |
		| Branch                                      |
		| Charter / Branding                          |
		| Mobile Phone                                |
		| Home Phone                                  |
		| Office Phone                                |
		| Email                                       |
		| Statement Cycle Day (enter 0 for month end) |
		| Statement Cycle Code                        |
		| Statement Date - Next Business Day          |
		| Address                                     |
		| Close                                       |
		| Update                                      |
	And User clicks the Close Button on Edit Customer Dialog
	And User clicks the Customer Documents on Customer Page
	And User validates the following UI Controls on Document Manager Page
		| UI Controls          |
		| Download Document    |
		| gotoPage             |
		| prevPage             |
		| nextPages            |
		| gotoPage(totalPages) |
		| Rotate               |
		| Print/Download       |
	And User clicks the Dashboard Icon
		





	
#@Delete
#Scenario: WorkflowSettings_Delete
#	Given User clicks the Delete Workflow Setting on on Workflow Settings Page
#	And User validates the following Controls on Edit Setting Dialog
#
#		| Controls |
#		| Yes      |
#		| No       |
#
#@Edit
#Scenario: WorkflowSettings_Edit
#	Given User clicks the Edit Workflow Setting on on Workflow Settings Page
#	And User validates the following Controls on Edit Setting Dialog







		 


