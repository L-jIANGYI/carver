using System;
using System.Collections.Generic;
using System.Text;

namespace Carver.Models
{
    internal class Administrator : User
    {
        public Administrator(string email, string name, string password) : base(email, name, password, "Administrator")
        {
        }
    }
}
