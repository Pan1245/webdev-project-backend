using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Dtos.AvailableScheduleDtos
{
    public class GetAvailableTeacherDto
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string firebaseId { get; set; } = string.Empty;
        [Required]
        public string fName { get; set; } = string.Empty;
        [Required]
        public string lName { get; set; } = string.Empty;
        public string fullName { get { return fName + " " + lName; } }

        [Required]
        public string nickname { get; set; } = string.Empty;
        public string workType { get; set; } = string.Empty;
        public bool currentClass { get; set; } = false;
    }
}