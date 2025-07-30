using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class IMS_Users
    {
        Guid UserID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required int SiteRole { get; set; }
        public required int BusinessRole { get; set; }

    }
}
