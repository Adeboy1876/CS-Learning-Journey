/*
 * 
 * 
 * 
 * 
 * 
 * public class Vehicle
{
    public string Brand { get; set; }
    public Vehicle(string brand)
    {
        Brand = brand;
    }


    public virtual void Drive()
    {
        Console.WriteLine("Driving the vehicle");
    }

}



public class Car : Vehicle
{
    public Car(string brand) : base(brand) {}

    public override void Drive() 
    { 
        Console.WriteLine($"{Brand} car is driving");
    }

}

public class EV : Vehicle
{
    public EV(string brand) : base(brand) { }

    public override void Drive()
    {
        Console.WriteLine($"{Brand} electric vehicle is driving");
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle myCar = new Car("Toyota");
        Vehicle myEV = new EV("Tesla");

        myCar.Drive();
        myEV.Drive();
    }
}*/


//Group Activity
public class Vehicle
{
    public string Brand { get; set; }
    public decimal Consumption { get; set; }
    public Vehicle(string brand, decimal consumption)
    {
        Brand = brand;
        Consumption = consumption;

    }


    public virtual void Drive()
    {
        Console.WriteLine("Driving the vehicle");
    }

    public virtual void FuelConsumption()
    {
        Console.WriteLine("The Fuel Consumption is ");
    }

}



public class Car : Vehicle
{
    public Car(string brand, decimal consumption) : base(brand, consumption) { }

    public override void Drive()
    {
        Console.WriteLine($"{Brand} car is driving");
    }
    public override void FuelConsumption()
    {
        Console.WriteLine($"MPG for {Brand} is: {Consumption}");
    }


}

public class EV : Vehicle
{
    public EV(string brand, decimal consumption ) : base(brand, consumption) { }

    public override void Drive()
    {
        Console.WriteLine($"{Brand} electric vehicle is driving");
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle myCar = new Car("Toyota", 60);
        Vehicle myEV = new EV("Tesla", 0);

        myCar.Drive();
        myCar.FuelConsumption();
        myEV.Drive();
    }
}