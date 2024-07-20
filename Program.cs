using LibraryManagementSystem.Models;



var library = new Library();

// library.AddANewBook();

Book book1 = new Book(
    Title: "1984",
    PublicationTime: new DateTime(1949, 6, 8),
    Author: "George Orwell",
    ISBN: "9780451524935",
    Gender: "Dystopian",
    Price: 8.99,
    Description: "A novel about a dystopian future."
);

Book book2 = new Book(
    Title: "Brave New World",
    PublicationTime: new DateTime(1932, 1, 1),
    Author: "Aldous Huxley",
    ISBN: "9780060850524",
    Gender: "Dystopian",
    Price: 9.99,
    Description: "A novel about a futuristic society."
);

Book book3 = new Book(
    Title: "The Catcher in the Rye",
    PublicationTime: new DateTime(1951, 7, 16),
    Author: "J.D. Salinger",
    ISBN: "9780316769488",
    Gender: "Coming-of-age",
    Price: 7.99,
    Description: "A novel about teenage angst."
);

Book book4 = new Book(
    Title: "To Kill a Mockingbird",
    PublicationTime: new DateTime(1960, 7, 11),
    Author: "Harper Lee",
    ISBN: "9780061120084",
    Gender: "Southern Gothic",
    Price: 10.49,
    Description: "A novel about racial injustice in the American South."
);

Book book5 = new Book(
    Title: "Pride and Prejudice",
    PublicationTime: new DateTime(1813, 1, 28),
    Author: "Jane Austen",
    ISBN: "9780141439518",
    Gender: "Romance",
    Price: 6.99,
    Description: "A classic novel about love and society."
);

Book book6 = new Book(
    Title: "The Great Gatsby",
    PublicationTime: new DateTime(1925, 4, 10),
    Author: "F. Scott Fitzgerald",
    ISBN: "9780743273565",
    Gender: "Modernist",
    Price: 8.49,
    Description: "A novel depicting the roaring twenties."
);

Book book7 = new Book(
    Title: "Moby-Dick",
    PublicationTime: new DateTime(1851, 10, 18),
    Author: "Herman Melville",
    ISBN: "9781853260087",
    Gender: "Adventure",
    Price: 9.79,
    Description: "A tale of obsession and the sea."
);

Book book8 = new Book(
    Title: "The Lord of the Rings",
    PublicationTime: new DateTime(1954, 7, 29),
    Author: "J.R.R. Tolkien",
    ISBN: "9780544003415",
    Gender: "Fantasy",
    Price: 12.99,
    Description: "A epic high fantasy novel."
);

Book book9 = new Book(
    Title: "Harry Potter",
    PublicationTime: new DateTime(1997, 6, 26),
    Author: "J.K. Rowling",
    ISBN: "9781408855652",
    Gender: "Fantasy",
    Price: 11.99,
    Description: "The first book in the Harry Potter series."
);

Book book10 = new Book(
    Title: "Crime and Punishment",
    PublicationTime: new DateTime(1866, 11, 14),
    Author: "Fyodor Dostoevsky",
    ISBN: "9780140449136",
    Gender: "Psychological fiction",
    Price: 7.49,
    Description: "A novel about morality, guilt, and redemption."
);

Book book11 = new Book(
    Title: "The Hobbit",
    PublicationTime: new DateTime(1937, 9, 21),
    Author: "J.R.R. Tolkien",
    ISBN: "9780547928227",
    Gender: "Fantasy",
    Price: 8.99,
    Description: "A children's fantasy novel."
);

Book book12 = new Book(
    Title: "The Adventures of Huckleberry Finn",
    PublicationTime: new DateTime(1884, 12, 10),
    Author: "Mark Twain",
    ISBN: "9780142437179",
    Gender: "Adventure",
    Price: 6.79,
    Description: "A novel about friendship and freedom."
);

Book book13 = new Book(
    Title: "The Road",
    PublicationTime: new DateTime(2006, 9, 26),
    Author: "Cormac McCarthy",
    ISBN: "9780307387899",
    Gender: "Post-apocalyptic",
    Price: 9.99,
    Description: "A novel about a father and son's journey "
);

Book book14 = new Book(
    Title: "The Brothers Karamazov",
    PublicationTime: new DateTime(1880, 11, 19),
    Author: "Fyodor Dostoevsky",
    ISBN: "9780374528379",
    Gender: "Philosophical fiction",
    Price: 8.59,
    Description: "A philosophical novel about family and spirituality."
);

