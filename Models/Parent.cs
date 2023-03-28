using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Models
{
    public class Parent
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string fName { get; set; } = string.Empty;
        [Required]
        public string lName { get; set; } = string.Empty;
        public string fullName { get { return fName + " " + lName; } }
        [Required]
        public string relationship { get; set; } = string.Empty;
        [Required]
        public string phone { get; set; } = string.Empty;
        [Required]
        public string email { get; set; } = string.Empty;
        [Required]
        public string line { get; set; } = string.Empty;
        public Student? student { get; set; }
        public int studentId { get; set; }

    }
}