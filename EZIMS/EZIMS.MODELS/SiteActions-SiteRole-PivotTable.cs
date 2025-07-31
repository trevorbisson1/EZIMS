using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class SiteActions_SiteRole_PivotTable
    {
        [Key]
        public int SiteActionsID { get; set; }
        [Key]
        public int SiteRolesID { get; set; }
        public string? Description { get; set; }
    }
}
