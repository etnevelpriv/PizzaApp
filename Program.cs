namespace PizzaApp;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("teszt");
        PizzaDatabase database = new();
        List<Rendeles> rendelesek = database.UploadData();
        foreach(Rendeles rendeles in rendelesek)
        {
            Console.WriteLine(rendeles.ToString());
        }
    }
}