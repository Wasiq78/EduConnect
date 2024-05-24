using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EduConnect.Models
{
    public class HiringForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(20)")] // Corrected TypeName attribute
        public string Name { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string TutorCode { get; set; }

       

        [Column(TypeName = "varchar(200)")]
        public string Message { get; set; }
    }
}
