using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class BusinessAction
    {
        public int BusinessActionID { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
