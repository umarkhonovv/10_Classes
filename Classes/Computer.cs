namespace src;

internal class Computer
{
    public string Brend { get; set; }
    public string Model { get; set; }
    public string Processor { get; set; }
    public int Ram { get; set; }
    public string StorageType { get; set; }
    public int StorageCapacity { get; set; }
    public double ScreenSize { get; set; }
    public string OperatingSystem { get; set; }
    public double BatteryLife { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }


    public bool CheckRam(int ram)
    {
        var result = false;
        if (ram > 0 && ram % 2 == 0)
        {
            result = true;
        }
        return result;
    }

    public bool CheckPrice(double price)
    {
        return price > 0;
    }
}
