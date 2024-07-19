using LibraryManagementSystem.Models;

var library = new Library();

Book book1 = new Book(
    Title: "1984",
    PublicationTime: new DateTime(1949, 6, 8),
    Author: "george orwell",
    ISBN: "9780451524935",
    Gender: "dystopian",
    Price: 8.99,
    Description: "a novel about a dystopian future."
);

Book book2 = new Book(
    Title: "brave new world",
    PublicationTime: new DateTime(1932, 1, 1),
    Author: "aldous huxley",
    ISBN: "9780060850524",
    Gender: "dystopian",
    Price: 9.99,
    Description: "a novel about a futuristic society."
);

Book book3 = new Book(
    Title: "the catcher in the rye",
    PublicationTime: new DateTime(1951, 7, 16),
    Author: "j.d. salinger",
    ISBN: "9780316769488",
    Gender: "coming-of-age",
    Price: 7.99,
    Description: "a novel about teenage angst."
);

Book book4 = new Book(
    Title: "to kill a mockingbird",
    PublicationTime: new DateTime(1960, 7, 11),
    Author: "harper lee",
    ISBN: "9780061120084",
    Gender: "southern gothic",
    Price: 10.49,
    Description: "a novel about racial injustice in the american south."
);

Book book5 = new Book(
    Title: "pride and prejudice",
    PublicationTime: new DateTime(1813, 1, 28),
    Author: "jane austen",
    ISBN: "9780141439518",
    Gender: "romance",
    Price: 6.99,
    Description: "a classic novel about love and society."
);

Book book6 = new Book(
    Title: "the great gatsby",
    PublicationTime: new DateTime(1925, 4, 10),
    Author: "f. scott fitzgerald",
    ISBN: "9780743273565",
    Gender: "modernist",
    Price: 8.49,
    Description: "a novel depicting the roaring twenties."
);

Book book7 = new Book(
    Title: "moby-dick",
    PublicationTime: new DateTime(1851, 10, 18),
    Author: "herman melville",
    ISBN: "9781853260087",
    Gender: "adventure",
    Price: 9.79,
    Description: "a tale of obsession and the sea."
);

Book book8 = new Book(
    Title: "the lord of the rings",
    PublicationTime: new DateTime(1954, 7, 29),
    Author: "j.r.r. tolkien",
    ISBN: "9780544003415",
    Gender: "fantasy",
    Price: 12.99,
    Description: "an epic high fantasy novel."
);

Book book9 = new Book(
    Title: "harry potter",
    PublicationTime: new DateTime(1997, 6, 26),
    Author: "j.k. rowling",
    ISBN: "9781408855652",
    Gender: "fantasy",
    Price: 11.99,
    Description: "the first book in the harry potter series."
);

Book book10 = new Book(
    Title: "crime and punishment",
    PublicationTime: new DateTime(1866, 11, 14),
    Author: "fyodor dostoevsky",
    ISBN: "9780140449136",
    Gender: "psychological fiction",
    Price: 7.49,
    Description: "a novel about morality, guilt, and redemption."
);

Book book11 = new Book(
    Title: "the hobbit",
    PublicationTime: new DateTime(1937, 9, 21),
    Author: "j.r.r. tolkien",
    ISBN: "9780547928227",
    Gender: "fantasy",
    Price: 8.99,
    Description: "a children's fantasy novel."
);

Book book12 = new Book(
    Title: "the adventures of huckleberry finn",
    PublicationTime: new DateTime(1884, 12, 10),
    Author: "mark twain",
    ISBN: "9780142437179",
    Gender: "adventure",
    Price: 6.79,
    Description: "a novel about friendship and freedom."
);

Book book13 = new Book(
    Title: "the road",
    PublicationTime: new DateTime(2006, 9, 26),
    Author: "cormac mccarthy",
    ISBN: "9780307387899",
    Gender: "post-apocalyptic",
    Price: 9.99,
    Description: "a novel about a father and son's journey "
);

Book book14 = new Book(
    Title: "the brothers karamazov",
    PublicationTime: new DateTime(1880, 11, 19),
    Author: "fyodor dostoevsky",
    ISBN: "9780374528379",
    Gender: "philosophical fiction",
    Price: 8.59,
    Description: "a philosophical novel about family and spirituality."
);

Book book15 = new Book(
    Title: "one hundred years of solitude",
    PublicationTime: new DateTime(1967, 5, 30),
    Author: "gabriel garcía márquez",
    ISBN: "9780060883287",
    Gender: "magic realism",
    Price: 10.99,
    Description: "a novel about the buendía family in macondo."
);

Book book16 = new Book(
    Title: "anna karenina",
    PublicationTime: new DateTime(1877, 12, 1),
    Author: "leo tolstoy",
    ISBN: "9780143035008",
    Gender: "realist novel",
    Price: 7.99,
    Description: "a novel about love, betrayal, and society."
);

Book book17 = new Book(
    Title: "war and peace",
    PublicationTime: new DateTime(1869, 1, 1),
    Author: "leo tolstoy",
    ISBN: "9780140447934",
    Gender: "historical fiction",
    Price: 11.49,
    Description: "a historical novel set during the napoleonic wars."
);

Book book18 = new Book(
    Title: "the grapes of wrath",
    PublicationTime: new DateTime(1939, 4, 14),
    Author: "john steinbeck",
    ISBN: "9780143039433",
    Gender: "social novel",
    Price: 9.29,
    Description: "a novel about the joad family's journey during the great depression."
);

Book book19 = new Book(
    Title: "don quixote",
    PublicationTime: new DateTime(1605, 1, 16),
    Author: "miguel de cervantes",
    ISBN: "9780142437230",
    Gender: "satire",
    Price: 8.39,
    Description: "a parody of chivalric romance."
);

Book book20 = new Book(
    Title: "the catcher in the rye",
    PublicationTime: new DateTime(1951, 7, 16),
    Author: "j.d. salinger",
    ISBN: "9780316769488",
    Gender: "coming-of-age",
    Price: 7.99,
    Description: "a novel about teenage angst."
);

Book book21 = new Book(
    Title: "the stranger",
    PublicationTime: new DateTime(1942, 5, 1),
    Author: "albert camus",
    ISBN: "9780679720201",
    Gender: "philosophical fiction",
    Price: 8.19,
    Description: "a novel about existentialism and the absurd."
);

Book book22 = new Book(
    Title: "slaughterhouse-five",
    PublicationTime: new DateTime(1969, 3, 31),
    Author: "kurt vonnegut",
    ISBN: "9780385333849",
    Gender: "science fiction",
    Price: 8.89,
    Description: "a novel about the bombing of dresden in wwii."
);

Book book23 = new Book(
    Title: "lolita",
    PublicationTime: new DateTime(1955, 9, 15),
    Author: "vladimir nabokov",
    ISBN: "9780679723165",
    Gender: "literary fiction",
    Price: 9.49,
    Description: "a novel about a controversial relationship."
);

Book book24 = new Book(
    Title: "jane eyre",
    PublicationTime: new DateTime(1847, 10, 16),
    Author: "charlotte brontë",
    ISBN: "9780141441146",
    Gender: "gothic fiction",
    Price: 6.59,
    Description: "a novel about a young orphan girl's journey."
);

Book book25 = new Book(
    Title: "frankenstein",
    PublicationTime: new DateTime(1818, 1, 1),
    Author: "mary shelley",
    ISBN: "9780141439471",
    Gender: "gothic science fiction",
    Price: 7.69,
    Description: "a novel about the consequences of scientific ambition."
);

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

library.ApplyDiscounts();

