using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppContext())
            {
                Console.WriteLine("Hello!");

                var query = from client in context.Clients
                            orderby client.FirstName
                            select client;

                foreach (var client in query)
                {
                    Console.WriteLine(client.FirstName + " " + client.LastName);
                }

                context.SaveChanges();
                context.Dispose();

                Console.WriteLine("Done!");
                Console.ReadKey();
            }
        }
    }
}
