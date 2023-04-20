Feature: AuditorLog

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@AuditorLog
Scenario:  Auditor Log             
    Given User clicks the Auditor Log Icon from the dropdown of Disputes Page
	And User validates the following fields on the Auditor Log Page
	| Fields                  |
	| Show Closed Submissions |
	| Edit Dispute            |
	| View Submission         |
	| Links                   |
	| Reported                |
	| P/C                     |
	| N/S                     |
	| R/S                     |
	| Resolution              |
	| Amount                  |
	| Type                    |
	| Customer                |