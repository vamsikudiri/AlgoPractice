Feature: LongestCommonSubString
Two strings are given, we need to find longest common substring.

@DynamicProgrammingTopDown
Scenario Outline: Some scenarios of inputs for top done approach
	Given two strings <String1>, <String2>
	Then the longest common substring should be <SubString>

	Examples:
	| String1    | String2        | SubString |
	| a          | 1a23a4a5       | a         |
	| ab         | 1a23a4a5       | a         |
	| abc        | 1ab23c45       | ab        |
	| abc        | 1abc23ab4abcd5 | abc       |
	| abc        | 1abc2abc34abc5 | abc       |
	| abcd       | 1abc2abc34abc5 | abc       |
	| xa         | 1a23a4a5       | a         |
	| xab        | 1a23a4a5       | a         |
	| xabc       | 1ab23c45       | ab        |
	| xabc       | 1abc23ab4abcd5 | abc       |
	| xabc       | 1abc2abc34abc5 | abc       |
	| xabcd      | 1abc2abc34abc5 | abc       |
	| xaxa       | 1a23a4a5       | a         |
	| xabxab     | 1a23a4a5       | a         |
	| xabcxabc   | 1ab23c45       | ab        |
	| xabcxabc   | 1abc23ab4abcd5 | abc       |
	| xabcxabc   | 1abc2abc34abc5 | abc       |
	| xabcdxabcd | 1abc2abc34abc5 | abc       |



@DynamicProgrammingBottomUp
Scenario Outline: Some scenarios of inputs for bottom up approach
	Given two strings <String1>, <String2>
	Then the longest common substring should be <SubString>

	Examples:
	| String1    | String2        | SubString |
	| a          | 1a23a4a5       | a                      |
	| ab         | 1a23a4a5       | a                      |
	| abc        | 1ab23c45       | ab                     |
	| abc        | 1abc23ab4abcd5 | abc                    |
	| abc        | 1abc2abc34abc5 | abc                    |
	| abcd       | 1abc2abc34abc5 | abc                    |
	| xa         | 1a23a4a5       | a                      |
	| xab        | 1a23a4a5       | a                      |
	| xabc       | 1ab23c45       | ab                     |
	| xabc       | 1abc23ab4abcd5 | abc                    |
	| xabc       | 1abc2abc34abc5 | abc                    |
	| xabcd      | 1abc2abc34abc5 | abc                    |
	| xaxa       | 1a23a4a5       | a                      |
	| xabxab     | 1a23a4a5       | a                      |
	| xabcxabc   | 1ab23c45       | ab                     |
	| xabcxabc   | 1abc23ab4abcd5 | abc                    |
	| xabcxabc   | 1abc2abc34abc5 | abc                    |
	| xabcdxabcd | 1abc2abc34abc5 | abc                    |