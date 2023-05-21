Feature: DeleteSubmission

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@tag1
Scenario: DeleteSubmission
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Delete Submission Field from the dropdown menu of Submissions
	And User validates the following Fields on Delete Submission Page
		| Fields        |
		| Submission ID |
		| Delete        |
	And User clicks the Dashboard Icon