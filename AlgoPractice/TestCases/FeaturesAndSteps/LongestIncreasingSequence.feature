Feature: LongestIncreasingSequence


@SimpleRecursive
Scenario Outline: LongestIncreasingSequence Testing by SimpleRecursive
	Given LongestIncreasingSequence sequence <Sequence> 
	Then LongestIncreasingSequence solution should be <MaxLength>
	
	Examples: 
	| Sequence                          | MaxLength |
	| 10, 22, 9, 33, 21, 50, 41, 60, 80 | 6         |
	| 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9   | 7         |
	| 1, 3, 5, 8, 0, 2, 6, 7, 6, 8, 9   | 7         |
	| 1, 3, 5, 0, 0, 2, 6, 7, 6, 8, 9   | 7         |


@DynamicProgrammingBottomUp
Scenario Outline: LongestIncreasingSequence Testing by DynamicProgrammingBottomUp
	Given LongestIncreasingSequence sequence <Sequence> 
	Then LongestIncreasingSequence solution should be <MaxLength>
	
	Examples: 
	| Sequence                          | MaxLength |
	| 10, 22, 9, 33, 21, 50, 41, 60, 80 | 6         |
	| 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9   | 7         |
	| 1, 3, 5, 8, 0, 2, 6, 7, 6, 8, 9   | 7         |
	| 1, 3, 5, 0, 0, 2, 6, 7, 6, 8, 9   | 7         |
