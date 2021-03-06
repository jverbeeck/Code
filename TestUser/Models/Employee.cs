﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestUser.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }
    }
}