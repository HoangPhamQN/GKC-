using StudentApp.Mvc.Models;

namespace StudentApp.Mvc.Services
{
    public interface IDepartmentService
    {
        List<Department> GetDepartments();
        Department? GetDepartmentById(int departmentId);
    }
}