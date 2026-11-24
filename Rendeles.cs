using System;

namespace PizzaApp;

public class Rendeles
{
    public int Id {get;private set;}
    public int PizzaID {get;private set;}
    public int Darab {get;private set;}
    public int CimId {get;private set;}
    public TimeSpan Ido {get;private set;}

    public Rendeles(int id, int pizzaId, int darab, int cimId, TimeSpan ido)
    {
        this.Id = id;
        this.PizzaID = pizzaId;
        this.Darab = darab;
        this.CimId = cimId;
        this.Ido = ido;
    }
}
