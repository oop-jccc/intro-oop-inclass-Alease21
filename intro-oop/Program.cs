namespace intro_oop;

public static class Program
{
    public static void Main()
    {
        var birds = new List<Bird>
        {
            new Sparrow(),
            new Eagle(),
            new Penguin(),
        };

        PerformBirdActions(birds);
    }

    // This method adheres to the Open/Closed Principle (OCP). It is closed for modification 
    // because adding new functionalities in the Bird class or any subclasses does not require 
    // changing this method. Moreover, it is open for extension as you can introduce new Bird 
    // subclasses with different implementations of the Fly() and LayEgg() methods, and this 
    // method will still work with those new classes without any modification.
    private static void PerformBirdActions(List<Bird> birds)
    {
        foreach (var bird in birds)
        {
            bird.Fly();
            bird.LayEgg();
        }
    }
}