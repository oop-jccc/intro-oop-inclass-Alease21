namespace intro_oop.composition;

public class EspressoMachine
{
    private readonly CoffeeMachine _coffeeMachine = new(); // Composition without polymorphism (Legos with glue)

    public void BrewCoffee()
    {
        _coffeeMachine.BrewCoffee();
    }

    public void MakeEspresso()
    {
        Console.WriteLine("Making espresso...");
    }

    public void SteamMilk()
    {
        Console.WriteLine("Steaming milk...");
    }
}