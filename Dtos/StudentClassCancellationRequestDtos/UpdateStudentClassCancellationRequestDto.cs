namespace houseofgriffin_api.Dtos.StudentClassCancellationRequestDtos
{
    public class UpdateStudentClassCancellationRequestDto
    {
        [Required]
        public int id { get; set; }
        [Required]
        public int studentId { get; set; }
        [Required]
        public Student student { get; set; } = new Student();
        [Required]
        public int privateClassId { get; set; }
        [Required]
        public PrivateClass privateClass { get; set; } = new PrivateClass();
        public string? studentRemark { get; set; }
        public string? OARemark { get; set; }
    }
}