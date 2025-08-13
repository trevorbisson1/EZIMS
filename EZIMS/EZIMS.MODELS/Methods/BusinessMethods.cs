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
        /// Takes the Guid of the Business that you want to return, does track the model that is returned.
        /// Will throw a null reference if the business is not found
        /// </summary>
        /// <param name="id">The GUID of the business model that you want to return</param>
        /// <returns>the Task<Business> that you want to find</returns>
        public async Task<Business> GetBusinessAsync(Guid id)
        {
            try
            {
                var business = await _context.Business.FindAsync(id);
                if(business == null)
                {
                    throw new NullReferenceException("Business Does not exist.");
                }
                return business;
            }
            catch {
                throw;
            }
        }

        /// <summary>
        /// This returns a Business Object by passing in a guid of a business. Will throw an exception if 
        /// search is null, the model does not track the changes of the model
        /// </summary>
        /// <param name="id">The Guid of the Business that you want to find</param>
        /// <returns>Business model</returns>
        public async Task<Business> GetBusinessNoTrackingAsync(Guid id)
        {
            try
            {
                var business = await _context.Business.AsNoTracking().SingleOrDefaultAsync(x => x.BusinessID == id);
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
        /// search is null or if there is more than one business with the inputted name, 
        /// the model does not track the changes of the model
        /// </summary>
        /// <param name="Name">The Name of the Business that you want to find</param>
        /// <returns>Business model</returns>
        public async Task<Business> GetBusinessNoTrackingAsync(string Name)
        {
            try
            {
                var business = await _context.Business.AsNoTracking().SingleOrDefaultAsync(x => x.Name == Name);
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
        public async Task<Business> CreateBusinessAsync(string Name)
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

        /// <summary>
        /// Updates a Business object by taking the model passed in, taking the guid from the 
        /// model and using the model to replace the one in the data position of that guid
        /// </summary>
        /// <param name="business">the new model of the business that you wish to update</param>
        /// <returns>the updated business model</returns>
        public async Task<Business> UpdateBusinessAsync(Business business)
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
