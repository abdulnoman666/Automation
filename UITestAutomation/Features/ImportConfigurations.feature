Feature: Import Configurations

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@ImportConfigurations

Scenario:  Import Configurations
	Given User clicks the ProfileIcon on the Dashboard Page
	And User selects the Import Configurations option from the drop down menu of the ProfileIcon
	And User validates the following UI Controls on the Import Configurations Page
	| UI Controls        |
	| Add Configuration  |
	| Edit Configuration |
	| Refresh            |

	And  User clicks the Add Configuration Icon on the Import Configurations Page
	And User validates the following fields on the Import Configurations Page
	| Fields              |
	| Name                |
	| Delimiter           |
	| Field List          |
	| Header in First Row |

    When User clicks the save Button on the Import Configurations Page
    Then User will be able to see the new information in the fields on the Import Configurations Page