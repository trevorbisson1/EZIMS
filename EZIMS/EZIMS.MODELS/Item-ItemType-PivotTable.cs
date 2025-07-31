using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class Item_ItemType_PivotTable
    {
        [Key]
        public int ItemID { get; set; }
        [Key]
        public int ItemType { get; set; } 
        private string? Note {  get; set; }
        public Guid BusinessID { get; set; }

    }
}
