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
            var context = new AppContext();

            foreach (var client in context.Clients)
            {
                Console.WriteLine($"{client.Id} : {client.FirstName} : {client.LastName} : {client.Email} :" + 
                    $"{client.PhoneNumber} : {client.Address}\n");
            }

            context.SaveChanges();
            context.Dispose();
        }
    }
}
