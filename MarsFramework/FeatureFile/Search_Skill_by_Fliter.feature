Feature: Search_Skills_by_Fliter
	In order to search skill by fliter
	As a user
	I want to be able to search skills by different fliter

@auto
Scenario:  search skill by fliter
	Given I have entered the search page and click each fliter
	
	Then the result should be differnt when I clicked different fliter
