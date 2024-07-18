using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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


    public Publication(string? Title, DateOnly PublicationYear)
    {
        this.Title = Title;
        this.PublicationYear = PublicationYear;
    }
}
