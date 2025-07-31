using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public required string Name { get; set; }
        public required int Quantity { get; set; }
        public string? Description { get; set; }
        public required Guid BusinessID { get; set; }

    }
}
