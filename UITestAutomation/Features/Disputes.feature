Feature: Disputes

 Background: 
	 Given User log into Dispute Tracking Application
	 And User should be able to see Dashboard in Application

@Disputes
Scenario:  Disputes 
	Given User clicks the Disputes Icon on Dashboard page
	And User selects the Disputes option from the drop down menu of the Disputes Page
	And User validates the following UI Controls on the Disputes Page
	| UI Controls                      |
	| Alerts                           |
	| Search and set date range        |
	| Select User or Search in list... |
	| Refresh Submissions              |
	| Show Closed Disputes             |
	| 1                                |
	| 2                                |
	| 3                                |
	| 4                                |
	| 5                                |
	| 6                                |
	| Links                            |
	| Reported                         |
	| Days                             |
	| Status                           |
	| Detail                           |
	| Resolution                       |
	| Amount                           |
	| Recovered                        |
	| Customer                         |	
	| Assigned To                      |
	| Status Field                     |
	| Resolution Field                 |
	| Amount Field                     |
	| Customer Field                   |
	| Edit Dispute                     |
	| View Original Submission         |

Scenario:  Settings Button 
    Given User clicks the Settings Button on the Disputes Page
	And User validates the following fields on the Settings Page
	| Fields      |
	| Reported    |
	| Days        |
	| Status      |
	| Detail      |
	| Resolution  |
	| Amount      |
	| Recovered   |	
	| Customer    |
	| Assigned To |

Scenario:  Search Button 
    Given User clicks the Search Button on the Disputes Page
	And User validates the following fields on the Search Page
	| Fields              |
	| Start Date          |
	| End Date            |
	| Search              |
	| Reset               |
	| Status              |
	| Full Card Number    |
	| Full Account Number |
	| * Search            |
	| Reset 2             |
	| Close               |


	Scenario:  Edit Dispute            
    Given User clicks the Edit Disputes Button on the Disputes Page
	And User validates the following UI Controls and fields on the Edit Disputes Page
	| UI Controls and Fields           |
	| Research Status                  |
	| Documents                        |
	| History                          |
	| Refresh                          |
	| Submission Disputes              |
	| Save                             |
	| View Submission                  |
	| Resolution Button                |
	| Print Letter                     |
	| POS                              |
	| Foreign Transaction              |
	| Research                         |
	| Detail                           |
	| Closed                           |
	| Close Date                       |
	| Pre-Arbitration                  |
	| Final Resolution Date            |
	| Enter Notes                      |
	| Customer Provisional Credit      |
	| Transaction Amount               |
	| Provisional Credit Amount        |
	| Consumer Liability               |
	| Denial Reason                    |
	| PC Reversal Date                 |
	| Provisional Credit Received      |
	| Provisional Date                 |
	| Provisional Credit Removed       |
	| Removal Date                     |
	| Final Credit                     |
	| Final Date                       |
	| Document Received from Processor |
	| Documents Sent to Cardholder     |
	| Date Research Ended              |
	| Date Resolution Letter Sent      |

Scenario:  Documents Button 
    Given User clicks the Documents button on the Edit Disputes Page
	And User validates the following fields on the Documents Page
	| Fields        |
	| Document List |

Scenario:  History Button 
    Given User clicks the History button on the Edit Disputes Page
	And User validates the following fields on the History Page
	| Fields      |
	| Date        |
	| Description |
	| By          |
	| Type        |

Scenario:  Resolution Button 
    Given User clicks the Resolution Button on the Edit Disputes Page
	And User validates the following fields on the Resolution Page
	| Fields                         |
	| Claim Result                   |
	| Pending                        |
	| Claim Approved                 |
	| Claim Declined                 |
	| Merchant Credit                |
	| Loss Status                    |
	| Not Selected                   |
	| Bank Loss                      |
	| Merchant Loss                  |
	| Consumer Loss                  |
	| Amount Recovered               |
	| Provisional Date               |
	| Final Date                     |
	| PC Reversal Date               |
	| Credit Customer Account For    |
	| Debit Customer Account For     |
	| Merchant Credited Customer For |
	| Resolve and Post to GL         |
	| Close                          |
	| Save                           |
