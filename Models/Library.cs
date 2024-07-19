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
            Console.WriteLine("The number written is outside of range");
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
    public bool verifyExistence(string? book)
    {
        bool coincidences = Books.Any(book1 => book1.Title == book);
        return coincidences;
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

    public void ShowList()
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

        Console.WriteLine(
@"1.Ascendant
2.Descendant
");
        Console.Write("Insert the number of your Prefered order: ");
        string? option2 = Console.ReadLine();
        bool option2Verification = isDouble(option2);


        if (optionVerification == false || option2Verification == false)
        {
            Console.WriteLine("Debes de escribir un numero apropiado y dentro del rango");
        }
        else
        {
            double optionD = Convert.ToDouble(option);
            double option2D = Convert.ToDouble(option2);
            if ((optionD < 1 || optionD > 4) || (option2D < 1 || option2D > 2))
            {
                Console.WriteLine("Your choices must be in range of the options");
            }
            else
            {
                switch (optionD)
                {
                    case (1):
                        {
                            switch (option2D)
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
                            switch (option2D)
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
                            switch (option2D)
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
                            switch (option2D)
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

    public void verifyIfABookIsRecent()
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
    private void SearchByTitle()
    {
        Console.Write("Enter the name of the book you are looking for: ");
        string? book = Console.ReadLine().ToLower();
        var foundBook = Books.Where(book1 => book1.Title == book).Take(1).ToList();

        if(foundBook.Count()>=1)
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
        else
        {
            Console.WriteLine("You must choose an option in range");
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
            double order = ChooseOrder();                
            double minimumPriceD = Convert.ToDouble(minimumPrice);
            double maximumPriceD = Convert.ToDouble(maximumPrice);
            if (order == 1)
            {
                var booksInPriceRange = Books.Where(book => book.Price >= minimumPriceD && book.Price <= maximumPriceD).OrderBy(book => book.Price).ToList();
                Console.WriteLine($"These are all the books in the range of {minimumPriceD}$ and {maximumPriceD}$");
                betterForEachStructure(booksInPriceRange);
            }
            else if(order == 2)
            {
                var booksInPriceRangeDescending = Books.Where(book => book.Price >= minimumPriceD && book.Price <= maximumPriceD).OrderByDescending(book => book.Price).ToList();
                Console.WriteLine($"These are all the books in the range of {minimumPriceD}$ and {maximumPriceD}$");
                betterForEachStructure(booksInPriceRangeDescending);
            }
            else
            {
                Console.WriteLine("Your choice is out of range");
            }

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
                    break;
                case (5):
                    break;
                case (6):
                    break;
            }
        }

    }

}

