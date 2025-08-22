# In-Class Assignment: Convert from Inheritance to Composition

## Objective

The goal of this assignment is to refactor a small program that initially uses inheritance to reuse code. You will switch it to use composition as a better practice for code reuse and maintainability.

## Given Code

Here is the initial code which uses inheritance:

```csharp

public class Book

{

    public void Read()

    {

        Console.WriteLine("Reading...");

    }

}

public class EBook : Book

{

    public void Download()

    {

        Console.WriteLine("Downloading...");

    }

}
```
### Redesign Using Composition

Redesign the code to use composition. In the new design, `EBook` should have a `Book` instance as a member variable, rather than inheriting from `Book`.


## Hints

- Think about how the `Read()` and `Download()` methods should be accessed in the new composition-based design.

- Remember that with composition, you can delegate method calls to the composed object.

