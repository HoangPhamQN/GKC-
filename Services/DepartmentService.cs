using Microsoft.EntityFrameworkCore;
using StudentApp.Mvc.Models;

namespace StudentApp.Mvc.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly DataContext _context;
        public DepartmentService(DataContext context)
        {
            _context = context;

        }
        public Department? GetDepartmentById(int departmentId)
        {
            return _context.Department
            .FirstOrDefault(d => d.Id == departmentId);
        }

        public List<Department> GetDepartments()
        {
            return _context.Department.ToList();
        }
    }
}