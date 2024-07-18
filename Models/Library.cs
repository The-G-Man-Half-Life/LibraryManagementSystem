using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models;

public class Library
{
    private List<Book> Books;


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

    public void AddANewBook(Book book)
    {
        Console.Write("Write down the title of the book");
        string? Title = Console.ReadLine();

        
        Console.Write("Write down the publication date of the book(YYYY/MM/DD)");
        string? Date = Console.ReadLine();
        bool VerificationDate1 = CanItbeADate(Date);

        Console.Write("Write down The name of the author");

    }
}
