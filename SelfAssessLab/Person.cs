using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessLab
{
    public class Person
    {
        public Person(string name, int age, string address, string contactNo)
        {
            Name = name;
            Age = age;
            Address = address;
            ContactNo = contactNo;


        }
        public string Name
        {
            get;
            set;
        }
        public int Age { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
    }
}
