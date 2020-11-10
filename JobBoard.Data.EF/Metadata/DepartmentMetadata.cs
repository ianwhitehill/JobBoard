using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Data.EF
{
    [MetadataType(typeof(DepartmentMetadata))]
    public partial class Department{ }

    public class DepartmentMetadata
    {
        [Display(Name = "Department")]
        [StringLength(50, ErrorMessage = "* Department can only be a max of 50 characters.")]
        [Required(ErrorMessage = "* Department is REQUIRED")]
        public string DepartmentName { get; set; }
    }
}
