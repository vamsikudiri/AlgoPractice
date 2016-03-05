Feature: LongestCommonSubSequence
Two strings are given, we need to find LongestCommonSubSequence.

@DynamicProgrammingBottomUp
Scenario Outline: Some scenarios of inputs for bottom up approach
	Given input of LongestCommonSubSequence <String1>, <String2>
	Then the LongestCommonSubSequence should be <SubSequence>

	Examples:
	| String1    | String2         | SubSequence |
	| a          | 1a23a4a5        | a           |
	| ab         | 1a23a4a5        | a           |
	| abc        | 1ab23c45        | abc          |
	| abc        | 1abc23ab4abcd5  | abc         |
	| abc        | 1abc2abc34abc5  | abc         |
	| abcd       | 1abc2abc34abc5  | abc         |
	| xa         | 1a23a4a5        | a           |
	| xab        | 1a23a4a5        | a           |
	| xabc       | 1ab23c45        | abc          |
	| xabc       | 1abc23ab4abcd5  | abc         |
	| xabc       | 1abc2abc34abc5  | abc         |
	| xabcd      | 1abc2abc34abc5  | abc         |
	| xaxa       | 1a23a4a5        | aa           |
	| xabxab     | 1a23a4a5        | aa           |
	| xabcxabc   | 1ab23c45        | abc          |
	| xabcxabc   | 1abc23ab4abcd5  | abcabc         |
	| xabcxabc   | 1abc2abc34abc5  | abcabc         |
	| xabcdxabcd | 1abc2abc34abc5  | abcabc         |
	| aa         | 1a23a4a5        | aa          |
	| ab         | 1a23a4a5        | a           |
	| abc        | 1ab23c45        | abc         |
	| axbycd     | 1abc23ab4abc5d  | abcd        |
	| a#b#c      | 1abc2abc34abc5  | abc         |
	| #a#b#c#d#  | 1abc2abc34abc5d | abcd        |