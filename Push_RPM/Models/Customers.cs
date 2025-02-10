﻿using System.ComponentModel.DataAnnotations;

namespace Push_RPM.Models
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address_ { get; set; }
        public string PasswordHash { get; set; }



    }
}
