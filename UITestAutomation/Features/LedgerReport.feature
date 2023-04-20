Feature: LedgerReport

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@LedgerReport

Scenario: Ledger Report
	Given User clicks the Ledger Report button from the dropdown of Ledger Page
	And User validates the following fields on the Ledger Report Page
	| Fields          |
    | Date Range      |
    | Calendar Button |
    | Triangle Button |
    | Print Report    |
    | Ledger Entries  |
    | Export Entries  |

Scenario: Ledger Entries
	Given User clicks the Ledger Entries button on the Ledger Report Page
	And User validates the following fields on the Ledger Entries Page of Ledger Report Page
	| Fields      |
	| Date        |
	| Account     |
	| Customer    |
	| Amount      |
	| Type        |
	| Tran Code   |
	| Description |
	| Close       |