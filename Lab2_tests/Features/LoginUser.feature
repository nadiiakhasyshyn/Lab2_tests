Feature: LoginUser
	Login a locked_out_user user

@smoke
Scenario: Perform login a locked_out_user user
	Given I enter the data
	When I click on login
	Then I should see alert
