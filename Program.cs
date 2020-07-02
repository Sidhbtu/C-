using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentClassAssignment
{

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public string DOB { get; set; }

        public int Salary { get; set; }
        public string CompanyName { get; set; }

        public long ContactNumber { get; set; }
        public string Email { get; set; }

        public string CollegeName { get; set; }
        public string Location { get; set; }
    }


    class Program
    {

        static void Main(string[] args)
        {

            List<Student> list = new List<Student>();
            
            AddStudent.addStudentInfo(ref list);

            //foreach (student student in list)
            //{
            //    console.writeline(student.name);
            //}

            int count = 0;

            bool isValid = false;

             int studentId = 0;

            Console.WriteLine("Enter your Student ID : ");

            isValid=int.TryParse(Console.ReadLine(),out  studentId);

        Line54: if (isValid==true )
            {
               Student studentInformation= list.Where(student => student.Id == studentId).SingleOrDefault();

                 getStudentInfo.printInformation(studentInformation);
                

            }
            else
            {
               count++;
                Console.WriteLine("Please enter valid StudentID");
                isValid = int.TryParse(Console.ReadLine(), out studentId);
                if (count<3)
                goto Line54;

            }





            Console.ReadKey();





        }
    }
}
