using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CourseProject.Models
{
    public class Specialty
    {
        public Specialty()
        {
        }
        [Key]
        public long Id { get; set; }

        [Required]
        [DisplayName("Specialty Name")]
        
        public string Name { get; set; }

        [DisplayName("Users")]
        public IList<SpecialtyUser> SpecialityUsers { get; set; }

    }
}