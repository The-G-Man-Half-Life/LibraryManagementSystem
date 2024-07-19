using LibraryManagementSystem.Models;



Library library = new Library();

// library.AddANewBook();



library.Books.Add(
    new Book(
                Title: "1984",
                PublicationTime: new DateTime(1949, 6, 8),
                Author: "George Orwell",
                ISBN: "9780451524935",
                Gender: "Dystopian",
                Price: 8.99,
                Description: "A novel about a dystopian future."
    )
);
library.ShowList();