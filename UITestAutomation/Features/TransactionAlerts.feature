Feature: Transaction Alerts

 Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@TransactionAlerts
Scenario:  Transaction Alerts 
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Transaction Alerts option from the drop down menu of the ProfileIcon
	And User validates the following UI Controls on the Transaction Alerts Page
	| UI Controls               |
	| Add New Transaction Alert |
	| Actions                   |
	| ID                        |
	| Transaction Alert         |
	| Workflows                 |
	| Reference                 |
	| Refresh                   |
    And User clicks the Add Transaction Alert Icon on the Transaction Alerts Page
	And User validates the following fields on the Add Transaction Alerts Page
	| Fields         |
	| Name           |
	| Workflows      |
	| Reference      |
	| Condition      |
	| Action         |
	| Tooltip        |
	| Save           |
	| Close          |
	| Save Condition |
	| Cross Button   |
	And User clicks the close button on the Add Transaction Alerts Page
	And User clicks the Dashboard Icon