using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JobBoard.Data.EF
{
    [MetadataType(typeof(OpenPositionMetadata))]
    public partial class OpenPosition { }

    public class OpenPositionMetadata
    {
        [Required]
        public int LocationId { get; set; }

        [Required]
        public int PositionId { get; set; }

        [Required]
        [Display(Name = "Close Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime CloseDate { get; set; }

        [Required]
        public bool Internal { get; set; }
    }
}
