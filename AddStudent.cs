using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassAssignment
{
    class AddStudent
    {
        public static void addStudentInfo(ref List<Student> list)
        {
            list.Add(new Student()
            {
                Id = 1,
                Name = "Sudhanshu",
                Age = 23,
                DOB = "15/07/1997",
                Salary = 1000,
                CompanyName = "Cityon Systems",
                ContactNumber = 1234567890,
                Email = "Sudhanshu123@gmail.com",
                CollegeName = "HBTU Kanpur",
                Location = "kanpur"
            });

            list.Add(new Student()
            {
                Id = 2,
                Name = "Kunal",
                Age = 23,
                DOB = "19/04/1997",
                Salary = 1001,
                CompanyName = "Cityon Systems",
                ContactNumber = 1236674760,
                Email = "Kunal123@gmail.com",
                CollegeName = "HBTU Kanpur",
                Location = "Agra"
            });

            list.Add(new Student()
            {
                Id = 3,
                Name = "Akash",
                Age = 22,
                DOB = "22/09/1998",
                Salary = 2222,
                CompanyName = "Cityon Systems",
                ContactNumber = 56564454890,
                Email = "Akash123@gmail.com",
                CollegeName = "HBTU Kanpur",
                Location = "Gonda"
            });

            list.Add(new Student()
            {
                Id = 4,
                Name = "Bhavy",
                Age = 27,
                DOB = "23/11/1994",
                Salary = 9999,
                CompanyName = "Cityon Systems",
                ContactNumber = 999999999,
                Email = "Bhavy123@gmail.com",
                CollegeName = "HBTU Kanpur",
                Location = "Badot"
            });

            list.Add(new Student()
            {
                Id = 5,
                Name = "Nitin",
                Age = 24,
                DOB = "08/12/1996",
                Salary = 1000,
                CompanyName = "Cityon Systems",
                ContactNumber = 35646476676,
                Email = "Nitin123@gmail.com",
                CollegeName = "HBTU Kanpur",
                Location = "delhi NCR"
            });

            list.Add(new Student()
            {
                Id = 6,
                Name = "Ankit",
                Age = 23,
                DOB = "28/05/1997",
                Salary = 4321,
                CompanyName = "Cityon Systems",
                ContactNumber = 12556565690,
                Email = "Ankit123@gmail.com",
                CollegeName = "PSIT Kanpur",
                Location = "Kanpur"
            });

            list.Add(new Student()
            {
                Id = 7,
                Name = "Aniket",
                Age = 24,
                DOB = "11/07/1996",
                Salary = 1234,
                CompanyName = "Cityon Systems",
                ContactNumber = 45465755890,
                Email = "Aniket123@gmail.com",
                CollegeName = "PSIT Kanpur",
                Location = "Kanpur"
            });

            list.Add(new Student()
            {
                Id = 8,
                Name = "Anubhav",
                Age = 23,
                DOB = "09/06/1997",
                Salary = 4567,
                CompanyName = "Cityon Systems",
                ContactNumber = 3456567890,
                Email = "Anubhav123@gmail.com",
                CollegeName = "PSIT Kanpur",
                Location = "Kanpur"
            });

            list.Add(new Student()
            {
                Id = 9,
                Name = "Abhishek",
                Age = 22,
                DOB = "29/05/1998",
                Salary = 8765,
                CompanyName = "Cityon Systems",
                ContactNumber = 3452567890,
                Email = "Abhishek123@gmail.com",
                CollegeName = "PSIT Kanpur",
                Location = "Kanpur"
            });

            list.Add(new Student()
            {
                Id = 10,
                Name = "Suraj",
                Age = 25,
                DOB = "10/01/1995",
                Salary = 4567,
                CompanyName = "Cityon Systems",
                ContactNumber = 2467787890,
                Email = "Suraj123@gmail.com",
                CollegeName = "PSIT Kanpur",
                Location = "Kanpur"
            });
        }
    }
}
