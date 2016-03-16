Feature: PartitionProblem

@DynamicProgrammingTopDown
Scenario Outline: PallondromPartitioning Testing
	Given PartitionProblem input <Set> 
	Then PartitionProblem solution should be <CanBePartitioned>
	
	Examples: 
	| Set       | CanBePartitioned |
	| 0         | true             |
	| 1         | false            |
	| 2         | false            |
	| 1,2       | false            |
	| 1,2,3     | true             |
	| 1,2,3,4   | true             |
	| 9,8,1,2,0 | true             |
	| 1,5,11,5  | true             |
	| 1,5,3     | false            |