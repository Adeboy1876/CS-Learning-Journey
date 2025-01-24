List<double> shoppingListprices = new List<double> { 34, 3, 5.50, 2.99, 8.49 };

double totalPrice = 0;

double mostExpensive = double.MinValue;
double cheapest = double.MaxValue;


foreach(double price in shoppingListprices)
{
    totalPrice += price;

    if(price > mostExpensive)
    {
        mostExpensive = price;
    }
    if(price < cheapest)
    {
        cheapest = price;
    }
}

Console.WriteLine($"Total Price: {totalPrice:C2}");
Console.WriteLine($"Most expensive item: {mostExpensive:C2}");
Console.WriteLine($"Cheapest item: {cheapest:C2}");