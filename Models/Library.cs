using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Numerics;
using System.Security;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models;

public class Library
{
    public List<Book> Books;


    public Library()
    {
        Books = new List<Book>();
    }

    //verifications
    private bool CanItbeADate(string? Date)
    {
        DateTime DateOfficial;
        var CanItTurnInADate = DateTime.TryParse(Date, out DateOfficial);
        if (CanItTurnInADate == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private bool isInrange(double num1, double num2, double num3)
    {
        if (num3 < num1 || num3 > num2)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    private bool isDouble(string? Number)
    {
        double number;
        bool doubleAble = double.TryParse(Number, out number);
        return doubleAble;
    }
    public bool verifyExistence(string? book)
    {
        bool coincidences = Books.Any(book1 => book1.Title == book);
        return coincidences;
    }

    //secondary functions in general
    private double ChooseOrder()
    {
        Console.Write(
@"1.Ascendant
2.Descendant

Choose the order you want to see your results:");
        string? number = Console.ReadLine();

        if (isDouble(number) == true && isInrange(1, 2, Convert.ToDouble(number)))
        {
            return Convert.ToDouble(number);
        }
        else if (isDouble(number) == false || string.IsNullOrWhiteSpace(number) == true)
        {
            Console.WriteLine("The value written down is not a number");
            return 0;
        }
        else
        {
            Console.WriteLine("You must write a number in the range");
            return 0;
        }
    }
    private void betterForEachStructure(List<Book> books)
    {
        Console.WriteLine(@"_______________________________________________________________________________________________________________________________________________________________________________________________________________________
|                  Title                 |    R.Date    |          Author            |         ISBN          |         Gender         | Price  |                               Description                             |
|________________________________________|______________|____________________________|_______________________|________________________|________|_______________________________________________________________________|");

        foreach (var book in books)
        {
            Console.WriteLine(@$"|  {book.Title,-38}|  {book.PublicationTime.ToString("yyyy/MM/dd"),-12}|  {book.Author,-26}|  {book.ISBN,-21}|  {book.Gender,-22}|  {book.Price,-6}|  {book.Description,-69}|");
        }

        Console.WriteLine(@"|________________________________________|______________|____________________________|_______________________|________________________|________|_______________________________________________________________________|");
    }

    
    //secondary funcstions of showlist
    private void ShowReleaseDateByAscendant()
    {
        var listReleaseDateAscendant = Books.OrderBy(book => book.PublicationTime).ToList();
        betterForEachStructure(listReleaseDateAscendant);
    }
    private void ShowReleaseDateByDescendant()
    {
        var listReleaseDateDescendant = Books.OrderByDescending(book => book.PublicationTime).ToList();
        betterForEachStructure(listReleaseDateDescendant);
    }
    private void ShowTitleByAscendant()
    {
        var listTitleAscendant = Books.OrderBy(book => book.Title).ToList();
        betterForEachStructure(listTitleAscendant);
    }
    private void ShowTitleByDescendant()
    {
        var listTitleDescendant = Books.OrderByDescending(book => book.Title).ToList();
        betterForEachStructure(listTitleDescendant);
    }
    private void ShowAuthorByAscendant()
    {
        var listAuthorAscendant = Books.OrderBy(book => book.Author).ToList();
        betterForEachStructure(listAuthorAscendant);
    }
    private void ShowAuthorByDescendant()
    {
        var listAuthorDescendant = Books.OrderByDescending(book => book.Author).ToList();
        betterForEachStructure(listAuthorDescendant);
    }
    private void ShowPriceByAscendant()
    {
        var listPriceAscendant = Books.OrderBy(book => book.Price).ToList();

        betterForEachStructure(listPriceAscendant);
    }
    private void ShowPriceByDescendant()
    {
        var listPriceDescendant = Books.OrderByDescending(book => book.Price).ToList();
        betterForEachStructure(listPriceDescendant);
    }

    //secondary functions of search
    private void SearchByTitle()
    {
        Console.Write("Enter the name of the book you are looking for: ");
        string? book = Console.ReadLine().ToLower();
        var foundBook = Books.Where(book1 => book1.Title == book).Take(1).ToList();

        if (foundBook.Count() >= 1)
        {
            Console.WriteLine("This is the book you are looking for: ");
            betterForEachStructure(foundBook);
        }
        else
        {
            Console.WriteLine("The book you are looking for is not in the database");
        }

    }
    private void SearchByAuthor()
    {
        Console.Write("Enter the name of the Author you are looking for: ");
        string? author = Console.ReadLine().ToLower();
        bool authorExistence = Books.Any(book => book.Author == author);
        double order = ChooseOrder();

        if (order == 1 && authorExistence == true)
        {
            var foundBook = Books.Where(book1 => book1.Author == author).OrderBy(book => book.Title).ToList();
            Console.WriteLine($"These are all the books that were written by: {author}");
            betterForEachStructure(foundBook);
        }
        else if (order == 2 && authorExistence == true)
        {
            var foundBook = Books.Where(book1 => book1.Author == author).OrderByDescending(book => book.Title).ToList();
            Console.WriteLine($"These are all the books that were written by: {author}");
            betterForEachStructure(foundBook);
        }
        else if (authorExistence == false)
        {
            Console.WriteLine("The author does not exist");
        }
    }
    private void SearchByPrice()
    {
        Console.Write("Enter the minimum price");
        string? minimumPrice = Console.ReadLine();
        bool verificationMinimumPrice = isDouble(minimumPrice);

        Console.Write("Enter the maximum price");
        string? maximumPrice = Console.ReadLine();
        bool verificationMaximumPrice = isDouble(maximumPrice);

        if (verificationMaximumPrice == false || verificationMinimumPrice == false)
        {
            Console.WriteLine("You must write a valid number");
        }
        else
        {
            double minimumPriceD = Convert.ToDouble(minimumPrice);
            double maximumPriceD = Convert.ToDouble(maximumPrice);
            double order = ChooseOrder();

            if (order == 1)
            {
                var booksInPriceRange = Books.Where(book => book.Price >= minimumPriceD && book.Price <= maximumPriceD).OrderBy(book => book.Price).ToList();
                Console.WriteLine($"These are all the books in the range of {minimumPriceD}$ and {maximumPriceD}$");
                betterForEachStructure(booksInPriceRange);
            }
            else if (order == 2)
            {
                var booksInPriceRangeDescending = Books.Where(book => book.Price >= minimumPriceD && book.Price <= maximumPriceD).OrderByDescending(book => book.Price).ToList();
                Console.WriteLine($"These are all the books in the range of {minimumPriceD}$ and {maximumPriceD}$");
                betterForEachStructure(booksInPriceRangeDescending);
            }
        }
    }
    private void SearchByTimeLapse()
    {
        Console.Write("Enter the Starting date (YYYY/MM/DD): ");
        string? startingDate = Console.ReadLine();
        bool verificationStartingDate = CanItbeADate(startingDate);

        Console.Write("Enter the finishing date (YYYY/MM//DD): ");
        string? finishingDate = Console.ReadLine();
        bool verificationFinishingDate = CanItbeADate(finishingDate);

        if (verificationStartingDate == false || verificationFinishingDate == false)
        {
            Console.WriteLine("You must write a valid number");
        }
        else
        {
            DateTime startingDateD = Convert.ToDateTime(startingDate);
            DateTime finishingDateD = Convert.ToDateTime(finishingDate);
            double order = ChooseOrder();

            if (order == 1)
            {
                var booksInDateRange = Books.Where(book => book.PublicationTime >= startingDateD && book.PublicationTime <= finishingDateD).OrderBy(book => book.PublicationTime).ToList();
                Console.WriteLine($"These are all the books in the range of {startingDateD.ToString("yyyy/MM/dd")} and {finishingDateD.ToString("yyyy/MM/dd")}");
                betterForEachStructure(booksInDateRange);
            }
            else if (order == 2)
            {
                var booksInDateRangeDescending = Books.Where(book => book.PublicationTime >= startingDateD && book.PublicationTime <= finishingDateD).OrderByDescending(book => book.PublicationTime).ToList();
                Console.WriteLine($"These are all the books in the range of {startingDateD.ToString("yyyy/MM/dd")} and {finishingDateD.ToString("yyyy/MM/dd")}");
                betterForEachStructure(booksInDateRangeDescending);
            }
        }

    }
    private void SearchByGender()
    {
        Console.Write("Enter the name of the Gender you are looking for: ");
        string? Gender = Console.ReadLine().ToLower();
        bool genderExistence = Books.Any(book => book.Gender.Contains(Gender));
        double order = ChooseOrder();

        if (order == 1 && genderExistence == true)
        {
            var foundBook = Books.Where(book1 => book1.Gender.Contains(Gender)).OrderBy(book => book.Gender).ToList();
            Console.WriteLine($"These are all the books with this: {Gender}");
            betterForEachStructure(foundBook);
        }
        else if (order == 2 && genderExistence == true)
        {
            var foundBook = Books.Where(book1 => book1.Gender.Contains(Gender)).OrderByDescending(book => book.Gender).ToList();
            Console.WriteLine($"These are all the books with this: {Gender}");
            betterForEachStructure(foundBook);
        }
        else if (genderExistence == false)
        {
            Console.WriteLine("The genre does not exist in the database");
        }

    }
    private void SearchByISBN()
    {
        Console.Write("Enter the ISBN of the book you are looking for: ");
        string? ISBN = Console.ReadLine().ToLower();
        var foundBook = Books.Where(book1 => book1.ISBN == ISBN).Take(1).ToList();

        if (foundBook.Count() >= 1)
        {
            Console.WriteLine("This is the book you are looking for: ");
            betterForEachStructure(foundBook);
        }
        else
        {
            Console.WriteLine("The book you are looking for is not in the database");
        }
    }
    
    //main functions
    public void AddANewBook()
    {
        Console.Write("Write down the Title of the book: ");
        string? Title = Console.ReadLine();
        bool verificationTitle = string.IsNullOrWhiteSpace(Title);

        Console.Write("Write down the publication Date of the book (YYYY/MM/DD): ");
        string? Date = Console.ReadLine();
        bool verificationDate = CanItbeADate(Date);

        Console.Write("Write down The Name of the author: ");
        string? Author = Console.ReadLine();
        bool verificationAuthor = string.IsNullOrWhiteSpace(Author);

        Console.Write("Write Down the ISBN of the book: ");
        string? ISBN = Console.ReadLine();
        bool verificationISBN = string.IsNullOrWhiteSpace(ISBN);

        Console.Write("Write Down the Gender of the book: ");
        string? Gender = Console.ReadLine();
        bool verificationGender = string.IsNullOrWhiteSpace(Gender);

        Console.Write("Write Down the Price of the book: ");
        string? Price = Console.ReadLine();
        bool verificationPrice = isDouble(Price);

        Console.Write("Write Down the description of the book: ");
        string? Description = Console.ReadLine();
        bool verificationDescription = string.IsNullOrWhiteSpace(Description);

        if (verificationTitle == true || verificationDate == false || verificationAuthor == true || verificationISBN == true || verificationGender == true || verificationPrice == false || verificationDescription == true)
        {
            Console.WriteLine("One of the signed values is uncorrect");
        }
        else
        {
            DateTime DateNew = Convert.ToDateTime(Date);
            double PriceNew = Convert.ToDouble(Price);

            Books.Add(new Book(Title, DateNew, Author, ISBN, Gender, PriceNew, Description));
            Console.WriteLine("The book was added successfully");
        }

    }

    public void ShowBooks()
    {

        Console.WriteLine(
@"1.Release date
2.Title
3.Author
4.Price
");

        Console.Write("Insert the number of your option: ");
        string? option = Console.ReadLine();
        bool optionVerification = isDouble(option);

        double option2=ChooseOrder();

        if (optionVerification == false )
        {
            Console.WriteLine("You must write a valid number");
        }
        else
        {
            double optionD = Convert.ToDouble(option);
            if ((optionD < 1 || optionD > 4) || (option2 < 1 || option2 > 2))
            {
                Console.WriteLine("Your choices must be in range of the options");
            }
            else
            {
                switch (optionD)
                {
                    case (1):
                        {
                            switch (option2)
                            {
                                case (1):
                                    {
                                        ShowReleaseDateByAscendant();
                                        break;
                                    }
                                case (2):
                                    {
                                        ShowReleaseDateByDescendant();
                                        break;
                                    }
                            }
                            break;
                        }
                    case (2):
                        {
                            switch (option2)
                            {
                                case (1):
                                    {
                                        ShowTitleByAscendant();
                                        break;

                                    }
                                case (2):
                                    {
                                        ShowTitleByDescendant();
                                        break;
                                    }
                            }
                            break;
                        }
                    case (3):
                        {
                            switch (option2)
                            {
                                case (1):
                                    {
                                        ShowAuthorByAscendant();
                                        break;
                                    }
                                case (2):
                                    {
                                        ShowAuthorByDescendant();
                                        break;
                                    }
                            }
                            break;
                        }
                    case (4):
                        {
                            switch (option2)
                            {
                                case (1):
                                    {
                                        ShowPriceByAscendant();
                                        break;
                                    }
                                case (2):
                                    {
                                        ShowPriceByDescendant();
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }
        }
    }

    public void VerifyIfABookIsRecent()
    {
        Console.Write("Write down the name of the book: ");
        string? book = Console.ReadLine().ToLower();
        bool coincidences = verifyExistence(book);


        if (string.IsNullOrWhiteSpace(book))
        {
            Console.WriteLine("Please write a value");
        }
        else if (coincidences == false)
        {
            Console.WriteLine("The book that you are trying to look for is not in our database");
        }
        else
        {
            var FoundBook = Books.FirstOrDefault(book1 => book1.Title == book);
            int Difference = DateTime.Now.Year - FoundBook.PublicationTime.Year;
            bool isRecent = DateTime.Now.Year - FoundBook.PublicationTime.Year <= 5;

            if (isRecent == false)
            {
                Console.WriteLine($"{book} is not recent because it has {Difference} years of difference");
            }
            else
            {
                Console.WriteLine($"{book} is recent because it has {Difference} years of difference");
            }
        }
    }

    public void ShoWDescription()
    {
        Console.Write("Enter the name of the book");
        string? book = Console.ReadLine();
        bool coincidences = verifyExistence(book);

        if (string.IsNullOrWhiteSpace(book))
        {
            Console.WriteLine("Write a proper value");
        }
        else if (coincidences == false)
        {
            Console.WriteLine("The book you are looking for is not in our database");
        }
        else
        {
            var neededBook = Books.FirstOrDefault(book1 => book1.Title == book);
            Console.WriteLine(@$"
Name:{book}
Description: {neededBook.Description}
            ");
        }
    }

    public void ApplyDiscounts()
    {
        Console.WriteLine("Enter the name of your book: ");
        string? book = Console.ReadLine();
        bool verification = verifyExistence(book);

        if (string.IsNullOrWhiteSpace(book))
        {
            Console.WriteLine("You must write a proper value");
        }
        else if (verification == false)
        {
            Console.WriteLine("The book you are looking for is not in our database");
        }
        else
        {
            Console.WriteLine("Enter only the value of the discount: ");
            string? discount = Console.ReadLine();
            bool verifyElement = isDouble(discount);

            if (verifyElement == false)
            {
                Console.WriteLine("You must write a proper value");
            }
            else
            {
                double discountD = Convert.ToDouble(discount);
                int bookFound = Books.FindIndex(book1 => book1.Title == book);
                Double totalValue = (Books[bookFound].Price) - (Books[bookFound].Price * (discountD / 100));

                Console.WriteLine(@$"
Name: {book}
Original value: {Books[bookFound].Price}$
Discount Value: {discountD}%
Total Value: {totalValue}$
");
                Books[bookFound].Price = totalValue;

            }
        }
    }

    public void DeleteBook()
    {
        Console.Write("Enter the name of the book that you wish to erase: ");
        string? book = Console.ReadLine().ToLower();
        bool verification = verifyExistence(book);

        if (verification == false)
        {
            Console.WriteLine("The book does not exist in our database");
        }
        else if (string.IsNullOrWhiteSpace(book))
        {
            Console.WriteLine("You must write a proper value");
        }
        else
        {
            int bookId = Books.FindIndex(book1 => book1.Title == book);
            Books.RemoveAt(bookId);
            Console.WriteLine("The book has been erased succesfully");
        }
    }

    public void SearchABook()
    {
        Console.Write(@$"1.Title
2.Author
3.Price
4.Time lapse
5.Gender
6.ISBN

Enter the number of the option to search for:");
        string? option = Console.ReadLine();
        bool verification = isDouble(option);

        if (verification == false)
        {
            Console.WriteLine("You must write a number");
        }
        else if (isInrange(1, 6, Convert.ToDouble(option)) == false)
        {
            Console.WriteLine("You must write an option that is inside the range");
        }
        else
        {
            double optionD = Convert.ToDouble(option);
            switch (optionD)
            {
                case (1):
                    SearchByTitle();
                    break;
                case (2):
                    SearchByAuthor();
                    break;
                case (3):
                    SearchByPrice();
                    break;
                case (4):
                    SearchByTimeLapse();
                    break;
                case (5):
                    SearchByGender();
                    break;
                case (6):
                    SearchByISBN();
                    break;
            }
        }

    }

}

