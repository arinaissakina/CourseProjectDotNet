using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.Models
{
    public class SpecialtyUser
    {
        public SpecialtyUser()
        {
        }
        
        [Required]
        [DisplayName("Specialty Id")]
        public long SpecialtyId { get; set; }
        
        [ForeignKey("SpecialtyId")]
        public Specialty Specialty { get; set; }

        [Required]
        [DisplayName("User Id")]
        public long UserId { get; set; }
        
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}