namespace src;

internal class Game
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Platform { get; set; }
    public int ReleaseDate { get; set; }
    public double Price { get; set; }
    public double Size { get; set; }
    public string GameMode { get; set; }
    public int MinimumRam { get; set; }
    public string Country { get; set; }


    public bool CheckRam(int ram)
    {
        return ram > 1;
    }
    public bool CheckDate(int date)
    {
        return date < 2025;
    }
}
