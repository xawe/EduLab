Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowSpecs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
 Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@mytag
 Scenario: Add two numbers V2
	Given the first number is 5
	And the second number is 2
	When the two numbers are added
	Then the result should be 7

@mytag
 Scenario: Not Equal Zero
	Given the first number is 5
	And the second number is 2
	When the two numbers are added
	Then the result should not be 0