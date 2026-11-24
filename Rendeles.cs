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

    public string ToString()
    {
        return($"id:{this.Id}, darab:{this.Darab}, ido:{this.Ido}, pizza.ar:${this.Pizza.Ar}, pizza.nev:{this.Pizza.Nev}, pizza.meret:{this.Pizza.Meret}, pizza.id:{this.Pizza.Id}, cim.nev:{this.Cim.Nev}, cim.id:{this.Cim.Id}, cim.utca:{this.Cim.Utca}, cim.hsz:{this.Cim.Hsz}");
    }
}