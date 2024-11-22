namespace src;

internal class House
{
    public string Address { get; set; }
    public string City { get; set; }
    public int NumberOfRooms { get; set; }
    public int NumberOfBathRooms { get; set; }
    public int NumberOfKitchens { get; set; }
    public string GarageSize { get; set; }
    public int YearBuilt { get; set; }
    public bool HasGarden { get; set; }
    public bool IsSwimminPool { get; set; }
    public bool HasGym { get; set; }


    public bool CheckYear(int year)
    {
        return year < 2025;
    }

    public
}
