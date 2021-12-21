using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace App.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Range(15, 70)]
        public int Age { get; set; }
        [Required]
        [MinLength(3)]
        public string Country { get; set; }
    }
}
