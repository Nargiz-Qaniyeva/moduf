using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifiers_part_2.Models
{
    internal class Student:Person
    {
        public int Point;

        public Student(int Point, string Name, int Age) : base(Name, Age)
        {
            this.Point = Point;
           
            
        }
        public string GetInfo()
        {
            return $"Name: {Name} - Surname: {SurName} - Age: {Age} - Point: {Point}\nName: {Name} - Age: {Age}";
        }

    }
}
