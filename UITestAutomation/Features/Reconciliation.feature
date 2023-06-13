Feature: Reconciliation

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application
@tag1
Scenario: Reconciliation
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
	And User clicks the Dashboard Icon