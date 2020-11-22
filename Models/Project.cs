using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.Models
{
    public class Project
    {
        public Project()
        {
        }

        [Key]
        public long Id { get; set; }

        [Required]
        [DisplayName("Project Name")]
        public string Name { get; set; }
        
        [Required]
        [DisplayName("Project Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Owner Id")]
        public long OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public User Owner { get; set; }

        [DisplayName("List of Members")]
        public IList<ProjectMember> ProjectMembers { get; set; }
        
        [DisplayName("List of Specialties")]
        public IList<Specialty> Specialties { get; set; }

    }
}