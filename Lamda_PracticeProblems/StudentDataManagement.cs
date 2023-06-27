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
            RetrieveAge_Between_12to18UsingLinq(students);
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
            list.Add(new StudentData(5, "Rajesh", 9883733221, "KGF", 18));
            list.Add(new StudentData(5, "Venky", 9883733221, "KGF", 14));
            var dataList = list.Select(x => new { x.Id, x.Name, x.Phone_Number,x.Address ,x.Age });
            Console.WriteLine("Student Records Added to the List");
            Console.WriteLine("----------------------------------");
            foreach (var data in dataList)
            {
                Console.WriteLine("ID:"+data.Id+"  "+"Name:"+data.Name+"  "+"Phone Number:"+data.Phone_Number+"  "+"Address:"+data.Address+"  "+"Age:"+data.Age);
            }
        }
        public static void RetrieveAge_Between_12to18UsingLinq(List<StudentData>list)
        {
            var retrieveAge = list.FindAll(x => x.Age >= 12 && x.Age <= 18).ToList();
            Console.WriteLine("");
            Console.WriteLine("Retrieved Records Added to the List and Displaying");
            Console.WriteLine("---------------------------------------------------");
            foreach (var data in retrieveAge)
            {
                Console.WriteLine("ID:" + data.Id + "  " + "Name:" + data.Name + "  " + "Phone Number:" + data.Phone_Number + "  " + "Address:" + data.Address + "  " + "Age:" + data.Age);
            }
        }
    }
}
