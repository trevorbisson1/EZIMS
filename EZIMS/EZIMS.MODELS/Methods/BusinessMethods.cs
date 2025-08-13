using EZIMS.MODELS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZIMS.MODELS.Methods
{
    public class BusinessMethods
    {
        private EZIMSApiDBContext _context;
        public BusinessMethods(EZIMSApiDBContext context)
        {
            _context = context;
        }
        /// <summary>
        /// This returns a Business Object by passing in a guid of a business. Will throw an exception if 
        /// search is null
        /// </summary>
        /// <param name="id">The Guid of the Business that you want to find</param>
        /// <returns>Business model</returns>
        public async Task<Business> GetBusiness(Guid id)
        {
            try
            {
                var business = await _context.Business.AsNoTracking().FirstOrDefaultAsync(x => x.BusinessID == id);
                if (business == null)
                {
                    throw new NullReferenceException("Business Does Not Exist.");
                }
                return business;
            }
            catch
            {
                throw;
            }

        }
        /// <summary>
        /// This returns a Business Object by passing in the name of a business. Will throw an exception if 
        /// search is null or if there is more than one business with the inputted name
        /// </summary>
        /// <param name="Name">The Name of the Business that you want to find</param>
        /// <returns>Business model</returns>
        public async Task<Business> GetBusiness(string Name)
        {
            try
            {
                var business = await _context.Business.SingleOrDefaultAsync(x => x.Name == Name);
                if (business == null)
                {
                    throw new NullReferenceException("Business Does Not Exist.");
                }
                return business;
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// Add a Business to the Business Table
        /// </summary>
        /// <param name="Name">The name of the Business that you want to add</param>
        /// <returns>The Business model that was just added to the Business table</returns>
        public async Task<Business> CreateBusiness(string Name)
        {
            try
            {
                var business = new Business()
                {
                    Name = Name
                };
                await _context.Business.AddAsync(business);
                var check = await _context.SaveChangesAsync();
                if (check != 1)
                {
                    throw new InvalidOperationException("Business Add Save Failed");
                }
                return business;
            }
            catch
            {
                throw;
            }
        }

        public async Task<Business> UpdateBusiness(Business business)
        {
            try
            {
                var returnable = await _context.Business.FindAsync(business.BusinessID);
                if (returnable == null)
                {
                    throw new NullReferenceException("Business Doesn't exist. Try Creating the business first.");
                }
                returnable = business;
                var check = await _context.SaveChangesAsync();
                if (check != 1)
                {
                    throw new InvalidOperationException("Save Failed for updating the business");
                }
                return returnable;
            }
            catch
            {
                throw;
            }
        }
    }
}
