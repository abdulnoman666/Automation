Feature: LedgerBatches

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@LedgerBatches
Scenario: Ledger Batches
    Given User clicks the Ledger Icon on the Dashboard Page
	And User clicks the Ledger Batches Icon from the dropdown of Ledger
	And User validates the following fields on the Ledger Batches Page
	| Fields          |
    | Date Range      |
    | Calendar Button |
    | Triangle Button |
    | Action          |
    | ID              |
    | Process         |
    | Created         |
    | Print Report    |
    | Ledger Entries  |
    | Export Entries  |


Scenario: Ledger Entries
	Given User clicks the Ledger Entries button on the Ledger Batches Page
	And User validates the following fields on the Ledger Entries Page
	| Fields      |
	| Date        |
	| Account     |
	| Customer    |
	| Amount      |
	| Type        |
	| Tran Code   |
	| Description |
	| Close       |