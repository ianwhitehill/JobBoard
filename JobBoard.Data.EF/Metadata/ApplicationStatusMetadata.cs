using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Data.EF
{
    [MetadataType(typeof(ApplicationStatusMetadata))]
    public partial class ApplicationStatu { }

    public class ApplicationStatusMetadata
    {
        [Required(ErrorMessage = "* Status is REQUIRED")]
        [Display(Name = "Status")]
        [StringLength(50, ErrorMessage = "* Status can only be a max of 50 characters.")]
        public string StatusName { get; set; }

        [Display(Name = "Description")]
        [UIHint("MultilineText")]
        [StringLength(250, ErrorMessage = "* Description can only be a max of 250 characters.")]
        public string StatusDescription { get; set; }
    }
}
