using Microsoft.EntityFrameworkCore;
using SalesWebV.Data;
using SalesWebV.Models.ViewModels;
using SalesWebV.Services.Exception;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesWebV.Services
{
	public class SellerService
    {
        private readonly SalesWebVContext _context;


        public SellerService(SalesWebVContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.Include(s => s.Department).ToListAsync(); 
        }

        public async Task InsertAsync(Seller seller)
        {
            _context.Add(seller);
            await _context.SaveChangesAsync();
        }


        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(dep=> dep.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task DeleteSellerAsync(int id) {
            try
            {
                var seller = await _context.Seller.FindAsync(id);
                if (seller != null)
                {
                    _context.Seller.Remove(seller);
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
           
        }

        public async Task UpdateAsync(Seller seller)
        {

            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == seller.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {

                _context.Update(seller);
                await _context.SaveChangesAsync();

            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }


    }
}
