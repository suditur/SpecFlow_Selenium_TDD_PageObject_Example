Feature: NavigateSpecfFlowExcel
	In order to navigate to Specflow-Excel documentation
	As a Specflow user
	I want to Select Specflow+-->Specflow+-Excel

Scenario: Navigate to Specflow+
	Given the specflow page	
	When I press Specflow+
	And Specflow+-Excel
	Then I'm able to see 'Get Started Now with SpecFlow+ Excel!' button