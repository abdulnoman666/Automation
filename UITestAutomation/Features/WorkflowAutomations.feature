Feature: WorkflowAutomations

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@Add
Scenario: Add Workflow Automations
	Given User clicks the Profile Icon on the dashboard page
	And User Selects the Workflow Automations from the dropdown menu of the Page
	And User validates following UI controls on WorkFlow Automations Page
	
		| UI Controls         |
		| Add                 |
		| Delete              |
		| Edit                |
		| Copy Automation     |
		| Download Automation |
		| Condition Search    |
	And User clicks the Add Workflow Automations Icon on Workflow Automations Page
	And User validates following fields on Add Workflow Automations Dialog
		| Field                         |
		| Name                          |
		| Conditions                    |
		| Workflow Automation Reference |
		| Scope                         |

@Edit
Scenario: Edit Workflow Automations
	Given User clicks on the Edit Workflow Automations button on the Workflow Automations Page
	And User validates the following fileds on Edit Workflow Automations Page
		| Field                         |
		| Name                          |
		| Conditions                    |
		| Workflow Automation Reference |
		| Scope                         |

@Delete
Scenario: Delete Workflow Automations
	Given User clicks on the Delete Workflow Automation button on Page
	And User validates the following Controls on Confirm Deletion Popup

		| Controls |
		| Yes      |
		| No       |