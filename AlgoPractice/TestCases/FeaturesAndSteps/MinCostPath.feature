Feature: MinCostPath

@DynamicProgrammingTopDown
Scenario Outline: MinCostPath with DP top down approach
	Given MinCostPath input <NumberOfRows>, <NumberOfColumns>, <Matrix>
	Then MinCostPath should be <MinCostPath>

	Examples:
	| NumberOfRows | NumberOfColumns | Matrix            | MinCostPath |
	| 3            | 3               | 1,2,3,4,8,2,1,5,3 | 8           |
	