Feature: Tasks

 Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@Tasks
Scenario:  Tasks 
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Tasks option from the drop down menu of the ProfileIcon
	And User validates the following UI Controls on the Tasks Page
	| UI Controls  |
	| Add New Task |
	| Edit Task    |
	| Delete Task  |
	| Refresh      |
	| Actions      |
	| ID           |
	| Task Name    |
	| Reference    |
	| User Pool    |

Scenario:  Add New Tasks 
    Given User clicks the Add New Task Icon on the Tasks Page
	And User validates the following fields on the Add Tasks Page
	| Fields       |
	| Task Name    |
	| Reference    |
	| User Pool    |
	| Save         |
	| Close        |	