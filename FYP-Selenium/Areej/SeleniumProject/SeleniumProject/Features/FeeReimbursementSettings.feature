Feature: FeeReimbursementSettings

 Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@tag1
Scenario: FeeRAdd
	Given User clicks the Profile Icon on the dashboard page
	And User Selects the FeeReimbursementSettings from the dropdown menu of the Page
	And User clicks the AddFeeReimbursementSettingsIcon on Fee Reimbursement Settings Page
	And User enters the following data into the fields on Add FeeReimbursementSettings Dialog
	                     | Field                  | Value                                          |
	                     | Reference              | fee Reimbursement Setting                      |
	                     | Description            | Automate Fee Reimbursement Setting Description |
	                     | Auto Generate GL       | checked                                        |
	                     | Auto Fee GL Reference  | Ref1                                           |
	                     | Show On Dispute Form   | checked                                        |
	                     | Create Disputes        | checked                                        |
	                     | Include In Claim Total | checked                                        |
	When User clicks on save button on the Fee Reimbursement Settings Page 
	Then User will be able to see the new settings saved on the Fee Reimbursement Settings Page
	
@tag1
Scenario: FeeRDelete
	Given User clicks on the Delete Fee Reimbursement button on Page
	When User clicks on "Yes" option on the popup to confirm deletion
	Then User should be able to see the Fee Reimbursement Settings deleted from the page
	
	@tag1
Scenario: FeeRUpdate
	Given User clicks on the Edit Fee Reimbursement button on the Fee Reimbursement Settings Page
	And User edits the infromation in the Reference textbox on the Page
	And User edits the information in the Description textbox one the Page
	And User unchecks the AutoGenerateGL checkbox on Fee Reimbursement Settings Page
	And User selects "REF" from the AutoFeeGLReference dropdown menu on the Fee Reimbursement Settings Page
	And User unchecks on the showOnDsputeForm checkbox on the Fee Reimbursement Settings Page
	And User unchecks on the createDispute checkbox on the Fee Reimbursement Settings Page
	And User unchecks on the includeInClaimTotal checkbox on the Fee Reimbursement Settings Page
	When User clicks on the Save button on Fee Reimbursement Settings page 
	Then User will be able to see the new settings saved on the Fee Reimbursement Settings Page


