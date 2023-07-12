Feature: WorkflowSettings

A short summary of the feature
Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@Add
Scenario: Workflow Settings
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Workflow Settings Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on Workflow Settings Page
		| UI Controls     |
		| Add             |
		| Edit            |
		| Delete          |
		| Download Letter |
		| Action          |
		| ID              |
		| Workflow        |
		| Refresh         |
	And User clicks the Add Workflow Setting on on Workflow Settings Page
	And User validates the following Controls on Edit Setting Dialog
		| Controls              |
		| Settings              |
		| Event Triggers        |
		| Self-Service Verbiage |
		| Close                 |
		| Save                  |
	And User validates the following Fields in Settings Page on Edit Setting Dialog
		| Fields                                        |
		| Workflow                                      |
		| Publish                                       |
		| Allow Customer Access                         |
		| Search By                                     |
		| Send Notifications                            |
		| Distribution List                             |
		| Transaction Type                              |
		| Account Types Allowed                         |
		| Closed Account Status                         |
		| Add Transactions                              |
		| Allow Manual Transactions                     |
		| Allow user to copy / duplicate transactions   |
		| Copy Description to Merchant Field by Default |
		| Merchant Copy Source Field Name               |
		| Transaction Filter Condition                  |
		| Transaction Not Allowed Condition             |
		| Show Fraud / Non-Fraud Option                 |
		| Disable Customer Edit                         |
		| Has Questionnaire                             |
		| Has Provisional Credit Calculation            |
		| Show Customer Type                            |
		| Hide Comments And Resolution                  |
		| Reimburse Fees                                |
		| Transaction Code Filter                       |
		| GL Reference                                  |
		| Interest Posting GL Reference                 |
		| Compliance Regulation Screen                  |
		| Dispute Screen Type                           |
		| Email Template Reference                      |
		| Confirmation Email Template Reference         |
		| Post Submission Automation Reference          |
		| Automation Reference On Submission Complete   |
		| Submission Screen Template                    |
	And User adds the following data to fields in Settings Page
		| Fields                                        | Values      |
		| Workflow                                      | Debit Card  |
		| Publish                                       |             |
		| Allow Customer Access                         |             |
		| Customer Description                          | Casual User |
		| Search By                                     | Card        |
		| Send Notifications                            |             |
		| Distribution List                             | abc         |
		| Transaction Type                              | Default     |
		| Account Types Allowed                         | Default     |
		| Closed Account Status                         | Default     |
		| Add Transactions                              |             |
		| Allow Manual Transactions                     |             |
		| Allow user to copy / duplicate transactions   |             |
		| Copy Description to Merchant Field by Default |             |
		| Merchant Copy Source Field Name               | Arshi       |
		| Transaction Filter Condition                  | abc         |
		| Transaction Not Allowed Condition             | abc         |
		| Show Fraud / Non-Fraud Option                 |             |
		| Verbiage for Fraud                            | donot       |
		| Verbiage for Non-Fraud                        | problem     |
		| Disable Customer Edit                         |             |
		| Has Questionnaire                             |             |
		| Has Provisional Credit Calculation            |             |
		| Show Customer Type                            |             |
		| Hide Comments And Resolution                  |             |
		| Reimburse Fees                                |             |
		| Transaction Code Filter                       | 123         |
		| GL Reference                                  | Red1        |
		| Interest Posting GL Reference                 | Red1        |
		| Compliance Regulation Screen                  | None        |
		| PC Business Days                              |             |
		| Provisional Credit Days                       | 4           |
		| Resolution Business Days                      |             |
		| Resolution Days                               | 12          |
		| Dispute Screen Type                           | Default     |
		| Email Template Reference                      | DC          |
		| Confirmation Email Template Reference         | PC          |
		| Post Submission Automation Reference          | AC          |
		| Automation Reference On Submission Complete   | SFFS        |
		| Submission Screen Template                    | Default     |
	And User validates the following Fields in Questionaire Dialog on Edit Setting Dialog
		| Fields                             | Values                          |
		| Questionnaire Template             | Check Fraud                     |
		| e-Consent Notice Template          | Electronic Signature Disclosure |
		| Read Only Questionnaire            |                                 |
		| Hide Send To Customer              |                                 |
		| Hide Customer Acknowledgement Form |                                 |
		| Close Screen Message               |                                 |
	And User clicks the Event Triggers in Settings Page on Edit Setting Dialog
	And User validates the following Controls in Event Triggers on Edit Setting Dialog
		| UI Controls        |
		| Action             |
		| Trigger Name       |
		| Trigger Event Type |
		| Add                |
	And User clicks the Add Event Trigger in Event Triggers Page on on Edit Setting Dialog
	And User validates the following Fields in Add Trigger Page on Edit Setting Dialog
		| Fields                                  |
		| Trigger Name                            |
		| Trigger Event Type                      |
		| Additional Condition (search for below) |
		| Account Type                            |
		| Automation Reference                    |
		| Letter Template Reference               |
		| GL Reference                            |
		| Run Automation                          |
		| AutomationReference                     |
		| Send Email Notification                 |
		| Email Letter Template Reference         |
		| Email Distribution List                 |
		| Close                                   |
		| Save                                    |
	And User adds the following data to fields in Add Trigger Page on Edit Setting Dialog
		| Fields                                  | Values   |
		| Trigger Name                            | abc      |
		| Trigger Event Type                      | ab       |
		| Additional Condition (search for below) |          |
		| Account Type                            |          |
		| Account Type Restriction                | Business |
		| Automation Reference                    |          |
		| Automation Reference Box                | T1       |
		| Letter Template Reference               |          |
		| Template Reference                      | ref      |
		| GL Reference                            |          |
		| GL Reference Box                        | FC       |
		| Run Automation                          |          |
		| AutomationReference                     | T1       |
		| Send Email Notification                 |          |
		| Email Letter Template Reference         | ref      |
		| Email Distribution List                 | abc      |
	And User clicks the Save Button on Add Trigger Page
	And User clicks the Self-Service Verbiage in Settings Page on Edit Setting Dialog
	And User validates the following Fields in Self-Service Verbiage Page on Edit Setting Dialog
		| Fileds                                          |
		| Self-Service Portal Submission Completion Title |
		| Self-Service Portal Submission Completion Note  |
		| Close                                           |
		| Save                                            |
	And User adds the following data to fields in Self-Service Verbiage Page
		| Fileds                                          | Value      |
		| Self-Service Portal Submission Completion Title | Completion |
		| Self-Service Portal Submission Completion Note  | Completion |
	And User clicks the Save Button on Self-Service Verbiage Page
	And User validates the total number of Action Fields on Workflow Settings Page
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







		 


