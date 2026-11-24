using System;

namespace PizzaApp;

public class Rendeles
{
    public int Id {get;private set;}
    public Pizza Pizza {get;private set;}
    public int Darab {get;private set;}
    public Cim Cim {get;private set;}
    public TimeSpan Ido {get;private set;}

    public Rendeles(int id, Pizza pizza, int darab, Cim cim, TimeSpan ido)
    {
        this.Id = id;
        this.Pizza = pizza;
        this.Darab = darab;
        this.Cim = cim;
        this.Ido = ido;
    }
}
