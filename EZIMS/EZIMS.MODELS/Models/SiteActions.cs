using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS.Models
{
    public class SiteActions
    {
        [Key]
        public int SiteActionsID { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
