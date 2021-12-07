using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleWebApi
{
    public class Student
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required][StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        public List<StudentSubject> StudentSubjects { get; set; }
        public StudentKey StudentKey { get; set; }
    }
    public class StudentSubject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Subject { get; set; }
        [ForeignKey("StudId")]
        public Student Students { get; set; }

    }
    public class StudentKey
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string KyeName { get; set; }
        [ForeignKey("StudId")]
        public Student Students { get; set; }
    }
}
