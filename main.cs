using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cyberAcademy.cyberAcademy;

namespace cyberAcademy
{
    class Student
    {

        public static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine($"Enter your first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine($"Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Enter your ID:");
            string _StudentID = Console.ReadLine();
            Console.WriteLine($"Enter your DateOfBirth:");
            string _DateOfBirth = Console.ReadLine();
            Console.WriteLine($"Enter your MaritalStatus:");
            string _MaritalStatus = Console.ReadLine();
        }
    }
}
