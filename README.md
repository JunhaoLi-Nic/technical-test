# Missing Number Finder

## Description
This C# console application finds the missing number in an array containing distinct numbers from the range 0 to n.

## Problem Statement
Given an array containing n distinct numbers taken from the range 0 to n, find the one number that is missing from the array.

## Input
- An array of integers `nums` where `nums` contains n distinct numbers from the range 0 to n.

## Output
- The application returns the missing number.

## Examples
Example 1:
- Input: [3, 0, 1]
- Output: 2

Example 2:
- Input: [9, 6, 4, 2, 3, 5, 7, 0, 1]
- Output: 8

## Implementation Details
This application is built using C# and follows SOLID principles:
- **S**ingle Responsibility Principle
- **O**pen/Closed Principle
- **L**iskov Substitution Principle
- **I**nterface Segregation Principle
- **D**ependency Inversion Principle

## How to Run
1. Clone the repository
2. Navigate to the project directory in your terminal/command prompt

### Using Visual Studio
- Open the solution in Visual Studio
- Build the solution (Ctrl+Shift+B)
- Run the application (F5 or Ctrl+F5)

### Using .NET CLI
- Build the application:
  ```
  dotnet build
  ```
- Run the application:
  ```
  dotnet run
  ```
- To run with specific arguments:
  ```
  dotnet run -- 3 0 1
  ``` 