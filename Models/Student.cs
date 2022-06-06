using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab10_Students.Models
{
    public class Student
    {
        public int Id { get; set; } //Id студента
        public string Student_Card_Number { get; set; } //Номер студенської картки
        public string Full_Name { get; set; } //ПІБ
        public int Course { get; set; } //Курс
    }
}