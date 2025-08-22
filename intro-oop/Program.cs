using intro_oop.inheritance;
//using intro_oop.composition;

namespace intro_oop;

internal static class Program
{
    private static void Main()
    {
        var myMachine = new EspressoMachine();
        myMachine.BrewCoffee();
        myMachine.MakeEspresso();
        myMachine.SteamMilk();
    }
}