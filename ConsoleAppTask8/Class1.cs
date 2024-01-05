using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask8
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public DateTime BirthDate { get; set; }


        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Surname: {Surname}, Birth Date: {BirthDate.ToString()}";
        }
    }
}
