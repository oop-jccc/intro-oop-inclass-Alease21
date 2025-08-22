# Intro to Object-Oriented Programming with C#

This codebase provides an introduction to object-oriented programming (OOP) in C#. It serves as a starting point for learning key OOP concepts, including classes, objects, inheritance, polymorphism, interfaces, abstract classes, and records.

## Code Overview

- `Circle` and `Triangle`: These classes represent shapes with certain dimensions. They both inherit from the abstract `Shape` class and override the `Area` method to provide their own implementations. This demonstrates the use of classes, objects, and inheritance.

- `Shape`: This is an abstract class with an abstract `Area` method and a `Location` property. Any class that inherits from `Shape` must provide its own implementation of `Area`. Abstract classes like `Shape` are typically used when there's a default implementation to inherit, which might include default method implementations or fields.

- `Location`: This is a record type representing a location with `x` and `y` coordinates. It uses the `init` keyword to make properties read-only after initialization, showcasing the use of records and the `init` keyword introduced in C# 9.0.

- `INameable`: This is an interface that includes a `GetName` method. Any class that implements `INameable` must provide its own implementation of `GetName`. Interfaces like `INameable` are typically used when unrelated classes need to share common methods, allowing objects of unrelated classes to be processed polymorphically—objects of classes that implement the same interface can respond to the same method calls.

- `Dog`: This class implements the `INameable` interface and provides an implementation of the `GetName` method. This showcases how interfaces can be implemented in classes.

- `Program`: This class contains the `Main` method, which is the entry point for the application. It creates instances of the `Circle`, `Triangle`, and `Dog` classes and calls the `PrintArea` and `PrintName` methods, demonstrating object instantiation, method calling, and polymorphism.
