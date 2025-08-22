namespace intro_oop;

internal interface IEngine // could be an abstract class but someone might sneak in some implementation
{
    void Run();

    // If we had some concrete implementation here, we would revert back to the house of cards problem.
    // Keeping it as an interface allows us to keep building with legos without glue.
}