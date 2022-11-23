using Microsoft.EntityFrameworkCore;
using SalesWebMvcNet6.Data;
using SalesWebMvcNet6.Models;

namespace SalesWebMvcNet6.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcNet6Context _context;

        public DepartmentService(SalesWebMvcNet6Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
