using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models;
public class Book : Publication
{
    public string? Author {get; set;}
    public string? ISBN {get; set;}
    public string? Gender {get; set;}
    public double Price {get; set;}
    public string? Description {get; set;}


    private string TextToLowerCase(string? Word)
    {
        var LCWord = Word.ToLower();
        return LCWord;
    }


    public Book(string? Title,DateOnly PublicationYear,string?Author, string? ISBN, string? Gender, double Price, string? Description): base(Title, PublicationYear)
    {

        this.Author = TextToLowerCase(Author);
        this.ISBN = ISBN;
        this.Gender = TextToLowerCase(Gender);
        this.Price = Price;
        this.Description = TextToLowerCase(Description);
    }
}
