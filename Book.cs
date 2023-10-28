public class Book
{
    public string title;
    public string author;
    private decimal price;
    private static int sold = 0;
    public Book(string title)
    {
        this.title = title;
        sold++;
    }
    public decimal Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }
    public int Sold
    {
        get
        {
            return sold;
        }
    }
    public void GenerateIsbnNo()
    {
        Random random = new Random();
        int a = 13;
        string ans = "";
        while(a-- > 0)
        {
            ans += random.Next(0, 10);
        }
    }
    public override string ToString()
    {
        return title + " by " + author + "(" + price + "$)"
            + "\nISBN number: " + GenerateIsbnNo();
    }
}