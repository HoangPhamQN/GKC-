using System.ComponentModel.DataAnnotations;
namespace StudentApp.Mvc.Models
{
    public class Department
    {
        public Department(){
            this.Name = string.Empty;
            Students = new List<Student>();
        }
        [Key]
        public int Id { get; set; }

        [MaxLength(512)]
        public string Name { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}