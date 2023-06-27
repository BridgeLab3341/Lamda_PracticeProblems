using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_PracticeProblems
{
    public class StudentDataManagement
    {
        public void ListOfStudents()
        {
            List<StudentData> students = new List<StudentData>();
            AddStudents(students);
        }
        public static void AddStudents(List<StudentData>list)
        {
            list.Add(new StudentData(1, "Somu", 9807654321, "karnataka", 15));
            list.Add(new StudentData(2, "Anil", 8546454321, "Kerala", 11));
            list.Add(new StudentData(3, "Shankar", 9867554321, "TamilNadu", 14));
            list.Add(new StudentData(4, "Kumar", 9807612345, "KGF", 16));
            list.Add(new StudentData(5, "Shekar", 9883733221, "KGF", 14));
            list.Add(new StudentData(6, "Manju", 9988054321, "KGF", 15));
            list.Add(new StudentData(7, "Nandu", 8877654321, "KGF", 10));
            list.Add(new StudentData(8, "Ramesh", 7668954321, "KGF", 12));
            list.Add(new StudentData(5, "Rajesh", 9883733221, "KGF", 14));
            list.Add(new StudentData(5, "Venky", 9883733221, "KGF", 14));
            var dataList = list.Select(x => new { x.Id, x.Name, x.Phone_Number, x.Age });
            foreach(var data in dataList)
            {
                Console.WriteLine(data);
            }
        }
    }
}
