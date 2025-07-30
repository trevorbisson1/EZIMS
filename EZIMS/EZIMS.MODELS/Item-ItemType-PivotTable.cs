using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class Item_ItemType_PivotTable
    {
        public int ItemID { get; set; }
        public int ItemType { get; set; } 
        private string? Note {  get; set; }
        public Guid BusinessID { get; set; }

    }
}
