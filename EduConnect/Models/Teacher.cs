using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EduConnect.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName="varchar(20)")]
        public string TeacherName { get; set; }
        [Column(TypeName = "varchar(20)")]

        public string Qualification { get; set; }

    }
}
