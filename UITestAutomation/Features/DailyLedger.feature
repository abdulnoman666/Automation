Feature: DailyLedger

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@DailyLedger
Scenario: Daily Ledger
	 Given User clicks the Daily Ledger Icon from the dropdown of Ledger
	And User validates the following fields on the Daily Ledger Page
	| Fields         |
	| Refresh Ledger |
	| Date           |
	| Account        |
	| Customer       |
	| Amount         |
	| Type           |
	| Tran Code      |
	| Description    |