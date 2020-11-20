using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Data.EF
{
    [MetadataType(typeof(UserDetailMetadata))]
    public partial class UserDetail
    {
        [Display(Name = "Name")]
        public string userFullname
        {
            get { return ($"{FirstName} {LastName}"); }
        }
    }

    public class UserDetailMetadata
    {
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "* First Name can only be a max of 50 characters.")]
        [Required(ErrorMessage = "* First Name is REQUIRED")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "*Last Name can only be a max of 50 characters.")]
        [Required(ErrorMessage = "* Last Name is REQUIRED")]
        public string LastName { get; set; }

        [Display(Name = "Resume")]
        [StringLength(75, ErrorMessage = "* Resmue Name can only be a max of 75 characters.")]
        public string ResumeFileName { get; set; }

        [Display(Name = "Current Employee")]
        public bool CurrentEmployee { get; set; }
    }
}
