using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Data.EF
{
    [MetadataType(typeof(LocationMetadata))]
    public partial class Location { }

    public class LocationMetadata
    {
        [Display(Name = "Store Number")]
        [StringLength(10, ErrorMessage = "* Store Number can only be a max of 10 characters.")]
        [Required(ErrorMessage = "* Store Number is REQUIRED")]
        public string StoreNumber { get; set; }

        [StringLength(50, ErrorMessage = "* City can only be a max of 50 characters.")]
        [Required(ErrorMessage = "* City is REQUIRED")]
        public string City { get; set; }

        [StringLength(2, ErrorMessage = "* State can only be a max of 2 characters.")]
        [Required(ErrorMessage = "* State is REQUIRED")]
        public string State { get; set; }
    }
}
