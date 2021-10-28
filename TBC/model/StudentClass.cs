using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TBC.model
{
    public class StudentClass
    {
        public int Id { get; set; }
        [Required]
        public string IdNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public bool Sex { get; set; }
    }
}
