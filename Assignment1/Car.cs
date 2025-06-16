using System;

public class Car
{
    private const double yearlyValueDepreciation = 0.85; // The value of the car depreciates with 15% each year
    private int price;
    private double currentValue;
    private int age;
    private DateTime purchaseDate; // The date car was purchased

    public Car()
    {
    }

    public void ReadCarData()
    {
        Console.Write("Welcome to the car value calculator! Enter the date you bought the car (yyyy-MM-dd): ");
        purchaseDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter how much your car cost when you bought it: ");
        price = int.Parse(Console.ReadLine());

    }

    public void CalculateCarAge()
    {
        DateTime today = DateTime.Now; // Get current date
        age = today.Year - purchaseDate.Year; // Calculate age in years
        Console.WriteLine("Your car is " + age + " years old.");
    }

    public void CalculateCurrentValue()
    {
        double result = Math.Pow(yearlyValueDepreciation, age);
        currentValue = result * price;
        Console.WriteLine("Your car is valued at " + currentValue + " kronor.");
    }

    public void StartCar()
    {
        ReadCarData();
        CalculateCarAge();
        CalculateCurrentValue();
        Console.ReadLine();
    }
}
