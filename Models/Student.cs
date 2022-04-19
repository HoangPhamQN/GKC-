using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApp.Mvc.Models
{
    public class Student
    {
        public Student()
        {
            this.Name = string.Empty;
            this.Address = string.Empty;
        }
        [Key]
        public int Id { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

        

        public int Age { get; set; }

        [MaxLength(512)]
        public string Address { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId {get; set;}

        public Department Department {get;set;}
    }
}