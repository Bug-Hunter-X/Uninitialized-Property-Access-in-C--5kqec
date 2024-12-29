# Uninitialized Property Access in C# 
This example demonstrates a subtle bug in C# related to accessing a property before it has been assigned a value. While not always resulting in an immediate exception, this can lead to unexpected behavior, program crashes, or incorrect results.

## The Bug
The `ExampleClass` contains a property `MyProperty` of type `int`. In `MyMethod`, we attempt to use `MyProperty` in a calculation *before* it's been assigned a value. In this scenario, `MyProperty` will have its default value (0 for `int`), which might not be apparent in all cases.

## The Problem
The issue isn't immediately obvious because C# doesn't explicitly throw an exception for accessing an uninitialized property. However, this can cause significant problems if the uninitialized property's value is critical to the program's logic. In this instance, it might not be obvious where the mistake occurred if the default value of 0 gives unexpected results.

## Reproducing the bug
1. Create a C# project
2. Copy and paste the code from `bug.cs` into your project.
3. Run the code and observe the result (output will be 0).

## The Solution
The solution is to initialize `MyProperty` with a default value or ensure it's assigned a value before being used.
