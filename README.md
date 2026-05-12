## C# Coding Assessment
Welcome to the C# coding assessment! This project contains two coding exercises designed to evaluate your problem-solving and C# programming skills. Your task is to implement the missing logic so that all provided test cases pass successfully.

## Prerequisites
.NET 8.0 SDK or higher

IDE (Recommended): Visual Studio or VS Code

## Project Structure
```text
dotnet-assessment/
├── CsAssessment/
│   ├── CsAssessment.csproj		# Provided project file
│   ├── ListNode.cs				# Provided class for Solution 2 (Do not modify)
│   ├── FindSubString.cs   		# TODO: Implement problem 1 here
│   └── MyListNodeImp.cs  		# TODO: Implement Problem 2 here
├── CsAssessmentTest/
│   ├── CsAssessmentTest.csproj	# Provided project file
│   ├── FindSubstringTest.cs	# Provided test class for problem 1 (Do not modify)
│   ├── MergeListsTest.cs   	# Provided test class for problem 2 (Do not modify)
│   └── MSTestSettings.cs  		# Default test settings (Do not modify)
└── CsAssessment.sln  			# Solution file for the assessment (Do not modify)
```

## The Exercises
1. ### Longest Substring Without Repeating Characters:
   
   Given a string s, find the length of the longest substring without duplicate characters.

```text
Example 1:
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.

Example 2:
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.

Example 3:
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

Constraints:
0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
```

   File: CsAssessment/FindSubString.cs

2. ### Merge Two Sorted Lists:

   You are given the heads of two sorted linked lists list1 and list2.

   Merge the two lists in a one sorted list.
```text
Example 1:

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]

Example 2:

Input: list1 = [], list2 = []
Output: []

Example 3:

Input: list1 = [], list2 = [0]
Output: [0]
```

   File: CsAssessment/MyListNodeImp.cs
   

## How to Build and Test
Option 1: Using Visual Studio
- Open the solution in Visual Studio
- Implement your solution for FindSubString.cs and MyListNodeImp.cs
- Open Test Explorer and run all tests to verify that all test cases pass

Option 2: Using the Command Line
- Open a terminal and navigate to the solution directory
- To run all tests:

```shell
dotnet run --project CsAssessmentTest
```