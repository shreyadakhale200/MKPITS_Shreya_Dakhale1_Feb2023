using System.ComponentModel.DataAnnotations;

namespace ValidationMessage.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage ="Enter Name, it cannot be empty")]
        public string UserName { get; set; }
    }
}
