Feature: DoublyString
	
@NormalSolution
Scenario Outline: DoublyString test cases
	Given   DoublyString input <String>
	Then DoublyString result should be <IsDoublyString>

	Examples:
	| String                     | IsDoublyString |
	| a                          | false          |
	| aa                         | true           |
	| abcabc                     | true           |
	| abcdabcd                   | true           |
	| Xabcdabcd                  | true           |
	| aXbcdabcd                  | true           |
	| abXcdabcd                  | true           |
	| abcXdabcd                  | true           |
	| abcdXabcd                  | true           |
	| abcdaXbcd                  | true           |
	| abcdabXcd                  | true           |
	| abcdabcXd                  | true           |
	| XabcXdabcd                 | false          |
	| abcdabcdX                  | true           |
	| aXbcdXabcd                 | false          |
	| abXcdaXbcd                 | false          |
	| abcXXdabcd                 | false          |
	| abcdXaXbcd                 | false          |
	| abXcdaXbcd                 | false          |
	| abcXdabXcd                 | false          |
	| abcXdabcXd                 | true           |
	| XabcXdabcd                 | false          |
	| aXbcdXabYcd                | false          |
	| abXcYdaXbcd                | false          |
	| abcXXdabYcd                | false          |
	| abYcdXaXbcd                | false          |
	| abXYcdaXbcd                | false          |
	| abcXdaYbXcd                | false          |
	| aYbcXdabcXd                | true           |
	| abcdefghikjlmnopqustuvwxyz | false          |

