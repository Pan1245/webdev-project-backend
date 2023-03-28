using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Models
{
    public class Student
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string firebaseId { get; set; } = string.Empty;
        [Required]
        public string title { get; set; } = string.Empty;
        [Required]
        public string fName { get; set; } = string.Empty;
        [Required]
        public string lName { get; set; } = string.Empty;
        public string fullName { get { return fName + " " + lName; } }
        [Required]
        public string nickname { get; set; } = string.Empty;
        public string? profilePicture { get; set; }
        private DateTime _dob;
        [Required]
        public string dob { get { return _dob.ToString("dd-MMMM-yyyy HH:mm:ss"); } set { _dob = DateTime.Parse(value); } }
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
        public string? targetUni { get; set; }
        public string? targetScore { get; set; }
        public string? hogInfo { get; set; }
        public string? healthInfo { get; set; }
        public bool isActive { get; set; } = true;
        public int? CreatedBy { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime dateCreated { get; set; } = DateTime.Now;
        public Parent? parent { get; set; }
        public Address? address { get; set; }
        public ICollection<StudentAdditionalFiles>? additionalFiles { get; set; }
        public ICollection<PrivateRegistrationRequest>? privateRegistrationRequests { get; set; }
        public ICollection<StudentPrivateClass> privateClasses { get; set; } = new List<StudentPrivateClass>();
        public ICollection<ExamDate>? examDates { get; set; }
        public ICollection<StudentClassCancellationRequest>? classCancellationRequests { get; set; }

    }
}