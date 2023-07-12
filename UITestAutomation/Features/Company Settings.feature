Feature: Company Settings

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@tag1
Scenario: Company Settings
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Company Settings Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on Company Settings Page
		| UI Control                              |
		| Provisional Credit Days                 |
		| Audit Start                             |
		| Audit End                               |
		| Daily GL Cut-Off Time                   |
		| Post On Saturdays                       |
		| Post 7 Days a Week                      |
		| Statement Date                          |
		| Use Last Business Date                  |
		| Customer Create/Update Settings         |
		| Hide Address2                           |
		| Hide Address3                           |
		| Hide Address4                           |
		| Hide City                               |
		| Hide State                              |
		| Hide Zip                                |
		| Enable Task                             |
		| Display Task Configuration and Sections |
		| Save                                    |
	And User clicks the Dashboard Icon