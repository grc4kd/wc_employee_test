﻿using System;

namespace api.Model
{
    public class Employee
    {
        public Employee()
        {
        }

        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Department { get; set; }
        public DateTime HireDate { get; set; }
    }
}