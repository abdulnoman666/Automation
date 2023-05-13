Feature: FeeSelectionSettings

 Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@FeeSelectionSettings
Scenario: Fee Selection Settings
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Fee Selection Settings option from the drop down menu of the ProfileIcon
	And User validates the following UI Controls on the Fee Selection Settings Page
	| UI Controls             |
	| Add Fee Selection       |
	| Edit Fee Selection      |
	| Delete Fee Selection    |
	| Refresh                 |
	| Actions                 |
	| ID                      |
	| Fee Selection Reference |

Scenario:  Add Fee Selection
    Given User clicks the Add Fee Selection Icon on the Fee Selection Settings Page
	And User validates the following fields on the Add Fee Selection Page
	| Fields                                         |
	| Fee Selection Reference                        |
	| Copy Transactions from Parent Submission       |
	| Create Case for Interest Refund                |
	| Search for Transactions using Parameters below |
	| Transaction Codes                              |
	| Search from Dates                              |
	| Search through Today                           |
	| Number of Days                                 |
	| Save                                           |
	| Close                                          |