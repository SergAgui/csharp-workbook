using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Car blueCar = new Car("blue", 2);
		Car redCar = new Car("red", 2);
		Person guy = new Person("Guy", "Fieri");
		Person girl = new Person("Girl", "Chan");
		Garage smallGarage = new Garage(2);

		smallGarage.ParkCar(blueCar, 0);
		smallGarage.ParkCar(redCar, 1);
		blueCar.EnterCar(girl, 0);
		redCar.EnterCar(guy, 0);
		Console.WriteLine("What  would you like to do?");
		Console.WriteLine("To see which spot a car is parked in and who is in which car, say 'Garage'");
		Console.WriteLine("To move a Person to another Car, say 'Move Girl' or 'Move Guy'");
		Console.WriteLine("Or say 'DONE' when you're finnished");
		//'hello' below is for debugging
		//Console.WriteLine("hello!");

		do
		{
			string read = Console.ReadLine().ToLower();
			switch (read)
			{
				case "garage":
					Console.WriteLine("The " + Garage.cars[0].Color + " car is in spot 1");
					if (blueCar.passengers[0] == null && blueCar.passengers[1] == null)
					{
						Console.WriteLine(redCar.passengers[0].FullName + " and");
						Console.WriteLine(redCar.passengers[1].FullName + " are both in the red car");
						Console.WriteLine("But no one is in the blue car.");
					}
					else if (blueCar.passengers[0] != null && blueCar.passengers[1] == null)
					{
						Console.WriteLine(blueCar.passengers[0].FullName + " is in the drivers seat.");	
					}
					else if (blueCar.passengers[0] == null && blueCar.passengers[1] != null)
					{
						Console.WriteLine(blueCar.passengers[1].FullName + " is in the passengers seat.");	
					}

					Console.WriteLine("The " + Garage.cars[1].Color + " car is in spot 2");
					if (redCar.passengers[0] == null && redCar.passengers[1] == null)
					{
						Console.WriteLine(blueCar.passengers[0].FullName + " and");
						Console.WriteLine(blueCar.passengers[1].FullName + " are both in the blue car");
						Console.WriteLine("But no one is in the red car.");
					}
					else if (redCar.passengers[0] != null && redCar.passengers[1] == null)
					{
						Console.WriteLine(redCar.passengers[0].FullName + " is in the drivers seat.");	
					}
					else if (redCar.passengers[0] == null && redCar.passengers[1] != null)
					{
						Console.WriteLine(redCar.passengers[1].FullName + " is in the passengers seat.");	
					}
					continue;
				case "move girl":
					if (Array.Exists(blueCar.passengers, element => element == girl))
					{
						// if girl Exists in blueCar, then ExitCar
						blueCar.ExitCar(null, (Array.IndexOf(blueCar.passengers, girl)));
						// Find a null in the redCar and EnterCar
						redCar.EnterCar(girl, Array.IndexOf(redCar.passengers, null));
						Console.WriteLine("Girl Chan is now in seat " +
						Array.IndexOf(redCar.passengers, girl) + " of the red car!");
					}
					else if (Array.Exists(redCar.passengers, element => element == girl))
					{
						// if girl Exists in blueCar, then ExitCar
						redCar.ExitCar(null, (Array.IndexOf(redCar.passengers, girl)));
						// Find a null in the redCar and EnterCar
						blueCar.EnterCar(girl, Array.IndexOf(blueCar.passengers, null));
						Console.WriteLine("Girl Chan is now in seat " +
						Array.IndexOf(blueCar.passengers, girl) + " of the blue car!");
					}					
					continue;

				case "move guy":
					if (Array.Exists(blueCar.passengers, element => element == guy))
					{
						// if guy Exists in blueCar, then ExitCar
						blueCar.ExitCar(null, (Array.IndexOf(blueCar.passengers, guy)));
						// Find a null in the redCar and EnterCar
						redCar.EnterCar(guy, Array.IndexOf(redCar.passengers, null));
						Console.WriteLine("Guy Fieri is now in seat " +
						Array.IndexOf(redCar.passengers, guy) + " of the red car!");
					}
					else if (Array.Exists(redCar.passengers, element => element == guy))
					{
						// if guy Exists in blueCar, then ExitCar
						redCar.ExitCar(null, (Array.IndexOf(redCar.passengers, guy)));
						// Find a null in the redCar and EnterCar
						blueCar.EnterCar(guy, Array.IndexOf(blueCar.passengers, null));
						Console.WriteLine("Guy Fieri is now in seat " +
						Array.IndexOf(blueCar.passengers, guy) + " of the blue car!");
					}
					continue;

				default:
					Console.WriteLine("If you meant 'Done', please say 'Done' again.");
					Console.WriteLine("Or a try a differnt command.");
					continue;
			}
		}
		while (Console.ReadLine().ToLower() != "done");
	}
}

class Person
{
	private string firstName;
	private string lastName;
	public Person(string firstName, string lastName)
	{
		this.firstName = firstName;
		this.lastName = lastName;
	}
	public string FullName
	{
		get
		{
			return this.firstName + " " + this.lastName;
		}
		set
		{
			string[] names = value.Split(' ');
			this.firstName = names[0];
			this.lastName = names[1];
		}
	}
}

class Car
{
	public Person[] passengers;
    public Car(string initialColor, int size)
    {
    	Color = initialColor;
		passengers = new Person[size];
    }
    public void EnterCar(Person person, int seat)
	{
		passengers[seat] = person;
	}
    public void ExitCar(Person person, int seat)
	{
		passengers[seat] = null;
	}
	
    public string Color { get; private set; }

	public string Position 
	{
		get
		{
			for (int j = 0; j < passengers.Length; j++)
			{
				if (passengers[j] != null)
				{
					Console.WriteLine(String.Format("{0} is in seat {1}.", passengers[j].FullName, j));
				}
			}
			return "";
		}
	}

}

class Garage
{
    public static Car[] cars;
    
    public Garage(int initialSize)
    {
    	Size = initialSize;
	    cars = new Car[initialSize];
    }
    
    public int Size { get; private set; }
    
    public void ParkCar (Car car, int spot)
    {
        cars[spot] = car;
    }
    
    public string Cars {
		get {
			for (int i = 0; i < cars.Length; i++)
			{
				if (cars[i] != null)
				{
					Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
				}
			}
			return "";
		}
	}
}