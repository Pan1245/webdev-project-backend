using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Dtos.PrivateClassDtos
{
    public class GetPrivateClassWithNameDto
    {
        [Required]
        public int id { get; set; }
        public string? room { get; set; }
        [Required]
        public StudyMethod method { get; set; } = StudyMethod.onsite;
        private DateTime _date;
        [Required]
        public string date { get { return _date.ToString("dd-MMMM-yyyy"); } set { _date = DateTime.Parse(value); } }
        private TimeOnly _fromTime;
        [Required]
        public string fromTime { get { return _fromTime.ToString("HH:mm"); } set { _fromTime = TimeOnly.Parse(value); } }
        private TimeOnly _toTime;
        [Required]
        public string toTime { get { return _toTime.ToString("HH:mm"); } set { _toTime = TimeOnly.Parse(value); } }
        public List<GetStudentPrivateClassWithNameDto> studentPrivateClasses { get; set; } = new List<GetStudentPrivateClassWithNameDto>();
        public GetTeacherPrivateClassWithNameDto teacherPrivateClass { get; set; } = new GetTeacherPrivateClassWithNameDto();
    }
}