Feature: CycleCodeMaps

Background:
	Given User log into Dispute Tracking Application
	And User should be able to see Dashboard in Application

@tag1
Scenario: Cycle Code Maps
	Given User clicks the Profile Icon on Dashboard page
	And User selects the Cycle Code Maps Field from the dropdown menu of Profile Icon
	And User validates the following UI Controls on Cycle Code Maps Page
		| UI Controls           |
		| Add Cycle Code Map    |
		| Delete Cycle Code Map |
		| Edit Cycle Code Map   |
	And user clicks the add cycle code map on Cycle Code Maps Page
	And User validates the following Fields on Add Cycle Code Maps Popup
		| Fields       |
		| Cycle Code   |
		| Mapped Value |
		| Save         |
		| Close        |
	And user clicks the close button on add cycle code map on Cycle Code Maps Page
	And User clicks the Dashboard Icon