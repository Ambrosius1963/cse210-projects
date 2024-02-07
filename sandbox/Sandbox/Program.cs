Book jane_eyre = new Book("Jane Eyre","Jane Austen");

jane_eyre.Display();
jane_eyre.CheckOut();
jane_eyre.Display();
jane_eyre.CheckIn();
Console.WriteLine(jane_eyre.HasAuthor("Frank"));
jane_eyre.Display();

Bookcase bookcase = new Bookcase();
bookcase.AddBook(jane_eyre);
Book mistborn = new Book("Mistborn","Brandon Sanderson");
bookcase.AddBook(mistborn);

bookcase.ShowBooks();

bookcase.FindBookByAuthor("Brandon");

bookcase.CountBooks();

bookcase.ShowPopularBooks(3);

