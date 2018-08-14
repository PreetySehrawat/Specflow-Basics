Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@smoketest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	And I press subtract
	Then the result should be 121 on the screen
	And I view result

Scenario: Create a new employee with mandatory details
#Given I opened my application
#Then I should see employee details page
When I fill all the mandatory details in form
| Name   | Age | Phone      | Email        |
| Myname | 25  | 98765432331 | abcd@xyz.com |
#And I click on Save button
#Then I should see all the details saved in my application and DB

Scenario: Create four new employee with mandatory details
#Given I opened my application
#Then I should see employee details page
When I fill all the mandatory details in form for four
| Name   | Age | Phone      | Email        |
| Myname | 25  | 98765432331 | abcd@xyz.com |
| SecondName | 26  | 987554432331 | abcd2@xyz.com |
| ThirdName | 27  | 987554432771 | abcd3@xyz.com |
| FourthName | 28  | 987554432881 | abcd4@xyz.com |
#And I click on Save button
#Then I should see all the details saved in my application and DB

Scenario Outline: Create four new employee using examples
#Given I opened my application
#Then I should see employee details page
When I fill all the mandatory details in form <Name>, <Age> , <Phone> and <Email>
#And I click on Save button
#Then I should see all the details saved in my application and DB
Examples:
| Name   | Age | Phone      | Email        |
| Myname | 25  | 98765432331 | abcd@xyz.com |
| SecondName | 26  | 987554432331 | abcd2@xyz.com |
| ThirdName | 27  | 987554432771 | abcd3@xyz.com |
| FourthName | 28  | 987554432881 | abcd4@xyz.com |