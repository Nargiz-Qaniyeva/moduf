using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifiers_part_2.Models
{
    internal class Person
    {
        public string Name;
        public string SurName;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string Name, string SurName, int Age)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Age = Age;
        }
       
     
    }
}
