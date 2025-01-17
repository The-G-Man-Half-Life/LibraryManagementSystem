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
    public DateTime PublicationTime {get; set;}


    private string TextToLowerCase(string? Word)
    {
        var LCWord = Word.ToLower();
        return LCWord;
    }

    public Publication(string? Title, DateTime PublicationTime)
    {
        this.Title = TextToLowerCase(Title);
        this.PublicationTime = PublicationTime;
    }
}
