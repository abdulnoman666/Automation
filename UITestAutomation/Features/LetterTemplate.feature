Feature: LetterTemplate

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@Add
Scenario: Letter Template
	Given User clicks the Profile Icon on the Dashboard page
	And User selects the Letter Template Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on Letter Template Page

		| UI Controls           |
		| Add                   |
		| Delete                |
		| Edit                  |
		| Download from Library |
		| Copy Letter           |
		| Action                |
		| Refresh               |
		| ID                    |
		| Title                 |
		| Table/Module          |
		| Reference             |
		| Enter Page            |
	And User clicks the Add Letter Template Icon on Letter Template Page
	And User validates following fields on Letter info Dialog
		| Field                                      |
		| Title                                      |
		| Description                                |
		| Author                                     |
		| File name to save letter on printing       |
		| Subject line when sending letter via email |
		| Table Name                                 |
		| Reference                                  |
		| Workflows                                  |
		| SQL Command Name                           |
		| Is input Form?                             |
		| Is Consent notice?                         |
		| Use Cut-Off print date?                    |
		| Eligible for E-Signature?                  |

	And User validates following fields on Template Dialog
		| Field                |
		| Letter Template Form |

	And User validates following fields on Style Sheet Dialog
		| Field           |
		| Title           |
		| Style Sheet     |
		| Delete Template |
		| Copy Template   |
		| Save Template   |
		| Close Template  |
	
		

