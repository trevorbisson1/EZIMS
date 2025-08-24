using EZIMS.MODELS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS.Methods
{
    public class ItemMethods
    {
        private EZIMSApiDBContext _context;
        public ItemMethods(EZIMSApiDBContext context)
        {
            _context = context;
        }

        public async Task<Item> GetItemByIDAsync(int itemID)
        {
            try
            {
                var val =  await _context.Items.FindAsync(itemID);
                if (val == null) {
                    throw new NullReferenceException("No Item with that ID.");
                }
                else
                {
                    return val;
                }
            }
            catch {
                throw;
            }

        }

        public async Task<List<Item>> GetAllItemsAsync()
        {
            try
            {
                var val = await _context.Items.ToListAsync();
                if (val == null)
                {
                    throw new NullReferenceException("No Item with that ID.");
                }
                else
                {
                    return val;
                }
            }
            catch
            {
                throw;
            }

        }
    }
}
