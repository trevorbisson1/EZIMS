using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class Business
    {
        public Guid BusinessID { get; set; }
        public required string Name { get; set; }

    }
}
