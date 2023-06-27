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
            //RetrieveAge_Between_12to18UsingLinq(students);
            //SortStudentsDat_BasedonMarks(students);
           // StudentRecordsInEachAddress(students);
           // FetchThreeRecords(students);
            SearchParticularStudentName(students);
        }
        public static void AddStudents(List<StudentData>list)
        {
            list.Add(new StudentData(1, "Somu", 9807654321, "karnataka", 15,69));
            list.Add(new StudentData(2, "Anil", 8546454321, "Kerala", 11,72));
            list.Add(new StudentData(3, "Shankar", 9867554321, "TamilNadu", 14,83));
            list.Add(new StudentData(4, "Kumar", 9807612345, "KGF", 16,37));
            list.Add(new StudentData(5, "Shekar", 9883733221, "KGF", 14,81));
            list.Add(new StudentData(6, "Manju", 9988054321, "KGF", 15,85));
            list.Add(new StudentData(7, "Nandu", 8877654321, "KGF", 10,63));
            list.Add(new StudentData(8, "Ramesh", 7668954321, "KGF", 12,46));
            list.Add(new StudentData(5, "Rajesh", 9883733221, "KGF", 18,58));
            list.Add(new StudentData(5, "Venky", 9883733221, "KGF", 14,76));
            var dataList = list.Select(x => new { x.Id, x.Name, x.Phone_Number,x.Address ,x.Age,x.Marks});
            Console.WriteLine("Student Records Added to the List");
            Console.WriteLine("----------------------------------");
            foreach (var data in dataList)
            {
                Console.WriteLine("ID:"+data.Id+"  "+"Name:"+data.Name+"  "+"Phone Number:"+data.Phone_Number+"  "+"Address:"+data.Address+"  "+"Age:"+data.Age+"  "+"Marks:"+data.Marks);
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
                Console.WriteLine("ID:" + data.Id + "  " + "Name:" + data.Name + "  " + "Phone Number:" + data.Phone_Number + "  " + "Address:" + data.Address + "  " + "Age:" + data.Age+"  " + "Marks:" + data.Marks);
            }
        }
        public static void SortStudentsDat_BasedonMarks(List<StudentData> list)
        {
            var sort = list.OrderByDescending(x => x.Marks).ToList();
            Console.WriteLine("");
            Console.WriteLine("Displaying Marks in Descending and Added to the List");
            Console.WriteLine("-----------------------------------------------------");
            foreach (var data in sort)
            {
                Console.WriteLine("ID:" + data.Id + "  " + "Name:" + data.Name + "  " + "Phone Number:" + data.Phone_Number + "  " + "Address:" + data.Address + "  " + "Age:" + data.Age + "  " + "Marks:" + data.Marks);
            }
        }
        public static void StudentRecordsInEachAddress(List<StudentData> list)
        {
            var address = list.Select(x => new { x.Id, x.Name, x.Phone_Number, x.Address, x.Age, x.Marks });
            Console.WriteLine("");
            Console.WriteLine("Displaying All Records in each Address");
            Console.WriteLine("---------------------------------------");
            foreach (var data in address)
            {
                Console.WriteLine("Address:" + data.Address + "  "+"ID:" + data.Id + "  " + "Name:" + data.Name + "  " + "Phone Number:" + data.Phone_Number + "  " +"Age:" + data.Age + "  " + "Marks:" + data.Marks);
            }
        }
        public static void FetchThreeRecords(List<StudentData>list)
        {
            var three = list.Select(x => new { x.Id, x.Name, x.Phone_Number, x.Address, x.Age, x.Marks }).Take(3);
            Console.WriteLine("");
            Console.WriteLine("Displaying All Records in each Address");
            Console.WriteLine("---------------------------------------");
            foreach(var data in three)
            {
                Console.WriteLine("ID:" + data.Id + "  " + "Name:" + data.Name + "  " + "Phone Number:" + data.Phone_Number + "  " + "Address:" + data.Address + "  " + "Age:" + data.Age + "  " + "Marks:" + data.Marks);
            }
        }
        public static void SearchParticularStudentName(List<StudentData>list)
        {
            Console.WriteLine("");
            Console.WriteLine("Searching Student Name and Display Data From List");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Enter Name Serach Student Details:");
            string input=Console.ReadLine();
            var search=list.FindAll(x=>x.Name==input).ToList();
            foreach(var data in search)
            {
                Console.WriteLine("ID:" + data.Id + "  " + "Name:" + data.Name + "  " + "Phone Number:" + data.Phone_Number + "  " + "Address:" + data.Address + "  " + "Age:" + data.Age + "  " + "Marks:" + data.Marks);
            }
        }
    }
}
