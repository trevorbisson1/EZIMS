using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class BusinessAction_BusinessRole_PivotTable
    {
        [Key]
        public int BusinessRoleId { get; set; }
        [Key]
        public int BusinessActionID { get; set; }
        public string? Notes { get; set; }
    }
}
