using System;

class FindLargestNumber
{
    static void Main()
    {
        //numbers to search
        int[] numbers = { 10, 24, 52, 3, 78, 19, 44 };



        //call the method to pring the largest number
        int largest = findLargestNumber(numbers); 
        Console.WriteLine($"The largest number is: {largest}");
    }


   public static int findLargestNumber(int[] numbers)
    {
        // initialise the largest variable with the first element

        int largest = numbers[0];

        //loop through the rest
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
            //Console.WriteLine($"new largest is : {largest}"); //to show each step);
        }
        return largest;
    }
}