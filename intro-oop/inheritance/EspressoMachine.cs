namespace intro_oop.inheritance;

public class EspressoMachine : CoffeeMachine // Inheritance House of Cards
{
    public void MakeEspresso()
    {
        Console.WriteLine("Making espresso...");
    }

    public void SteamMilk()
    {
        Console.WriteLine("Steaming milk...");
    }
}