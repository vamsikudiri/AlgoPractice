Feature: EditDistance

@DynamicProgrammingTopDown
Scenario Outline: EditDistance with DP top down approach
	Given EditDistance input <String1>, <String2>
	Then EditDistance should be <EditDistance>

	Examples:
	| String1 | String2 | EditDistance |
	| a       | a       | 0            |
	| ab      | a       | 1            |
	| abc     | a       | 2            |
	| abc     | abc     | 0            |
	| abc     | ab      | 1            |
	| abc     | aXbc    | 1            |
	| abc     | abXc    | 1            |
	| abc     | abcX    | 1            |
	| aXbc    | abc     | 1            |
	| abXc    | abc     | 1            |
	| abcX    | abc     | 1            |
	| abcd    | abcX    | 1            |
	| abc     | abX     | 1            |
	| a       | aXY     | 2            |
	| ab      | YXaX    | 3            |
	| aXYbXcY | a       | 6            |
	| abc     | aXbYcZW | 4            |
	| aXYZbc  | ab      | 4            |