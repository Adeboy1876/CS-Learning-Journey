using System;


public class Person
{
    //properties

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int YearofBirth { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public string HairColour { get; set; }

    //Constructor to initialise a new person object
    public Person (string firstName, string lastName, int age, int yearofbirth, double height, double weight, string haircolour)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        YearofBirth = yearofbirth;
        Height = height;
        Weight = weight;
        HairColour = haircolour;
    }

    //Functions
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {FirstName} {LastName}, and i am {Age} years old.");
    }
    public void Introduce()
    {
        Console.WriteLine($"Nice to mee you! I'm {FirstName} {LastName}.");
    }
    public void Appearance()
    {
        Console.WriteLine($"I have {HairColour} hair, i weigh {Weight} KG and i am {Height} cm tall");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiation
        Person person1 = new Person("Ade", "O", 95, 1940, 195, 90, "Black");

        person1.Greet();
        person1.Introduce();
        person1.Appearance();
    }
}