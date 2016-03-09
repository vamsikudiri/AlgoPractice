Feature: PallondromPartitioning
	Finding minimum no of partitions





@DynamicProgrammingTopDown
Scenario Outline: PallondromPartitioning Testing
	Given PallondromPartitioning input <String> 
	Then minimum number of partitions are <NumberOfPartitions>
	
	Examples: 
	| String | NumberOfPartitions |
	| a      | 0                  |
	| ab     | 1                  |
	| abc    | 2                  |
	| aba    | 0                  |