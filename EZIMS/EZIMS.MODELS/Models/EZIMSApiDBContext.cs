using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS.Models
{
    public class EZIMSApiDBContext : DbContext
    {
        public EZIMSApiDBContext(DbContextOptions<EZIMSApiDBContext> options) : base(options)
        {

        }

        public required DbSet<Business> Business { get; set; }
        //public required DbSet<BusinessAction> BusinessActions { get; set; }
        //public required DbSet<BusinessAction_BusinessRole_PivotTable> BusinessAction_BusinessRole_PivotTables { get; set; }
        //public required DbSet<BusinessRole> BusinessRoles { get; set; }
        //public required DbSet<IMS_Users> IMS_Users { get; set; }
        //public required DbSet<Item> Items { get; set; }
        //public required DbSet<ItemHistory> ItemHistories { get; set; }
        //public required DbSet<Item_ItemType_PivotTable> Item_ItemType_PivotTables { get; set; }
        //public required DbSet<ItemType> ItemTypes { get; set; }
        //public required DbSet<SiteActions> SiteActions { get; set; }
        //public required DbSet<SiteActions_SiteRole_PivotTable> SiteActions_SiteRole_PivotTables { get; set; }
        //public required DbSet<SiteRole> SiteRoles { get; set; }
    }
}
