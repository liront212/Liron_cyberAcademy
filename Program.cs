using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.ExceptionServices;
using System.IO;
using static cyberAcademy.cyberAcademy;

namespace cyberAcademy
{
    public class cyberAcademy
    {
        public class Student
        {
            public string FirstName
            {
                get { return FirstName; ; }
                set { FirstName = value; }
            }
            public string LastName
            {
                get { return LastName; ; }
                set { LastName = value; }
            }
            public string _StudentID
            {
                get { return _StudentID; ; }
                set { _StudentID = value; }
            }
            public string _DateOfBirth
            {
                get { return _DateOfBirth; ; }
                set { _DateOfBirth = value; }
            }
            public string _MaritalStatus
            {
                get { return _MaritalStatus; ; }
                set { _MaritalStatus = value; }
            }
            public Student(string FirstName, string LastName, string _StudentID, string _DateOfBirth, string _MaritalStatus)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this._StudentID = _StudentID;
                this._DateOfBirth= _DateOfBirth;
                this._MaritalStatus= _MaritalStatus;
            }
            public static bool isvalid(string FirstName, string LastName, string _StudentID, string _DateOfBirth, string _MaritalStatus)
            {
                return (FirstName == null || FirstName == string.Empty);
                return (LastName == null || LastName == string.Empty);
                return (_StudentID == null || _StudentID == string.Empty);
                return (_DateOfBirth == null || _DateOfBirth == string.Empty);
                return (_MaritalStatus == null || _MaritalStatus == string.Empty);
                Console.WriteLine();
            }
        }        

    }
    
}

    //Console.WriteLine("invalid name try again");
    //            if (LastName == null)
    //                Console.WriteLine("invalid name try again");
    //            if (_StudentID == null)
    //                Console.WriteLine("invalid ID try again");
    //            if (_DateOfBirth == null)
    //                Console.WriteLine("invalid Date try again");
    //            if (_MaritalStatus == null)
    //                Console.WriteLine("invalid MaritalStatus try again");


