using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class SiteRole
    {
        [PrimaryKey]
        public int SiteRoleID { get; set; }

        public required string Name { get; set; }
        
    }
}
