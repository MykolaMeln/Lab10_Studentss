using Lab10_Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab10_Students.Controllers
{
    public class StudentsController : ApiController
    {
        Student[] students = new Student[]
       {
            new Student{ Id = 1, Student_Card_Number="AA 290567", Full_Name="Melnychuk Mykola Dmytrovych", Course= 5},
            new Student{ Id = 2, Student_Card_Number="AC 246578", Full_Name="Koshelnyi Vladyslav Mykolajovich", Course= 5},
            new Student{ Id = 3, Student_Card_Number="BB 243689", Full_Name="Kalancha Artem Dmytrovych", Course= 5},
            new Student{ Id = 4, Student_Card_Number="AA 345628", Full_Name="Mytryniuk Oleksandr Vasyliovych", Course= 5},
            new Student{ Id = 5, Student_Card_Number="AB 871428", Full_Name="Martyshchuk Oleksandr Olehovych", Course= 4},
            new Student{ Id = 6, Student_Card_Number="AA 672176", Full_Name="Kovalenko Stanislav Ivanovych", Course= 3},
       };

        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        public IHttpActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault((s) => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

    }
}
