Feature: Submissions

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@tag1
Scenario: Submissions
	Given User clicks the Submissions Field on the Dashboard page
	And User selects the Task Reports Field from the dropdown menu of Submissions
	And User validates the following Fields on Task Reports Page
		| Fields       |
		| Workflow     |
		| From         |
		| To           |
		| Export Tasks |
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Monthly Report Field from the dropdown menu of Submissions
	And User validates the following Fields on Monthly Report Page
		| Fields          |
		| Search By       |
		| Date Range      |
		| Workflow        |
		| From            |
		| To              |
		| Export Disputes |
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Reset Submission Field from the dropdown menu of Submissions
	And User validates the following Fields on Reset Submission Page
		| Fields        |
		| Submission ID |
		| Reset         |
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Delete Submission Field from the dropdown menu of Submissions
	And User validates the following Fields on Delete Submission Page
		| Fields        |
		| Submission ID |
		| Delete        |
	And User clicks the Submissions Field on the Dashboard page
	And User selects the My Tasks Field from the dropdown menu of Submissions
	And User validates the following Fields on My Tasks Page
		| Fields            |
		| Show Closed Tasks |
		| Actions           |
		| Status            |
		| Task              |
		| Case ID           |
		| Created On        |
		| Assigned On       |
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Reconciliation Field from the dropdown menu of Submissions
	And User validates the following Fields on Reconciliation Page
		| Fields            |
		| Reported On       |
		| Customer          |
		| Source            |
		| Status            |
		| Dispute Type      |
		| Total             |
		| PC Amount         |
		| PC Rev Amount     |
		| Merchant Credit   |
		| Final Credit      |
		| Insurance Amount  |
		| Chargeback Amount |
		| Other Fees        |
		| Action            |
		| Reset             |
		| Save              |
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Submissions With Alerts Field from the dropdown menu of Submissions
	And User validates the following UI Controls on Submissions With Alerts Page
		| UI Controls     |
		| Settings        |
		| Refresh Alerts  |
		| Enter Page      |
		| Go              |
		| Edit Submission |
	And User validates the following Fields on Submissions With Alerts Page
		| Fields      |
		| Action      |
		| ID          |
		| Customer    |
		| Status      |
		| Source      |
		| Alert       |
		| Alert Type  |
		| Deadline    |
		| Assigned To |
	And User clicks the Submissions Field on the Dashboard page
	And User selects the Activity History Field from the dropdown menu of Submissions
	And User validates the following Fields on Activity History Page
		| Fields                                      |
		| Download History                            |
		| Refresh                                     |
		| Start Date                                  |
		| End Date                                    |
		| Event Type (select one or more event types) |
		| Users (select one or more users)            |
		| Reset                                       |
		| Search                                      |
		| Action                                      |
		| ID                                          |
		| Sub Case                                    |
		| Workflow                                    |
		| User Name                                   |
		| Type                                        |
		| Automation                                  |
		| Created                                     |
	And User clicks the Submissions Field on the Dashboard page

	And User selects the Submissions List Field from the dropdown menu of Submissions
	And User validates the following UI Controls on Submissions List Page
		| UI Controls                   |
		| New Case                      |
		| Settings                      |
		| Search                        |
		| Refresh                       |
		| All Originators               |
		| All Assignee                  |
		| Enter Page                    |
		| Go                            |
		| Show Closed Submissions       |
		| View Submission               |
		| Reassign Submission           |
		| Delete or Withdraw Submission |
	And User validates the following Fields on Submissions List Page
		| Fields                   |
		| Action                   |
		| Sub Case                 |
		| Customer                 |
		| Workflow                 |
		| Reported                 |
		| Days                     |
		| Processor Case Reference |
		| Status                   |
		| PT                       |
		| Total                    |
		| Orig                     |
		| Assigned To              |
	And User clicks the Reassign Submission Icon on Submissions List Page
	And User validates the following UI Controls on Reassign Submission Dialog
		| UI Controls |
		| Processors  |
		| Cancel      |
		| Assign Case |
	And User clicks the Cancel Button on Reassign Submission Dialog
	And User clicks the New Case Button on Submissions List Page
	And User Enters the following data into the fields on Dispute Submission Page
		| Field              | Value      |
		| Transaction Method | Debit Card |
	And User clicks the Fraud Button from Listed Transactions on Dispute Submission Page
	And User clicks the Advanced Search Button on Dispute Submission Page
	And User Enters the following data into the fields on Customer Search Page
		| Field         | Value  |
		| Customer Name | singal |
	And User clicksthe Search Button on Customer Search Page
	And User Selects the Customer from the Customers Dialog
	And User Enters the following data on Dispute Submission Page
		| Field   | Value         |
		| Details | UI Automation |
	And User clicks the Additional Tasks on Dispute Submission Page
	And User selects the following data from the field on Add Task Page
		| Field     | Value            |
		| Task Name | Send to Customer |
	And User clicks the Save Button on Add Task Page
	And User clicks the Transaction List on Dispute Submission Page
	And User Enters the following data on Add Transaction Page
		| Field           | Value |
		| Amount          | 1200  |
		| Disputed Amount | 1000  |
		| Merchant        | Abdul |
		| Detail          | abc   |
	And User clicks the Save Button on Add Transaction Page
	And User clicks the Next Button on Dispute Submission Page
	And User clicks the Yes Button for Debit Card possession on Debit Card Dispute Form
	And User clicks the Yes Button for Stolen Card Report
	And User enters the Date in Filed Date field
		| Field      | Value      |
		| Filed Date | 11/31/2022 |
	And User Enters the following data on Debit Card Dispute Form
		| Field                | Value |
		| City Report Filed In | abc   |
	And User clicks the Button for Check appropriate dispute reason
	And User clicks No Button for Card has been closed
	And User Enters the following data in Date Card Closed on Debit Card Dispute Form
		| Field            | Value |
		| Date Card Closed | abc   |
	And User clicks the Customer Signature form Button on Debit Card Dispute Form
	And User clicks the Confirm Electronic Signautre Consent Button
	And User clicks the Acknowledgment Button
	And User clicks the Confirm Button
	And User clicks in the Signature Field on Debit Card Dispute Form
	And User clicks the Acknowledge Button on Debit Card Dispute Form
	And User clicks the Done Button
	And User validates the following Fields in Submission Info Dialog on Edit Submission Page
		| Fields                  |
		| Print Letter            |
		| Select PC Calculation   |
		| Edit Submission         |
		| Process.Transactions    |
		| Run Automation          |
		| Edit Customer           |
		| All Submission          |
		| Activity History        |
		| Refresh Submissions     |
		| Transactions            |
		| Comments and Resolution |
		| Save Comments           |
		| Public                  |
		| Date                    |
		| Created By              |
		| Notes                   |
		| Add Note                |
		| View All                |
		| Status                  |
		| Task Name               |
		| Created On              |
		| Assigned To             |
		| Assigned On             |
		| Closed On               |
		| Calculate Interest      |
		| Pre-Auth                |
		| Date Transaction        |
		| DeadlineTransaction     |
		| POS                     |
		| FT                      |
		| Amount                  |
		| Disputed Amount         |
		| Merchant                |
		| Do Not Send             |
	And User clicks the Questionnaire on Edit Submission Page
	And User validates the following Fields in  Questionnaire Dialog
		| Fields                   |
		| Questionnaire            |
		| Save Questionaire to PDF |
		| Print Questionaire       |
		| Email Questionaire       |
	And User clicks the Forms on Edit Submission Page
	And User validates the following Fields in Forms Dialog
		| Fields                           |
		| Select Form to View              |
		| Save Form Data                   |
		| Save PDF                         |
		| Send to Customer for E-Signature |
	And User clicks the Disputes on Edit Submission Page
	And User validates the following Fields in Disputes Dialog
		| Fields                           |
		| Select Automation                |
		| Run Selected Workflow Automation |
		| Settings Dispute                 |
		| Hide Closed Disputes             |
		| Submission Info                  |
		| Action                           |
		| Id                               |
		| Transaction Date                 |
		| Amount                           |
		| Merchant                         |
		| PC                               |
		| Status                           |
		| Research Detail                  |
		| Notes                            |
	And User clicks the Research on Edit Submission Page
	And User validates the following Fields in Research Dialog
		| Fields           |
		| Submit Cases     |
		| Link Multiple    |
		| Activity History |
		| Refresh          |
		| Actions          |
		| Id               |
		| Master Case      |
		| Fraud Report     |
		| Visa Case Number |
		| POS              |
		| PIN              |
		| 3DS              |
		| Fallback         |
		| MCC              |
		| Country          |
		| Nwk              |
		| PI               |
		| RDR              |
		| Transaction Date |
		| Amount           |
		| Merchant         |
		| Visa Status      |
		| Link             |
	And User clicks the Customer Status on Edit Submission Page
	And User validates the following Fields in Customer Status Dialog
		| Fields                                     |
		| Case Number                                |
		| Third Party Breach Source                  |
		| CAMS Case Number                           |
		| Amount Prevented by Fraud Detection System |
		| Submission Status                          |
		| Provisional Credit Reversed                |
		| Resolution Notice Sent                     |
		| Merchant Credit                            |
		| Merchant Credit Date                       |
		| Final Credit                               |
		| Final Credit Date                          |
		| Insurance Amount                           |
		| Chargeback Amount                          |
		| Other Fees                                 |
		| Fee Reversal Amount                        |
		| Interest Credit Amount                     |
		| Processor Resolution Date                  |
		| Processor Case Date                        |
		| Save                                       |
	And User clicks the Contacts on Edit Submission Page
	And User validates the following Fields in Contacts Dialog
		| Fields        |
		| Contact Name  |
		| Reference     |
		| Phone Contact |
		| Email         |
		| Action        |
		| Download      |
	And User clicks the GL Ledger on Edit Submission Page
	And User validates the following Fields in GL Ledger Dialog
		| Fields              |
		| Date                |
		| Description         |
		| GL Account          |
		| Account             |
		| Transaction Code    |
		| Amount              |
		| Delete Ledger Entry |
		| Add GL Transaction  |
	And User clicks the Documents on Edit Submission Page
	And User validates the following Fields in Documents Dialog
		| Fields                    |
		| Delete Document           |
		| Download Document         |
		| Edit Document Description |
	And User clicks the Dashboard Icon








