using SalesWebV.Data;
using SalesWebV.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebV.Services
{
    public class DepartmentService
    {
        private readonly SalesWebVContext _context;

        public DepartmentService(SalesWebVContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
