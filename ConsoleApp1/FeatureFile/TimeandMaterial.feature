Feature: TimeMaterial
	As a turnup portal admin
	I would like to manage Time and Material records effectively

@mytag
Scenario: Create a new Time and Material record
	Given I have logged into the Turnup portal successfully
	And I create a new Time and Material record
	Then The record should be created successfully

Scenario: Edit an existing Time and Material record
	Given I have logged into the Turnup portal successfully
	And I edit an existing Time and Material record
	Then The record should be edited successfully

	Scenario Outline: Create multiple Time and material records
	Given I have logged into the Turnup portal successfully
	And I create a new Time and Material with below <code>,<description>
	Then The record should be created successfully
	Examples:
	| code | description |
	| test1| Desc1       |
	| test2| Desc2       |
