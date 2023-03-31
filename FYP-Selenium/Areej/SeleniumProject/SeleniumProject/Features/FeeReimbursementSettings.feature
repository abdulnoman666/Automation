Feature: FeeReimbursementSettings

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@Add
Scenario: Fee Reimbursement Settings
	Given User clicks the Profile Icon on the dashboard page
	And User Selects the Fee Reimbursement Settings from the dropdown menu of the Page
	And User validates following UI controls on Fee Reimbursement Settings Page
	
		| UI Controls |
		| Add         |
		| Delete      |
		| Edit        |
		| Action      |

 
	And User clicks the Add Fee Reimbursement Settings Icon on Fee Reimbursement Settings Page
	And User validates following fields on Add Fee Reimbursement Settings Dialog
		| Field                  |
		| Reference              |
		| Description            |
		| Auto Generate GL       |
		| Auto Fee GL Reference  |
		| Show On Dispute Form   |
		| Create Disputes        |
		| Include In Claim Total |

@Delete
	
Scenario: FeeRDelete
	Given User clicks on the Delete Fee Reimbursement button on Page
	And User validates the following Controls on Confirm Deletion Popup

		| Controls |
		| Yes      |
		| No       |

	
@tag1
Scenario: FeeRUpdate
	Given User clicks on the Edit Fee Reimbursement button on the Fee Reimbursement Settings Page
	And User validates the following fileds on Edit Fee Reimbursement Settings Page
		| fields                 |
		| Reference              |
		| Description            |
		| Auto Generate GL       |
		| Auto Fee GL Reference  |
		| Show On Dispute Form   |
		| Create Disputes        |
		| Include In Claim Total |

