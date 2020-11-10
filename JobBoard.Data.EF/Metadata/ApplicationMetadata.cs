using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Data.EF
{
    [MetadataType(typeof(ApplicationMetadata))]
    public partial class Application { }

    public class ApplicationMetadata
    {
        [Required(ErrorMessage = "* User is REQUIRED")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "* Position is REQUIRED")]
        public int OpenPositionId { get; set; }

        [Required(ErrorMessage = "* Application Date is REQUIRED")]
        [Display(Name = "Application Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime ApplicationDate { get; set; }

        [Display(Name = "Manager Note")]
        [UIHint("MultilineText")]
        [StringLength(200, ErrorMessage = "* Manger Notes can only be a max of 200 characters.")]
        public string ManagerNotes { get; set; }

        [Required(ErrorMessage = "* Application Status is REQUIRED")]
        public int ApplicationStatusID { get; set; }

        [Required(ErrorMessage = "* Resume is REQUIRED")]
        public string ResumeFilename { get; set; }
    }
}
