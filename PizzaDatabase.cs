using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;

namespace PizzaApp;

public class PizzaDatabase
{
    private readonly string connectionString;
    private readonly List<Rendeles> lista = [];
    private readonly Dictionary<int, Pizza> pizzak = [];
    private readonly Dictionary<int, Cim> cimek = [];

    public PizzaDatabase()
    {
        this.connectionString = "server=127.0.0.1;database=Pizzafutár;user=root;pwd=root;port=23456";

        try
        {
            using (MySqlConnection connection = new(this.connectionString))
            {
                connection.Open();
                Console.WriteLine("Az adatbaziskapcsolat felepult");
                string query = "SELECT * FROM pizza";
                using (MySqlCommand command = new(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            Pizza pizza = new(
                                id,
                                Convert.ToString(reader["nev"]) ?? "",
                                Convert.ToInt32(reader["meret"]),
                                Convert.ToInt32(reader["ar"])
                            );
                            Console.WriteLine(pizza);
                            this.pizzak[id] = pizza;
                        }
                    }
                }

                string query2 = "SELECT * FROM cim";
                using (MySqlCommand command = new(query2, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            Cim cim = new(
                                id,
                                Convert.ToString(reader["nev"]) ?? "",
                                Convert.ToString(reader["utca"]) ?? "",
                                Convert.ToString(reader["hsz"]) ?? ""
                            );
                            Console.WriteLine(cim);
                            this.cimek[id] = cim;
                        }
                    }
                }

                string query3 = "SELECT * FROM rendeles";
                using (MySqlCommand command = new(query3, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id"]);
                            Rendeles rendeles = new(
                                id,
                                pizzak[Convert.ToInt32(reader["pizzaid"])],
                                Convert.ToInt32(reader["darab"]),
                                cimek[Convert.ToInt32(reader["cimid"])],
                                reader.GetTimeSpan("szallitas")
                            );
                            Console.WriteLine(rendeles);
                            this.lista.Add(rendeles);
                        }
                    }
                }


            }
        }
        catch (Exception)
        {
            
        }
    }
}
