Feature: MyTasks

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@tag1
Scenario: MyTasks
	And User clicks the Submissions Field on the Dashboard page
	And User selects the My Tasks Field from the dropdown menu of Submissions
	And User validates the following Fields on My Tasks Page
		| Fields            |
		| Show Closed Tasks |
		| Actions           |
		| Status            |
		| Task              |
		| Case ID           |
		| Created On        |
		| Assigned On       |
	And User clicks the Dashboard Icon
