using SalesWebV.Data;
using SalesWebV.Models.ViewModels;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Linq;

namespace SalesWebV.Services
{
	public class SallesRecordService
	{
		private readonly SalesWebVContext _context;
		public SallesRecordService(SalesWebVContext context)
		{
			_context = context;
		}

		public async Task<List<SallesRecord>> AsyncFindBydate(DateTime? min, DateTime? max)
		{
			var result = _context.SallesRecord.AsQueryable();
			if (min.HasValue)
			{
				result = result.Where(x => x.Date >= min.Value);
			}
			if (max.HasValue)
			{
				result = result.Where(x => x.Date <= max.Value);
			}
			return await result
				.Include(x => x.Seller)
				.Include(x => x.Seller.Department)
				.OrderByDescending(x => x.Date)
				.ToListAsync();
		}

        public async Task<List<IGrouping<Department,SallesRecord>>> FindByDateGroupingAsync(DateTime? min, DateTime? max)
        {
            var result = _context.SallesRecord.AsQueryable();
            if (min.HasValue)
            {
                result = result.Where(x => x.Date >= min.Value);
            }
            if (max.HasValue)
            {
                result = result.Where(x => x.Date <= max.Value);
            }
			return await result
				.Include(x => x.Seller)
				.Include(x => x.Seller.Department)
				.OrderByDescending(x => x.Date)
				.GroupBy(x => x.Seller.Department)
                .ToListAsync();
        }

    }
}
