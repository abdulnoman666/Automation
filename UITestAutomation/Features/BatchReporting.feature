Feature: Batch Reporting

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application
@BatchReporting


Scenario: Batch Reporting
	Given User clicks the ProfileIcon on the Dashboard Page
	And User selects the Batch Reporting option from the drop down menu of the ProfileIcon
	And User validates the following UI Controls on the Batch Reporting Page
	
	| UI Controls     |
	| Batch Reference |
	| Date Range      |
	| Calendar Icon   |
	| Print Report    |
	| Export Disputes |