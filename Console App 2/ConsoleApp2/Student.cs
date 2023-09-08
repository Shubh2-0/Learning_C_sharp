using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student
    {

        public string name;
        public int age;
        public string city;

        public Student(string name, int age, string city)
        {
            this.name = name;
            this.age = age;
            this.city = city;
        }

        public Student() 
        { 
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{name} {city} {age}";
        }
    }








}
