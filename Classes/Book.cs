namespace src;

internal class Book
{
    public string Genre { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationDate { get; set; }
    public int Page { get; set; }
    public int Part { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public string Language { get; set; }
    public string Country { get; set; }


    public bool PublishedDate(int year)
    {
        return year < 2025;
    }

    public bool PriceOfBook(int cost)
    {
        return cost > 0;  
    }

}
