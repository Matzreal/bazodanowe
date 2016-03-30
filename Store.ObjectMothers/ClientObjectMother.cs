using Store.Domain.Model.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.ObjectMothers
{
    public class ClientObjectMother
    {
        public static Client CreateClient()
        {
            var client = new Client
            {
                Id = new Guid(),
                FirstName = "Jan",
                LastName = "Kowalski",
                Address = new Address("ul. Grunwaldzka", "Wroclaw", "Dolnoslaskie", "Polska", "55-357"),
                PhoneNumber = "555-123-789",
                Email = "jan.kowalski@email.com"
            };

            return client;
        }
    }
}
