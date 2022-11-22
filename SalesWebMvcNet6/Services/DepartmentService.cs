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

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
