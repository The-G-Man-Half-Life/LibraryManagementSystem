using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace LibraryManagementSystem.Models;
public class Publication
{
    private string? PTitle {get; set;}
    public string? Title 
    {
        get{return PTitle;}
        set{PTitle = value.ToLower();}
    }
    public DateOnly PublicationYear {get; set;}


    private string TextToLowerCase(string? Word)
    {
        var LCWord = Word.ToLower();
        return LCWord;
    }

    public Publication(string? Title, DateOnly PublicationYear)
    {
        this.Title = TextToLowerCase(Title);
        this.PublicationYear = PublicationYear;
    }
}
