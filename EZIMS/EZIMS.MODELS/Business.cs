using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS
{
    public class Business
    {
        [Key]
        public Guid BusinessID { get; set; }
        public required string Name { get; set; }

    }
}
