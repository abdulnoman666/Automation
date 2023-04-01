﻿Feature: FieldUpdateScripts

 Background: 
	 Given User log into Dispute Tracking Application
	 And   User should be able to see Dashboard in Application
@FieldUpdateScript

Scenario: Field Update Scripts
	Given User clicks the Profile Icon on the Dashboard page
	And   User selects the Field Update Scripts option from the dropdown menu of ProfileIcon
	And   User validates the following UI Controls on the Field Update Script Page
	| UI Controls                  |
	| Add Field Update Script      |
	| Download From Library Button |
	| Edit Script                  |
	| Copy Script                  |
	| Delete Script                |
	| Refresh                      |

	And  User clicks the Add Script Icon on the Field Update Script Page
	And  User validates the following fields on the Field Update Script Page
	| Fields               |
	| Script Name          |
	| Unique Reference     |
	| Table                |
	| Field                |
	| Operator             |
	| Value/Function       |
	| Save Button          |
	| Close Button         |
	| Upload to Library    |
	| Add Update to Script |


Scenario: Download From Library Button
   Given User clicks the Download From Library Button on the Field Update Script Page
   And   User validates the following UI Controls and fields on the Field Update Script Page
    | UI Control and Fields    |
    | Search Bar               |
    | Download Template Option |
    | Close Button             |
   And User will be able to see Automation Script Added on the Field Update Script Page	