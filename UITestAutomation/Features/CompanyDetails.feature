Feature: CompanyDetails
 
 
 Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@CompanyDetails

Scenario: Company Details
    Given  User clicks the Profile Icon on the Dashboard page
	And   User selects the Company Details Field from the dropdown menu of ProfileIcon
	And   User validates the following UI Controls on Company Details Page
	    | UI Controls              |
	    | Basic Info               |
	    | General Settings         |
	    | Lookup Values            |
	    | Style                    |
	    | Save                     |
	   

Scenario: Basic Info
    And   User selects the Basic Info button on Company Details Page
	And   User validates the following fields on Basic Info Page

            | Fields                   |
            | Company Name             |
            | Address                  |
            | City                     |
            | State                    |
            | Zip                      |
            | Phone                    |
            | Email                    |
            | Support Email            |
            | Email Distribution List  |
            | Time Zone                |
            | Read only Questionnaires |
	
	 

Scenario: General Settings
    Given  User clicks on the General Settings button on Company Details Page
    And    User validates the following fields on General Settings Page
	 | Fields                 |
	 | Signature Pad          |
	 | Idle Timeout (minutes) |
	 | Statement Cycle        |
	 | Company Logo           |
	



Scenario: Lookup Values
   Given  User clicks on the Lookup Values button on Company Details Page
   And    User validates the following UI Controls on Lookup Values Page
    | UI Controls    |
    | Add  Button    |
    | Edit  Button   |
    | Delete  Button |

	And User clicks on Add Submission Status Button on Company Details Page
	And User validates the following fields on Company Details Page
	| Fields                    |
	| Submission Dispute Status |
	| Save                      |
	| Close                     |
	
	And User clicks on Add Source Button on Company Details Page
	And User validates the following fields on Company Details Page
	| Fields                             |
	| Breach Source (example Home Depot) |
	| Save                               |
	| Close                              |

	And User clicks on Add Account Type Button on Company Details Page
	And User validates the following fields on Company Details Page
	| Fields           |
	| Add Account Type |
	| Display Name     |
	| Save             |
	| Close            |

	And User clicks on Add Dispute Research Detail
	And User validates the following fields on Company Details Page
	| Fields                      |
	| Add Dispute Research Detail |
	| Save                        |
	| Close                       |
	
	And User clicks on Add Branch
	And User validates the following fields on Company Details Page
	| Fields     |
	| Add Branch |
	| Save       |
	| Close      |

	And User clicks on Charter/Binding
	And User validates the following fields on Company Details Page
	| Fields                 |
	| Add Charter / Branding |
	| Save                   |
	| Close                  |

	And User clicks on Contacts Lookup
	And User validates the following fields on Company Details Page
	| Fields          |
	| Contacts Lookup |
	| Reference       |
	| Save            |
	| Close           |
	
	And User clicks on Transaction Decline Reason
	And User validates the following fields on Company Details Page
	| Fields                     |
	| Transaction Decline Reason |
	| Save                       |
	| Close                      |
	

	And User clicks on Batch Reporting Reference
	And User validates the following fields on Company Details Page
	| Fields                    |
	| Batch Reporting Reference |
	| Save                      |
	| Close                     |


Scenario: Style
   Given User clicks on Style Button on Company Details Page
   And   User validates the following UI Controls on Company Details Page
    | UI Controls                  |
    | Primary Buttons Color        |
    | Secondary Buttons Color      |
    | Primary Buttons Font Color   |
    | Secondary Buttons Font Color |
    | Save                         |