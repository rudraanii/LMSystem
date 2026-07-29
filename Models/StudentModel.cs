using System.ComponentModel.DataAnnotations;

namespace LMSystem.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
