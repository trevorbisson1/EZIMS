using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS.Models
{
    public class ItemType
    {
        [Key]
        public int ItemTypeID { get; set; }
        public required string  Name {get; set;}
        public required Guid BusinessID { get; set; }

    }
}
