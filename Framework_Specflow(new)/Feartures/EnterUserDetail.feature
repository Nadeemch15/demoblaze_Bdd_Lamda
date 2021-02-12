Feature: EnterUserDetail
	

@mytag
Scenario Outline: Enter User Detail
	Given I am on Website "https://www.demoblaze.com/"
	And I clicked Login button
	When I entered credentials <Username> <Password>
	Then I am sussessfully logged in

	Examples: 
	| Username | Password |
	| Test103  |12345678  |