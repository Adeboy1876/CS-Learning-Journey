using System;

class MakeTea
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Let's make a cup of tea");


        Boilwater();
        /*AddTeaBag();
        PourWater();
        BrewTea();
        AddMilkandSugar();
        StirTea();
        ServeTea();*/


        Console.WriteLine("Enjoy your tea");
    }
    static void Boilwater()
    {
        int count = 1 ;
        Console.WriteLine("Step 1: Boiling water...");

        while (count <= 10)
        {
            System.Threading.Thread.Sleep(1000); // 1 second pause
            Console.Write(count);
            count++;
        }
        Console.WriteLine("\n Water has boiled");
    }
}