using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Dtos.StudentAddtionalFilesDtos
{
    public class AddStudentAdditionalFilesDto
    {
        [Required]
        public string file { get; set; } = string.Empty;
    }
}