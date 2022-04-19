using StudentApp.Mvc.Models;

namespace StudentApp.Mvc.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();

        Student? GetStudentById(int studentId);

        Student AddStudent(Student student);

        Student? UpdateStudent(Student student);

        bool DeleteStudent(int studentId);
    }
}