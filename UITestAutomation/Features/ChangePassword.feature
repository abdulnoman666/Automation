﻿Feature: ChangePassword

A short summary of the feature
Background: 
            Given User Log into Dispute Tracking Application
			And   User should be ableto see the Dashboard in the Application
@tag1
Scenario: Change Password
	Given User clicks the Profile Icon on the Dashboard page
	And   User selects the Change Password Field from the dropdown menu of Profile Icon
	And   User validates the following UI Controls on Change Password Page

	      | UI Control      |
	      | Change Password |
	      | Submit          |

    And   User validates the following Fields on Change Password Page

	       | Fields           |
	       | Current Password |
	       | New Password     |
	       | Confirm Password |

