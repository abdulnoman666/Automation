Feature: TransactionProcesses

     User clicks the Add Transaction Process to add the details on Add Process Transaction Setup Dialog
	 and clicks the Save button

@TransactionAdd
Scenario: TransactionAdd
	Given User clicks the ProfileIcon on the Dashboard page
	And   User selects the Transaction Processes Field from the dropdown menu of ProfileIcon
	And   User clicks the AddTransactionProcessIcon on Transaction Process Page
	And   User enters the following data into the fields on Add Process Transaction Setup Dialog
	            | Field                | Value                |
                | Name                 |  Susan               |
                | Type                 | Fee                  |
                | GL Reference         | ABC                  |
                | Workflows            | Debit Card           |
			      
				  
	When  User clicks the Save Button on Add Process Transaction Setup Dialog
	Then  User should be able to see Process Transaction Setup saved on Transaction Process Page

	@tag1
Scenario: TransactionDelete
	Given User clicks the Delete Submission icon on Transaction Process Page
	When  User clicks the YES Button on Confirm Deletion Page
	Then  User should be able to see Process Transaction Setup removed on Transaction Process Page

	@tag1
Scenario: TransactionEdit
	Given User clicks the Edit Submission icon on Transaction Process Page
	And   User edits the Name as "Sara" in NameField on Edit Process Transaction Setup Dialog
	And   User selects "Final Credit" from the Dropdown menu of Type field on Edit Process Transaction Setup Dialog
	And   User selects "FC" from the Dropdown menu of GL Reference field on Edit Process Transaction Setup Dialog
	And   User selects "A2" from the Dropdown menu of Workflows field on Edit Process Transaction Setup Dialog
	When  User clicks the Update Button on Edit Process Transaction Setup Page
	Then  User should be able to see Process Transaction Setup saved on Transaction Process Page