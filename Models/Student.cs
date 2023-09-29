﻿using System.ComponentModel.DataAnnotations;

namespace Uygulama1.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //public string FullName => $"{FirstName} {LastName}";
    }
}
