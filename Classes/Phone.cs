namespace src;

internal class Phone
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string OperatingSystem { get; set; }
    public double ScreenSize { get; set; }
    public int Ram { get; set; }
    public int Storage { get; set; }
    public int BatteryCapacity { get; set; }
    public string ChargingSpeed { get; set; }
    public string CameraResolution { get; set; }
    public string Color { get; set; }


    public bool ChekRam(int ram)
    {
        return ram > 1 && ram % 2 == 0;
    }

    public bool ChekStorage(int storage)
    {
        return storage > 1 && storage % 2 == 0;
    }
}
