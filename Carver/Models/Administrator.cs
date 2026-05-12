using System;
using System.Collections.Generic;
using System.Text;

namespace Carver.Models
{
    internal class Administrator : User
    {
        public Administrator(string name, string email, string password) : base(name, email, password, UserRole.Administrator)
        {
        }
    }
}
