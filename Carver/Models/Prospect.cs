using System;
using System.Collections.Generic;
using System.Text;

namespace Carver.Models
{
    internal class Prospect
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public bool HasDrivingLicense { get; set; }   // A of B
        public bool HasScooterLicense { get; set; }   // AM
        public bool IsDisabledVehicle { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public Prospect(string firstName, string lastName, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

    }
}
