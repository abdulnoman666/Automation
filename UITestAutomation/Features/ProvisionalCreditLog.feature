Feature: ProvisionalCreditLog

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@ProvisionalCreditLog
Scenario:  Provisional Credit Log             
    Given User clicks the Provisional Credit Log Icon from the dropdown of Disputes Page
	And User validates the following fields on the Provisional Credit Log Page
	| Fields                   |
	| Refresh Submissions      |
	| Links                    |
	| Reported                 |
	| P/C Date                 |
	| P/C Amount               |
	| C/L Amount               |
	| Denial Reason            |
	| Status                   |
	| Resolution               |
	| Amount                   |
	| Type                     |
	| Customer                 |
	| Edit Dispute Research    |
	| View Original Submission |
