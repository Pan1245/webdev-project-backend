using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Dtos.StudentDtos
{
    public class GetStudentDto
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string StudentId { get { return dateCreated.ToString("yy", System.Globalization.CultureInfo.GetCultureInfo("en-GB")) + (id % 10000).ToString("0000"); } }
        [Required]
        public string firebaseId { get; set; } = string.Empty;
        [Required]
        public string title { get; set; } = string.Empty;
        [Required]
        public string fName { get; set; } = string.Empty;
        [Required]
        public string lName { get; set; } = string.Empty;
        public string fullName { get; set; } = string.Empty;
        [Required]
        public string nickname { get; set; } = string.Empty;
        public string? profilePicture { get; set; }
        private DateTime _dob;
        [Required]
        public string dob
        {
            get { return _dob.ToString("dd-MMMM-yyyy", System.Globalization.CultureInfo.InvariantCulture); }
            set { _dob = DateTime.Parse(value, System.Globalization.CultureInfo.InvariantCulture); }
        }
        public int age
        {
            get
            {
                int _age = 0;
                _age = DateTime.Now.Subtract(_dob).Days;
                _age /= 365;
                return _age;
            }
        }
        [Required]
        public string phone { get; set; } = string.Empty;
        [Required]
        public string line { get; set; } = string.Empty;
        [Required]
        public string email { get; set; } = string.Empty;
        [Required]
        public string school { get; set; } = string.Empty;
        [Required]
        public string countryOfSchool { get; set; } = string.Empty;
        [Required]
        public string levelOfStudy { get; set; } = string.Empty;
        [Required]
        public string program { get; set; } = string.Empty;
        [Required]
        public DateTime dateCreated { get; set; } = DateTime.Now;
        public string? targetUni { get; set; }
        public string? targetScore { get; set; }
        public string? hogInfo { get; set; }
        public string? healthInfo { get; set; }
        public GetParentDto? parent { get; set; }
        public GetAddressDto? address { get; set; }
        public ICollection<GetStudentAdditionalFilesDto>? additionalFiles { get; set; }
    }
}