using System;

public class Car
{
	public Car()
	{

	}

    public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
	{
		Year = year;
		Make = make;
		Model = model;
		IsDriveable = isDriveable;
		EngineNoise = engineNoise;
		HonkNoise = honkNoise;	
	}

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

	public static void MakeHonkNoise(string honkNoise)
	{
		Console.WriteLine(honkNoise);
	}

    public static void MakeEngineNoise(string engineNoise)
    {
        Console.WriteLine(engineNoise);
    }
}


//Create a seperate class file called Car
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property