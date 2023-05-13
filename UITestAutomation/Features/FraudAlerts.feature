Feature: FraudAlerts

Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@FraudAlerts
Scenario: Fraud Alerts
    Given User clicks the Fraud Alerts Icon on Dashboard page
	And User validates the following UI Controls on the Fraud Alerts Page
	  | UI Controls                         |
	  | Upload Alert File                   |
	  | Enter Alerts Manually               |
	  | Search and set date range           |
	  | Show Submission                     |
	  | Link Card Number to Customer Record |
	  | Delete CAMS Alert                   |
	  | Refresh                             |
	  | Action                              |
	  | Card Number                         |
	  | Uploaded On                         |
	  | Case Number                         |
	  | Entity                              |
	  | Email / Website                     |
	  | Status                              |
	  
Scenario: Upload Alerts File
    Given User clicks the Upload Alerts File button on Fraud Alerts page
	And User validates the following UI Controls on the Upload Alerts File Page
	  | UI Controls            |
	  | Default Case Number    |
	  | Select and Upload File |
	  | Close                  |

Scenario: Enter Alerts Manually 
    Given User clicks the Enter Alerts Manually button on Fraud Alerts page
	And User validates the following UI Controls on the Enter Alerts Manually Page
	  | UI Controls         |
	  | Default Case Number |
	  | Enter CAMs Numbers  |
	  | Save                |
	  | Close               |

Scenario: Search and set date range 
    Given User clicks the Search and set date range button on Fraud Alerts page
	And User validates the following UI Controls on the Search and set date range Page
	  | UI Controls |
	  | Start Date  |
	  | End Date    |
	  | Status      |
	  | Search      |

Scenario: Show Submission 
    Given User clicks the Show Submissione button on Fraud Alerts page
	And User validates the following UI Controls on the Show Submission Page
	  | UI Controls               |
	  | Reported On               |
	  | Customer                  |
	  | Case #                    |
	  | Third Party Breach Source |
	  | Save                      |
	  | Close                     |