Feature: Verifying vehicle exists by entering registration number
	In order to verify given vehicle exists
	As a user
	I want to enter vehicle detals

@vehicleexists
Scenario: Verifying valid Registration Number
	Given I am in URL https://covercheck.vwfsinsuranceportal.co.uk/
	When I enter Vehicle registration number OV12UYY 
	And I press submit button
	Then I should  see vehicle detail


Scenario Outline: Verifying Invalid Registration Number
Given I am in URL https://covercheck.vwfsinsuranceportal.co.uk/
When I enter invalid registration details <RegNum>
And I press submit button
Then I should see a  message 
Examples:
| RegNum | 
| OV12YY    |                 
| OV123VNUYY |  


Scenario: Verifying page  with blank registration number
Given I am in URL https://covercheck.vwfsinsuranceportal.co.uk/
When I press submit button
Then a message is displayed