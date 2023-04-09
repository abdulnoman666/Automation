Feature: AlertDefinitions

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@tag1
Scenario: Add Alert Definitions
	Given User clicks the Profile Icon on the Dashboard page
	And User selects the Alert Definitions Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on Alert Definitions Page
		| UI Controls                     |
		| Add Alert Definitions           |
		| Delete Alert Definitions        |
		| Edit Alert Definitions          |
		| Copy Alert Definitions          |
		| Create Default Alert Definition |
		| Download from library           |

Scenario: Add Definition
	And User selects the Add Alert Definitions button on Company Details Page
	And User validates the following fields on General tab on Add Definition Popup
		| Fields                          |
		| Definition Name                 |
		| Alert Type                      |
		| Table Name                      |
		| Deadline Reference              |
		| Business Days                   |
		| Calculate The Last Business Day |
		| Days                            |
		| Reference                       | 
		| Source List                     |
		| Save                            |
		| Close                           |

	And User validates the following fields on Explanation tab on Add Definition Popup
		| Fields      |
		| Explanation |