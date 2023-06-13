Feature: ResetSubmission

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@tag1
Scenario: ResetSubmission
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Reset Submission Field from the dropdown menu of Submissions
	And User validates the following Fields on Reset Submission Page
		| Fields        |
		| Submission ID |
		| Reset         |
	And User clicks the Dashboard Icon