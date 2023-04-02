Feature: CompanyDetails
 
 
Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@CompanyDetails

Scenario: Company Details
	Given User clicks the Profile Icon on the Dashboard page
	And User selects the Company Details Option from the dropdown menu of ProfileIcon
	And User validates the following UI Controls on Company Details Page
		| UI Controls      |
		| Company Details  |
		| Basic Info       |
		| General Settings |
		| Lookup Values    |
		| Style            |
		| Save             |
	   

Scenario: Basic Info
	And User selects the Basic Info button on Company Details Page
	And User validates the following fields on Basic Info Page

		|Fields                   |
		|Company Name             |
		|Address                  |
		|City                     |
		|State                    |
		|Zip                      |
		|Phone                    |
		|Email                    |
		|Support Email            |
		|Email Distribution List  |
		|Time Zone                |
		|Read only Questionnaires |
	
	 
Scenario: General Settings
	Given User clicks on the General Settings button on Company Details Page
	And User validates the following fields on General Settings Page
		|Fields                         |
		|Signature Pad                  |
		|Enter max idle time in minutes |
		|Month End Statement            |
		|Select Logo File               |


Scenario: Lookup Values
	Given User clicks on the Lookup Values button on Company Details Page
	And User validates the following UI Controls on Lookup Values Page
		| UI Controls                       |
		| Cross Button                      |
		| Add Submission Status             |
		| Edit Submission Status            |
		| Delete Submission Status          |
		| Add Source                        |
		| Edit Source                       |
		| Delete Source                     |
		| Add Account Type                  |
		| Edit Account Type                 |
		| Delete Account Type               |
		| Add Dispute Research Detail       |
		| Edit Dispute Research Detail      |
		| Delete Dispute Research Detail    |
		| Add Branch                        |
		| Edit Branch                       |
		| Delete Branch                     |
		| Add Charter/Branding              |
		| Edit Charter/Branding             |
		| Delete Charter/Branding           |
		| Contacts Lookup                   |
		| Edit Contacts Lookup              |
		| Delete Contacts Lookup            |
		| Transaction Decline Reason        |
		| Edit Transaction Decline Reason   |
		| Delete Transaction Decline Reason |
		| Batch Reporting Reference         |
		| Edit Batch Reporting Reference    |
		| Delete Batch Reporting Reference  |
		

	And User validates the following UI Controls on Add Lookup Values Page
		| Fields    |
		| Text Area |
		| Save      |
		| Close     |


Scenario: Style
	Given User clicks on Style Button on Company Details Page
	And User validates the following UI Controls on Style Button Page
		| UI Controls                  |
		| Primary Buttons Color        |
		| Secondary Buttons Color      |
		| Primary Buttons Font Color   |
		| Secondary Buttons Font Color |