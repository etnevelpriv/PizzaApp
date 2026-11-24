using System;
using System.Dynamic;

namespace PizzaApp;

public class Cim
{
    public int Id {get;private set;}
    public string Nev{get;private set;}
    public string Utca{get;private set;}
    public string hsz{get;private set;}

    public Cim (int id, string nev, string utca, string hsz)
    {
        this.Id = id;
        this.Nev = nev;
        this.Utca = utca;
        this.hsz = hsz;
    }
}