Book book15 = new Book(
    Title: "One Hundred Years of Solitude",
    PublicationTime: new DateTime(1967, 5, 30),
    Author: "Gabriel García Márquez",
    ISBN: "9780060883287",
    Gender: "Magic realism",
    Price: 10.99,
    Description: "A novel about the Buendía family in Macondo."
);

Book book16 = new Book(
    Title: "Anna Karenina",
    PublicationTime: new DateTime(1877, 12, 1),
    Author: "Leo Tolstoy",
    ISBN: "9780143035008",
    Gender: "Realist novel",
    Price: 7.99,
    Description: "A novel about love, betrayal, and society."
);

Book book17 = new Book(
    Title: "War and Peace",
    PublicationTime: new DateTime(1869, 1, 1),
    Author: "Leo Tolstoy",
    ISBN: "9780140447934",
    Gender: "Historical fiction",
    Price: 11.49,
    Description: "A historical novel set during the Napoleonic Wars."
);

Book book18 = new Book(
    Title: "The Grapes of Wrath",
    PublicationTime: new DateTime(1939, 4, 14),
    Author: "John Steinbeck",
    ISBN: "9780143039433",
    Gender: "Social novel",
    Price: 9.29,
    Description: "A novel about the Joad family's journey during the Great Depression."
);

Book book19 = new Book(
    Title: "Don Quixote",
    PublicationTime: new DateTime(1605, 1, 16),
    Author: "Miguel de Cervantes",
    ISBN: "9780142437230",
    Gender: "Satire",
    Price: 8.39,
    Description: "A parody of chivalric romance."
);

Book book20 = new Book(
    Title: "The Catcher in the Rye",
    PublicationTime: new DateTime(1951, 7, 16),
    Author: "J.D. Salinger",
    ISBN: "9780316769488",
    Gender: "Coming-of-age",
    Price: 7.99,
    Description: "A novel about teenage angst."
);

Book book21 = new Book(
    Title: "The Stranger",
    PublicationTime: new DateTime(1942, 5, 1),
    Author: "Albert Camus",
    ISBN: "9780679720201",
    Gender: "Philosophical fiction",
    Price: 8.19,
    Description: "A novel about existentialism and the absurd."
);

Book book22 = new Book(
    Title: "Slaughterhouse-Five",
    PublicationTime: new DateTime(1969, 3, 31),
    Author: "Kurt Vonnegut",
    ISBN: "9780385333849",
    Gender: "Science fiction",
    Price: 8.89,
    Description: "A novel about the bombing of Dresden in WWII."
);

Book book23 = new Book(
    Title: "Lolita",
    PublicationTime: new DateTime(1955, 9, 15),
    Author: "Vladimir Nabokov",
    ISBN: "9780679723165",
    Gender: "Literary fiction",
    Price: 9.49,
    Description: "A novel about a controversial relationship."
);

Book book24 = new Book(
    Title: "Jane Eyre",
    PublicationTime: new DateTime(1847, 10, 16),
    Author: "Charlotte Brontë",
    ISBN: "9780141441146",
    Gender: "Gothic fiction",
    Price: 6.59,
    Description: "A novel about a young orphan girl's journey."
);

Book book25 = new Book(
    Title: "Frankenstein",
    PublicationTime: new DateTime(1818, 1, 1),
    Author: "Mary Shelley",
    ISBN: "9780141439471",
    Gender: "Gothic science fiction",
    Price: 7.69,
    Description: "A novel about the consequences of scientific ambition."
);
;

library.Books.Add(book1);
library.Books.Add(book2);
library.Books.Add(book3);
library.Books.Add(book4);
library.Books.Add(book5);
library.Books.Add(book6);
library.Books.Add(book7);
library.Books.Add(book8);
library.Books.Add(book9);
library.Books.Add(book10);
library.Books.Add(book11);
library.Books.Add(book12);
library.Books.Add(book13);
library.Books.Add(book14);
library.Books.Add(book15);
library.Books.Add(book16);
library.Books.Add(book17);
library.Books.Add(book18);
library.Books.Add(book19);
library.Books.Add(book20);
library.Books.Add(book21);
library.Books.Add(book22);
library.Books.Add(book23);
library.Books.Add(book24);
library.Books.Add(book25);

library.ShowList();