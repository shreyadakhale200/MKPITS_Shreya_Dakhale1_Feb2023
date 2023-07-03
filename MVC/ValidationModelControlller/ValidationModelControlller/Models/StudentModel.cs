using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;

namespace ValidationModelControlller.Models
{
    public class StudentModel
    {
        #region==========DATA ANNOTATION==========
        #region=====1.REQUIRED=====
        ///<summary>Specifies that Input field cannot be empty.</summary>
        [Required(ErrorMessage ="Name is required")]

        #region=====2.DISPLAY NAME=====
        ///<summary>2. DisplayName Specifies the Display Name for a Property.</summary>
        [DisplayName("Enter Your Name: ")]

        #region=====3.STRING LENGTH=====
        ///<summary>Specifies minimum and maximum length for a property.</summary>
        [StringLength(100,MinimumLength = 5)]
        public string Name { get; set; }
        #endregion
        #endregion

        [Required(ErrorMessage ="Age is required")]

        #region=====4.RANGE=====
        ///<summary>Specifies a range of numeric value.</summary>
        [Range(2,100,ErrorMessage ="Age must be between 1 - 100 in years.")]
        public int Age { get; set; }
        #endregion
        #endregion
        #endregion
    }
}
