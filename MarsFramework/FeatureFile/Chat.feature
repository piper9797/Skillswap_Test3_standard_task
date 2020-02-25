Feature: Chat
	In order to talk with other people
	As a user
	I want to chat with others
@auto
Scenario:chat with others
	Given I have entered chat page and send one message to someone
	
	Then the chat histry should be on the screen
