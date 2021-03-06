using CourseProject.Models;

namespace CourseProject.ViewModels
{
    public class CreateUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        
        [NotContainsDigits]
        public string Name { get; set; }
    }
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        
        [NotContainsDigits]
        public string Name { get; set; }
    }
}