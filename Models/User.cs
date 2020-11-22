using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CourseProject.Models
{
    public class User 
    {
        public User()
        {
        }
        
        [Key]
        public long UserId { get; set; }

        [Required]
        [DisplayName("Full Name")]
        public string Name { get; set; }

        [DisplayName("Specialties")]
        public IList<SpecialtyUser> Specialties { get; set;}

        [DisplayName("Project Member")]
        public IList<ProjectMember> ProjectMember { get; set;}
        
        [DisplayName("Project Owner")]
        public IList<Project> ProjectOwner { get; set;}
    }
}