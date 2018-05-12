using System;
					
public class Program
{
	public static void Main()
	{
		Car blueCar = new Car("blue");
		Garage smallGarage = new Garage(2);
		
		smallGarage.ParkCar(blueCar, 0);
		Console.WriteLine(smallGarage.Cars);
	}
}

class Car
{
    public Car(string initialColor)
    {
    	Color = initialColor;
    }
    
    public string Color { get; private set; }
}

class Garage
{
    private Car[] cars;
    
    public Garage(int initialSize)
    {
    	Size = initialSize;
	    this.cars = new Car[initialSize];
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
				if (cars[i] != null) {
					Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
				}
			}
			return "That's all!";
		}
	}
}

