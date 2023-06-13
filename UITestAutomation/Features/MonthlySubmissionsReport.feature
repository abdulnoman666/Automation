Feature: MonthlySubmissionsReport

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@tag1
Scenario: MonthlySubmissionsReport
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Monthly Report Field from the dropdown menu of Submissions
	And User validates the following Fields on Monthly Report Page
		| Fields          |
		| Search By       |
		| Date Range      |
		| Workflow        |
		| From            |
		| To              |
		| Export Disputes |
	And User clicks the Dashboard Icon