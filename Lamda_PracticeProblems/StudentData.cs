using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_PracticeProblems
{
    public class StudentData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Phone_Number { get; set; }
        public string Address { get; set; }
        public double Age { get; set; }
        public StudentData(int id,string name,double phone_number,string address,double age)
        {
            this.Id = id;
            this.Name = name;
            this.Phone_Number = phone_number;
            this.Address = address;
            this.Age = age;
        }
    }
}
