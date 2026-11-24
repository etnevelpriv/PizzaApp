using System;
using System.Dynamic;

namespace PizzaApp;

public class Pizza
{
    public int Id {get;private set;}
    public string Nev {get;private set;}
    public int Meret {get;private set;}
    public int Ar {get;private set;}

    public Pizza (int id, string nev, int meret, int ar)
    {
        this.Id = id;
        this.Nev = nev;
        this.Meret = meret;
        this.Ar = ar;
    }
}
