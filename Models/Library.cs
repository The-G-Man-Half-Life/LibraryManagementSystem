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
        if(CanItTurnInADate== true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool isNullOrEmpty(string? Sentence)
    {
        return string.IsNullOrWhiteSpace(Sentence);
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
        bool verificationTitle = isNullOrEmpty(Title);
        
        Console.Write("Write down the publication Date of the book (YYYY/MM/DD): ");
        string? Date = Console.ReadLine();
        bool verificationDate = CanItbeADate(Date);

        Console.Write("Write down The Name of the author: ");
        string?  Author = Console.ReadLine();
        bool verificationAuthor = isNullOrEmpty(Author);

        Console.Write("Write Down the ISBN of the book: ");
        string? ISBN = Console.ReadLine();
        bool verificationISBN = isNullOrEmpty(ISBN);

        Console.Write("Write Down the Gender of the book: ");
        string? Gender = Console.ReadLine();
        bool verificationGender = isNullOrEmpty(Gender);

        Console.Write("Write Down the Price of the book: ");
        string? Price = Console.ReadLine();
        bool verificationPrice = isDouble(Price);

        Console.Write("Write Down the description of the book: ");
        string? Description = Console.ReadLine();
        bool verificationDescription = isNullOrEmpty(Description);

        if(verificationTitle== true || verificationDate==false || verificationAuthor==true || verificationISBN == true ||verificationGender == true || verificationPrice == false || verificationDescription==true)
        {
            Console.WriteLine("One of the signed values is uncorrect");
        }
        else
        {
            DateTime DateNew = Convert.ToDateTime(Date);
            double PriceNew = Convert.ToDouble(Price);

            Books.Add(new Book(Title,DateNew,Author,ISBN,Gender, PriceNew,Description));
            Console.WriteLine("The book was added successfully");
        }

    }

    public void ShowList()
    {
        Console.WriteLine(
@"1.Release date
2.Title
3.Author
4.Price
");

Console.Write("Ingrese el numero de su opcion deseada: ");
Console.ReadLine();
        foreach(Book book in Books)
        {
            Console.WriteLine($"Title:{book.Title} Publication Date:{book.PublicationTime.ToString("yyyy/MM/dd")} Author: {book.Author} ISBN: {book.ISBN} Gender: {book.Gender} Price: {book.Price} Description: {book.Description} ");
        }
    }
}
