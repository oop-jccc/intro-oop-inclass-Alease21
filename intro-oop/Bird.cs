namespace intro_oop;

// Does this class violate the Single Responsibility Principle (SRP)?
// Yes: It handles both flying behavior and egg-laying behavior, which are distinct responsibilities, giving it multiple reasons to change.
// No: It simply represents the basic behaviors of a bird, hence it is following a single responsibility of showcasing a bird's general actions.
public class Bird
{
    public virtual void Move()
    {
        Console.WriteLine("This bird is flying.");
    }

    public void LayEgg()
    {
        Console.WriteLine("This bird is laying an egg.");
    }
}