## In-Class Coding Exercise

### Background

In the given `Bird` class, we have identified a potential violation of the Liskov Substitution Principle (LSP). The `Fly` method is not applicable to all bird types, leading to issues in our current implementation.

### Task

Your task is to refactor the `Bird` class to adhere more closely to the Liskov Substitution Principle. To do this, you will rename the `Fly` method to a more generic name that can encompass a broader range of movements that a bird can perform.

### Instructions

1. Rename the `Fly` method to a more generic name, such as `Move`.
2. Adjust the message printed in the console to reflect this change. For instance, it might say, "This bird is moving." instead of "This bird is flying." Example message:
   ```csharp
   Console.WriteLine("This bird is moving.");
   ```
1. Update any other part of your code base that calls the `Fly` method, replacing it with your new method name.

### Expected Outcome

After making these changes, the `Bird` class should be more flexible, allowing for a variety of bird movements without violating the Liskov Substitution Principle. Make sure to update your main program to work with this refactored class properly.
