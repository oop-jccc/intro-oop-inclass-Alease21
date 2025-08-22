# Intro to Object-Oriented Programming with C#

This codebase is designed as a starting point for understanding and learning object-oriented programming (OOP) in C#. It
introduces key OOP concepts and provides examples of various coding styles, highlighting the evolution of C# over time.

## Code Overview

- `Circle`: This class represents a circle with a specified radius. It includes a method to calculate the area of the
  circle, demonstrating the use of instance methods and encapsulation.

- `LocationJavaStyle`: This class represents a location with `x` and `y` coordinates, and uses traditional getter and
  setter methods similar to how it is done in languages like Java. This demonstrates the method of encapsulating data
  prior to the introduction of properties in C#.

- `LocationManualProps`: This class is similar to `LocationJavaStyle`, but uses C# properties to encapsulate the `x` and
  `y` data. This showcases the manual implementation of properties in earlier versions of C#.

- `Location`: This class is a further evolution of the above classes, using auto-implemented properties to encapsulate
  the `x` and `y` data. This is the current best practice for creating properties in C#.

- `Program`: This class contains the `Main` method, which is the entry point for the application. It creates instances
  of the `Circle` and `Location` classes, demonstrating object instantiation and method calling.