Feature: QuestionnaireDependencySetup

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@Add
Scenario: Add Questionnaire Dependency Setup
	Given User clicks the Profile Icon on the dashboard page
	And User Selects the Questionnaire Dependency Setups from the dropdown menu of the Page
	And User validates following UI controls on Questionnaire Dependency Setup Page
	
		| UI Controls      |
		| Add              |
		| Delete           |
		| Edit             |
		| Copy Form        |
		| Condition Search |
	And User clicks the Add Questionnaire Dependency Setup Icon on Questionnaire Dependency Setup Page
	And User validates following fields on Add Questionnaire Dependency Setup
		| Field         |
		| Workflow Name |

@Edit
Scenario: Edit Questionnaire Dependency Setup
	Given User clicks on the Edit Questionnaire Dependency Setup button on the Questionnaire Dependency Setup Page
	And User validates the following fileds on Edit Questionnaire Dependency Setup Page
		| Field         |
		| Workflow Name |
		
@Delete
Scenario: Delete Questionnaire Dependency Setup
	Given User clicks on the Delete Questionnaire Dependency Setup button on Page
	And User validates the following Controls on Confirm Deletion Popup

		| Controls |
		| Yes      |
		| No       |