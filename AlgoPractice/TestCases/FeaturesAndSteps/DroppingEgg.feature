Feature: Dropping Egg
	Number of eggs and number of floors are given.

@DynamicProgrammingTopDown
Scenario Outline: All scenarios of DP bottom up approach
	Given <Eggs>, <Floors> floors
	Then the result should <MinimumNumberOfSteps>

	Examples:
	| Eggs | Floors    | MinimumNumberOfSteps |
	| 01   | 1,2,3,4,5 | 1,2,3,4,5            |
	| 02   | 1,2,3,4,5 | 1,2,2,3,3            |
	| 03   | 1,2,3,4,5 | 1,2,2,3,3            |
	| 04   | 1,2,3,4,5 | 1,2,2,3,3            |
	| 05   | 1,2,3,4,5 | 1,2,2,3,3            |


@DynamicProgrammingBottomUp
Scenario Outline: All scenarios of DP top down approach
	Given <Eggs>, <Floors> floors
	Then the result should <MinimumNumberOfSteps>

	Examples:
	| Eggs | Floors    | MinimumNumberOfSteps |
	| 01   | 1,2,3,4,5 | 1,2,3,4,5            |
	| 02   | 1,2,3,4,5 | 1,2,2,3,3            |
	| 03   | 1,2,3,4,5 | 1,2,2,3,3            |
	| 04   | 1,2,3,4,5 | 1,2,2,3,3            |
	| 05   | 1,2,3,4,5 | 1,2,2,3,3            |

