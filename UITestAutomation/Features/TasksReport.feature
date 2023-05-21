Feature: TasksReport

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@tag1
Scenario: TasksReport
	Given User clicks the Submissions Field on the Dashboard page
	And User selects the Task Reports Field from the dropdown menu of Submissions
	And User validates the following Fields on Task Reports Page
		| Fields       |
		| Workflow     |
		| From         |
		| To           |
		| Export Tasks |
	And User clicks the Dashboard Icon
