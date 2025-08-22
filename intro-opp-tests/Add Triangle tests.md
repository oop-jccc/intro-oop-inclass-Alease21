# In-Class Assignment: Writing NUnit Tests for the Triangle Class

## Objective

The goal of this assignment is to practice writing NUnit tests by adding tests for the `Triangle` class. You will be given a starter project that contains tests for the `Circle` class as an example. Your task is to write your own tests for the `Triangle` class.

## Starter Code

You'll start with a test file that has the following skeleton:

```csharp

using intro_oop;

namespace intro_opp_tests

{

    internal class TriangleTests

    {

        // TODO: add tests for Triangle

    }

}

```

## Requirements

1\. Write a test that checks the area of a triangle with positive base and height.

2\. Write a test that checks the area of a triangle with a zero base or height.

3\. Write a test that checks the area of a triangle with negative base or height.

4\. (Optional) Write a test that checks the area of a triangle with non-integer base and height.

## Tips

- Look at the existing tests for the `Circle` class as an example.

- You can use the following syntax for floating-point comparisons:

```csharp

Assert.That(triangle.Area(), Is.EqualTo(expected).Within(1e-9));```

