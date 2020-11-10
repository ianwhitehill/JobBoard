using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Data.EF
{
    [MetadataType(typeof(PositionMetadata))]
    public partial class Position { }

    public class PositionMetadata
    {
        [Required(ErrorMessage = "* Title is REQUIRED")]
        [StringLength(50, ErrorMessage = "* Title can only be a max of 50 characters.")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        [UIHint("MultilineText")]
        public string JobDescription { get; set; }
    }
}
