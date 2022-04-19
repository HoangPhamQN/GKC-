using Microsoft.AspNetCore.Mvc;
using StudentApp.Mvc.Models;
using StudentApp.Mvc.Services;

namespace StudentApp.Mvc.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IDepartmentService _departmentService;
        public StudentController(IStudentService studentService, IDepartmentService departmentService)
        {
            _departmentService = departmentService;
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();
            // ViewData["StudentList"] = students;
            // ViewBag.StudentList = students;
            return View(students);
        }
        public IActionResult Add()
        {
            var departments = _departmentService.GetDepartments();
            return View(departments);
        }
        public IActionResult Save(Student student)
        {
            if(student.Id == 0){
                _studentService.AddStudent(student);
            }else{
                _studentService.UpdateStudent(student);
            }
            
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int studentId)
        {
            ViewBag.Department = _departmentService.GetDepartments();
            var student = _studentService.GetStudentById(studentId);
            return View(student);
        }
        public IActionResult Delete(int studentId)
        {
            _studentService.DeleteStudent(studentId);
            return RedirectToAction("Index");
        }
    }
}