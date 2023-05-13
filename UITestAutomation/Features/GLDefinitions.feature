Feature: GL Definitions

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application
@GLDefinitions

Scenario: GL Definitions
    Given User clicks the Profile Icon on Dashboard page
	And User selects the GL Definitions option from the drop down menu of the ProfileIcon
	And User validates the following UI Controls on the GL Definitions Page
	  | UI Controls                |
	  | GL Definition Option       |
	  | Add GL Definition          |
	  | Delete GL Definition       |
	  | Edit GL Definition         |
	  | Copy GL Definition         |
	  | Refresh                    |
	  | Download Letter            |
	  | Show Deleted GL Definition |
	  | Action                     |
	  | Transfer Type              |
	  | GL Account                 |
	  | Description                |
	  | Reference                  |
	  | Source                     |
	  | Branch                     |
	  | Customer Type              |


	And  User clicks the Add GL Definition Icon on the GL Definitions Page
	And  User validates the following fields on the Add GL Definitions Page
	| Fields                           |
	| Transfer Type                    |
	| Transaction Type                 |
	| Transfer Account                 |
	| Transfer GL Code                 |
	| Transfer Account Type (DDA, SAV) |
	| Transfer Description             |
	| Transfer Transaction Code        |
	| Transfer GL Branch Code          |
	| Transfer GL Cost Center          |
	| GL Account                       |
	| GL Code                          |
	| GL Transaction Code              |
	| GL Branch Code                   |
	| GL Cost Center                   |
	| GL Description                   |
	| Reference                        |
	| Workflow                         |
	| Branch                           |
	| Customer Type                    |
	| Save                             |
	| Close                            |
	| Delete Definition                |

	And  User clicks the Download from Library Button on the GL Definitions Page
	And  User validates the following fields on the Download from Library Button Page
	| Fields                 |
	| Cross Button 2         |
	| Search Bar             |
	| Search Button          |
	| Action                 |
	| ID                     |
	| Description            |
	| Download GL Definition |
	| Close                  |
