Feature: ActivityHistory

A short summary of the feature
Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@tag1
Scenario: ActivityHistory
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Activity History Field from the dropdown menu of Submissions
	And User validates the following Fields on Activity History Page
		| Fields                                      |
		| Download History                            |
		| Refresh                                     |
		| Start Date                                  |
		| End Date                                    |
		| Event Type (select one or more event types) |
		| Users (select one or more users)            |
		| Reset                                       |
		| Search                                      |
		| Action                                      |
		| ID                                          |
		| Sub Case                                    |
		| Workflow                                    |
		| User Name                                   |
		| Type                                        |
		| Automation                                  |
		| Created                                     |
	And User clicks the Dashboard Icon