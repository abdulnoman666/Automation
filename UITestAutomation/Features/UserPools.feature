Feature: UserPools

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@Add
Scenario: UserPool_Add
	Given User clicks the Profile Icon on Dashboard page
	And User selects the User Pools Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on User Pools Process Page
		| UI Controls      |
		| Add              |
		| Refresh          |
		| Reference Search |
		| Edit             |
		| Delete           |
		| Action           |
		| ID               |
		| Group Name       |
		| Reference        |
		| Users            |
		| Show             |
	And User clicks the Add Pool on Add User Pool Page
	And User validates the following fields on Add User Pool Page
		| Fields                |
		| Pool Name             |
		| Pool Reference        |
		| Pool Users Email List |
		| Close                 |
		| Save                  |
	And User adds following data to respective fields
		| Fields                | values           |
		| Pool Name             | Susan            |
		| Pool Reference        | ABC              |
		| Pool Users Email List | abdul@finboa.com |
	And User clicks the Save Button on Add User Pool Page
	And User validates the total number of Action Fields on User Pools Process Page
	And User clicks the Dashboard Icon

#@Edit
#Scenario: UserPool_Edit
#	Given User clicks the Edit Pool on Add User Pool Page
#	And User validates the following fileds on Edit User Pool Page
#
#		| Fields                |
#		| Pool Name             |
#		| Pool Reference        |
#		| Pool Users Email List |
#		| Close                 |
#		| Update                |
#
#@Delete
#Scenario: UserPool_Delete
#	Given User clicks the Delete Pool on Add User Pool Page
#	And User validates the following Controls on Confirm Deletion Page
#
#		| Controls |
#		| Yes      |
#		| No       |


