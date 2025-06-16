using System;

public class Pet
{
	private string name;
	private int age;
	private bool isFemale;

    public Pet()
	{
	}

	public void ReadPetData()
	{
		Console.Write("Enter name of pet: ");
		name = Console.ReadLine();

		Console.Write("Enter age of " + name + ": ");
		age = int.Parse(Console.ReadLine());

        Console.Write("Is the pet female? (yes/no): ");
        string genderInput = Console.ReadLine().ToLower();
		isFemale = (genderInput == "yes");

    }

	public void DisplayPetData()
	{
        Console.WriteLine("----------------------");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " +  age);
        Console.WriteLine("Gender: " + (isFemale ? "Female" : "Male"));
        Console.WriteLine( name + " is a " + age + " yr old good " + (isFemale ? "girl!" : "boy!"));
        Console.WriteLine("----------------------");
    }


	public void StartPet()
	{
		ReadPetData();
		DisplayPetData();
        Console.ReadLine();
    }

}
