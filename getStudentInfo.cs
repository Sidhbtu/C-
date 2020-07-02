using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassAssignment
{
    class getStudentInfo
    {

        public static void printInformation(Student student)
        {

            try
            {
                Console.WriteLine("ID= " + student.Id);
                Console.WriteLine("Name= " + student.Name);

                Console.WriteLine("Age= " + student.Age);
                Console.WriteLine("DOB= " + student.DOB);

                Console.WriteLine("Salary= " + student.Salary);
                Console.WriteLine("CompanyName= " + student.CompanyName);

                Console.WriteLine("ContactNumber= " + student.ContactNumber);
                Console.WriteLine("Email= " + student.Email);

                Console.WriteLine("CollegeName= " + student.CollegeName);
                Console.WriteLine("Location= " + student.Location);
            }
            catch (Exception ex)

            {
                Console.WriteLine("Student does not exist with this StudentId");
            }

               
            }
            
}
}
