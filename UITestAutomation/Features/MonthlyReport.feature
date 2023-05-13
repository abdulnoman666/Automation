Feature: MonthlyReport

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@MonthlyReport
Scenario:  Monthly Disputes Report             
    Given User clicks the Monthly Report Icon from the dropdown of Disputes Page
	And User validates the following fields on the Monthly Report Page
	| Fields          |
	| Reported On     |
	| Date Range      |
	| Workflows       |
	| Calendar Button |
	| Triangle Option |
	| Print Report    |
	| Summary         |
	| Charts          |
	| List            |
	| Export Disputes |

Scenario:  Summary            
    Given User clicks the Summary button on the Monthly Report Page 
	And User validates the following fields on the Summary Page
	| Fields                     |
	| Submission Count           |
	| Total Claimed              |
	| Total Disputed             |
	| Bank Loss                  |
	| Merchant Loss              |
	| Consumer Loss              |
	| Recovered                  |
	| Pending Provisional Credit |
	| Export                     |
	| Close                      |

Scenario:  List           
    Given User clicks the List button on the Monthly Report Page 
	And User validates the following fields on the List Page
	| Fields      |
	| Reported    |
	| Days        |
	| P/C         |
	| R/S         |
	| C/A         |
	| Status      |
	| Detail      |
	| Resolution  |
	| Amount      |
	| Type        |
	| Customer    |
	| Assigned To |
	| Close       |