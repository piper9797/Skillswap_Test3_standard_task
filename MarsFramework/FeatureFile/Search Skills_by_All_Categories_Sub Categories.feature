Feature: Search Skills
	In order to search skills
	As a user
	I want to be able to search skills

@auto
Scenario:search skills by All Categories, Sub Categories
	Given I have enter a key word in search textarea And I have clicked the search button
	
	Then all the relative result should be on the screen
