Feature: BankHolidays

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@Add
Scenario: Bank Holidays
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Bank Holidays Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on Bank Holidays Page
		| UI Controls |
		| Add         |
		| Delete      |
		| Edit        |
		| Action      |
		| Refresh     |
	And User clicks the Add Bank Holidays Icon on Bank Holidays Page
	And User validates following fields on Add Bank Holidays Dialog
		| Fields   |
		| Holidays |
		| Close    |
		| Save     |
	And User clicks the close button on Add Bank Holidays Dialog
	And User clicks the Dashboard Icon


