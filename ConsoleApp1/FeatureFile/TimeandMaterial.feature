Feature: TimeandMaterial
	As a TurnUp portal admin
	I would like to manage the Time and Material records effectively

@mytag
Scenario: Create a new Time and material record
	Given I have logged into the Turnup portal successfully
	And Verify the title of the page
	And I create a time and material
	Then the record should be created successfully

Scenario: Edit an existing Time and material record
	Given I have logged into the Turnup portal successfully
	And I edit an existing time and material record
	Then the record should be edited successfully

Scenario Outline: Create multiple Time and Material record
	Given I have logged into the Turnup portal successfully
	And I create a time and material with below <codes> <description>
	Then the record should be created successfully
	Examples:
	| code | description |
	| Infy | Maths       |
	| Git  | Science     |

