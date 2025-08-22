# Creating a Robot Class

In this lab, we will be working on creating a new `INameable` object, the Robot. This assignment is designed to help you
understand and practice implementing interfaces in C#. Let's get started!

## Task

Your task is to create a new class named `Robot` that implements the `INameable` interface. The `Robot` class should
have a private string field that will hold the robot's name. The name of the robot will be passed to the `Robot` class
constructor when an instance is created. The `GetName()` method should return the name of the robot.

Here's a step-by-step breakdown:

1. In the `intro_oop` namespace, create a new class named `Robot`.
2. Make the `Robot` class implement the `INameable` interface.
3. Add a private readonly field of type string to hold the robot's name.
4. Create a constructor for the `Robot` class that takes a string parameter. This parameter will be the robot's name.
   Assign the parameter to the robot's name field.
5. Override the `GetName()` method in the `Robot` class to return the robot's name.

Once you've created the `Robot` class, it's time to add a `Robot` instance to the `Main` method in the `Program` class.

* Inside the `Main` method, create a new `Robot` object. Pass any string of your choice as the name of the robot.
* Add the new `Robot` object to the `names` array.
* Ensure that when you run the program, the name of your robot is printed to the console along with the names of the
  other `INameable` objects.
