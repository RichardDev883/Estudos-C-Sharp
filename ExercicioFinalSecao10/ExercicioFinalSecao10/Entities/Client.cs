using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinalSecao10.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public Client()
        {
        }
        public Client(string clientName, string email, DateTime birthday)
        {
            Name = clientName;
            Email = email;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return Name
                + ", ("
                + Birthday.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
