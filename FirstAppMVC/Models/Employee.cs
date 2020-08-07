using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAppMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage =" Please enter your age")]
        [Range(16,99, ErrorMessage = "Please enter age between 16 and 99")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please enter department")]
        public Dept Department { get; set; }
    }
}
