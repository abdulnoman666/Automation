Feature: Users

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@Add
Scenario: Users
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Users Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on Users Page
		| UI Controls                 |
		| Add                         |
		| Refresh                     |
		| Edit                        |
		| Delete                      |
		| Show Deleted Users          |
		| Go                          |
		| Enter Page                  |
		| Action                      |
		| Name                        |
		| Email                       |
		| Phone                       |
		| Role                        |
		| Deleted                     |
		| Has Login                   |
		| Branch                      |
		| More                        |
		| setpageDirect               |
		| prevpage                    |
		| nextpage                    |
		| setpageDirect(pages.length) |
	And User clicks the Add User on Users Page
	And User validates the following fields on Add User Dialog
		| Fields     |
		| First Name |
		| Last Name  |
		| Email      |
		| Phone      |
		| Role       |
		| Close      |
		| Save       |
	And User clicks the Close Button on Add User Dialog
	And User clicks the Dashboard Icon on Users Page
