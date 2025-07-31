using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class ItemHistory
    {
        [Key]
        int ItemHistoryID { get; set; }
        public int ItemID { get; set; }
        public DateTime TrackDate { get; set; }
        public int Quantity { get; set; }
    }
}
