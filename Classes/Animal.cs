namespace src;

internal class Animal
{
    public string Species { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public double Weight { get; set; }
    public int Lifespan { get; set; }
    public int Legs { get; set; }
    public string Color { get; set; }
    public int NumberOfOffspring { get; set; }
    public bool Wings { get; set; }
    public string Diet { get; set; }
    public bool Horns { get; set; }


    public bool AmountOfLegs(int legs)
    {
        return (legs > 1000);
    }

    public bool LifeExpectanc(int lifeSpan)
    {
        return (lifeSpan <= 200);
    }




}
