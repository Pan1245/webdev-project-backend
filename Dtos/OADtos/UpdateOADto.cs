using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Dtos.OADtos
{
    public class UpdateOADto
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string fName { get; set; } = string.Empty;
        [Required]
        public string lName { get; set; } = string.Empty;
        [Required]
        public string nickname { get; set; } = string.Empty;
        [Required]
        public string phone { get; set; } = string.Empty;
        [Required]
        public string line { get; set; } = string.Empty;
        [Required]
        public string email { get; set; } = string.Empty;
    }
}