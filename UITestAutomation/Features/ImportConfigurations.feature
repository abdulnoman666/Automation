Feature: Import Configurations

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@ImportConfigurations

Scenario:  Import Configurations
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Import Configurations option from the drop down menu of the ProfileIcon
	And User validates the following UI Controls on the Import Configurations Page
	| UI Controls           |
	| Import Configurations |
	| Add Configuration     |
	| Edit Configuration    |
	| Refresh               |
	| Action                |
	| ID                    |
	| Name                  |
	And  User clicks the Add Configuration Button on the Import Configurations Page
	And User validates the following fields on the Add Import Configurations Page
	| Fields       |
	| Cross Button |
	| Name         |
	| Delimiter    |
	| Field List   |
	| Checkbox     |
	| Save         |
	| Close        |
	And User clicks the close button on the Add Import Configurations Page
	And User clicks the Dashboard Icon