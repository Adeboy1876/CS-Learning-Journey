// See https://aka.ms/new-console-template for more information
// function to add 2 numbers

//int num_1, num_2, num_3;


/*Console.Write("Enter Number 1: ");
num_1 = int.Parse(Console.ReadLine());
Console.Write("Enter Number 2: ");
num_2 = int.Parse(Console.ReadLine());

int answer = addNumber(num_1, num_2);
Console.WriteLine($"Answer is {answer}");

Console.Write("Enter Number 3: ");
num_3 = int.Parse(Console.ReadLine());
int answer2 = addNumber(answer, num_3);
Console.WriteLine($"Answer 2 is {answer2}");

int addNumber(int a, int b)
{
    return a + b;
}


class Program
{
    static void Main()
    {
        int num1 = 10, num2 = 10;
        Console.WriteLine(Add(num1, num2));
        Console.WriteLine(Sub(num1, num2));
        Console.WriteLine(mult(num1, num2));
        Console.WriteLine(div(num1, num2) + "\n");

        double dNum1 = 10.02;
        double dNum2 = 11.731;

        Console.WriteLine(Add(dNum1, dNum2));
        Console.WriteLine(Sub(dNum1, dNum2));
        Console.WriteLine(mult(dNum1, dNum2));
        Console.WriteLine(div(dNum1, dNum2));
    }

    //Functions 
    //add
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static double Add(double a, double b)
    {
        return Math.Round(a + b, 3);
    }
    //Subtract
    public static int Sub(int a, int b)
    {
        return a - b;
    }
    public static double Sub(double a, double b)
    {
        return Math.Round(a - b, 3);
    }
    //Multiply
    public static int mult(int a, int b)
    {
        return a * b;
    }
    public static double mult(double a, double b)
    {
        return Math.Round(a * b, 3);
    }
    //Division
    public static int div(int a, int b)
    {
        return a / b;
    }
    public static double div(double a, double b)
    {
        return Math.Round(a / b, 3);
    }
}*/


class Program
{
    static void Main()
    {

        Console.WriteLine("Calculator for 2 numbers \nAccepted format is 'number 1' [space]  mathematical operator [space] 'number 2'\n\n"  );
        while (true)
        {

            Console.WriteLine("Enter Mathematical Expression: ");
            string? input = Console.ReadLine();





            if (input.Trim().ToLower() == "x" || input.Trim().ToUpper()=="X")
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break; // Exit the loop
            }

            string[] expression = input.Split(' ');



            if (expression.Length != 3)
            {
                Console.WriteLine("Enter correct format");
                return;
            }

            double num1 = 0, num2 = 0;

            if (!double.TryParse(expression[0], out num1) || !double.TryParse(expression[2], out num2))
            {
                Console.WriteLine("Enter a valid number");
            }

            //switch statement
            string symbol = expression[1];
            double result = 0;

            switch (symbol)
            {
                case "+":
                    result = add(num1, num2);
                    break;

                case "-":
                    result = sub(num1, num2);
                    break;
                case "*":
                    result = mult(num1, num2);
                    break;
                case "/":
                    result = div(num1, num2);
                    break;
                case "%":
                    result = mod(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;


            }
            Console.WriteLine("Result: " + result);
        }
    }

    //Functions
    //Add
    public static double add(double a, double b)
    {
        return a + b;
    }
    //Subtract
    public static double sub(double a, double b)
    {
        return a - b;
    }
    //Divide
    public static double div(double a, double b) 
    {
        if (b == 0)
        {
            return 0;
        }
        return (a / b);
    }
    //Multiply
    public static double mult(double a, double b) 
    {
        return (a * b);
    }
    //Modulus
    public static double mod(double a, double b)
    {
        return (a % b);
    }
}