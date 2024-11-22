namespace src;

internal class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public string Producer { get; set; }
    public int Cast { get; set; }
    public int ReleaseDate { get; set; }
    public string Language { get; set; }
    public string CountryOfOrigin { get; set; }
    public string Budget { get; set; }
    public string Writer { get; set; }


    public bool CheckCast(int cast)
    {
        return cast > 0;
    }

    public bool CheckDate(int date)
    {
        return date < 2025;
    }
}
