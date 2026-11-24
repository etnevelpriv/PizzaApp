using System;
using System.Dynamic;

namespace PizzaApp;

public class Pizza
{
    public int Id {get;private set;}
    public string Name {get;private set;}
    public int Meret {get;private set;}
    public int Ar {get;private set;}

    public Pizza (int id, string name, int meret, int ar)
    {
        this.Id = id;
        this.Name = name;
        this.Meret = meret;
        this.Ar = ar;
    }
}
