using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Dtos.StudentPrivateClassDtos
{
    public class UpdateStudentPrivateClassDto
    {
        [Required]
        public int id { get; set; }
        public int studentId { get; set; }
        [Required]
        public Attendance attendance { get; set; }
    }
}