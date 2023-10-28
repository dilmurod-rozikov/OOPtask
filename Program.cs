Book book = new Book("Clean Code");
book.author = "Robert Cecil Martin";
book.Price = 99.99m;

var book2 = new Book("C#");
book2.author = "Microsoft";
book2.Price = 519.99m;

Console.WriteLine("Total number of sold books: "+ book2.Sold);
Console.WriteLine(book.ToString());
Console.WriteLine(book2.ToString());

var book3 = new Book("History of science");
//book3.author = "Dilmurod";
Console.WriteLine("Total number of sold books: "+ book2.Sold);
Console.WriteLine(book3.ToString());



