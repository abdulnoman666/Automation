Feature: ChangePassword

A short summary of the feature
Background:
	Given User log into Dispute Tracking Application
	And   User should be able to see Dashboard in Application
@tag1
Scenario: Change Password
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Change Password Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on Change Password Page
		| UI Control      |
		| Change Password |
		| Submit          |
	And User validates the following Fields on Change Password Page
		| Fields           |
		| Current Password |
		| New Password     |
		| Confirm Password |
	And User clicks the Dashboard Icon 


