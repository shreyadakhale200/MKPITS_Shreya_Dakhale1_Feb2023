using System.ComponentModel.DataAnnotations;

namespace ValidationMessage.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Enter Name, Name is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Enter Mobile Number, Mobile number is Required")]
        public string Mobile { get; set; }
    }
}
