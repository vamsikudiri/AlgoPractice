Feature: MinimumNumberOfJumps

@DynamicProgrammingTopDown
Scenario Outline: MinimumNumberOfJumps Testing
	Given MinimumNumberOfJumps sequence <Sequence> 
	Then MinimumNumberOfJumps solution should be <Jumps>
	
	Examples: 
	| Sequence                        | Jumps |
	| 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 | 3     |
	| 1, 3, 5, 8, 0, 2, 6, 7, 6, 8, 9 | 3     |
	| 1, 3, 5, 0, 0, 2, 6, 7, 6, 8, 9 | 4     |


