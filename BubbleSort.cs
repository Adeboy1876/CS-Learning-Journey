using System;

int[] numbers = {5, 3, 8, 4, 2, 43, 21, 6, 9, 18, 7};
int count = 0; 


//Bubble Sort
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers.Length - 1; j++)
    {
        //Console.WriteLine(numbers[i] - numbers[j]);
        if (numbers[j] > numbers[j + 1])
        {
            int temp = numbers[j];
            int temp1 = numbers[j + 1];

            //swap number

            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

foreach (int n in numbers)
{
    Console.WriteLine($"Numbers[{count}]: {n}");
    count ++;
}