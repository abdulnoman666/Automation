Feature: TransactionProcesses

     User clicks the Add Transaction Process to add the details on Add Process Transaction Setup Dialog
	 and clicks the Save button

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@Add
Scenario: Transaction_Add
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Transaction Processes Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on Transaction Process Page
		| UI Controls  |
		| Add          |
		| Edit         |
		| Delete       |
		| Action       |
		| Name         |
		| Process      |
		| GL Reference |
		| Workflows    |
		| Refresh      |
	And User clicks the Add Submission on Transaction Process Page
	And User validates the following fields on Add Process Transaction Setup Dialog
		| Fields       |
		| Name         |
		| Type         |
		| GL Reference |
		| Workflows    |
		| Close        |
		| Save         |
	And User clicks the Close Button on Add Process Transaction Setup Dialog
	And User clicks the Dashboard Icon
	

#@Delete
#Scenario: Transaction_Delete
#	Given User clicks the Delete Submission on Transaction Process Page
#	And User validates the following fields on Confirm Deletion Dialog
#
#		| Fields |
#		| Yes    |
#		| No     |
#
#@Edit
#Scenario: Transaction_Edit
#	Given User clicks the Edit Submission on Transaction Process Page
#	And User validates the following fields on Edit Process Transaction Setup Dialog
#
#		| Fields       |
#		| Name         |
#		| Type         |
#		| GL Reference |
#		| Workflows    |
#		| Close        |
#		| Update       |
	