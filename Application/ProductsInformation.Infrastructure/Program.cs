using System;
using ProductsInformation.Infrastructure.Context;

namespace ProductsInformation.Infrastructure
{
    class Program
    {
        ///<summary>
        ///program that, when executed, creates the database if it does not exist.
        ///</summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Creating database if it does not exist...");
            PersistenceContext db = new PersistenceContext();
            db.Database.EnsureCreated();
            Console.WriteLine("ready!");
            Console.ReadKey();
        }
    }
}
