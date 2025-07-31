using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class ItemType
    {
        [Key]
        public int ItemID { get; set; }
        public required string  Name {get; set;}
        public required Guid BusinessID { get; set; }

    }
}
