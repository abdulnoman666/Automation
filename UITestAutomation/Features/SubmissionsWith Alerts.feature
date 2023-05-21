Feature: SubmissionsWith Alerts

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@tag1
Scenario: SubmissionWithAlerts
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Submissions With Alerts Field from the dropdown menu of Submissions
	And User validates the following UI Controls on Submissions With Alerts Page
		| UI Controls     |
		| Settings        |
		| Refresh Alerts  |
		| Enter Page      |
		| Go              |
		| Edit Submission |
	And User validates the following Fields on Submissions With Alerts Page
		| Fields      |
		| Action      |
		| ID          |
		| Customer    |
		| Status      |
		| Source      |
		| Alert       |
		| Alert Type  |
		| Deadline    |
		| Assigned To |
	And User clicks the Dashboard Icon
