using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduConnect.Models
{
    public class RequestTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ Column(TypeName = "varchar(20)")]
        [Required]
        public string Email { get; set; }
        [Column(TypeName ="varchar(20)")]
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Request { get; set; }

    }
}
