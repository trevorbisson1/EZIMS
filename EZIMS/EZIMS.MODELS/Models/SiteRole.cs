using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS.Models
{
    public class SiteRole
    {
        [Key]
        public int SiteRoleID { get; set; }

        public required string Name { get; set; }
        
    }
}
