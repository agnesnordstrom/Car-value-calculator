using System;

public class TicketSeller
{
    public TicketSeller()
    {
    }

    private string name = "Amy";
    private double price = 99;
    private int numOfAdults;
    private int numOfChildren;
    private double amountToPay;

    public void ReadTicketData()
    {
        Console.Write("Welcome! My name is " + name + "! ");

        Console.Write("How many adults are in your party today? ");
        numOfAdults = int.Parse(Console.ReadLine());

        Console.Write("How many children are in your party today? ");
        numOfChildren = int.Parse(Console.ReadLine());
    }

    public void CalculateAmount()
    {
        amountToPay = ((numOfAdults + numOfChildren) * price);
    }

    public void DisplayAmount()
    {
        Console.WriteLine("Great! That will be " + amountToPay + "kr, please!");
    }

    public void StartTicketSeller()
    {
        ReadTicketData();
        CalculateAmount();
        DisplayAmount();
        Console.ReadLine();
    }
}