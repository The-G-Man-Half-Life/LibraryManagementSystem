using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models;

public class Library
{
    public List<Book> Books;


    public Library()
    {
        Books = new List<Book>();
    }


    bool CanItbeADate(string? Date)
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
    bool isDouble(string? Number)
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

    public void betterForEachStructure(List<Book> books)
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
}
