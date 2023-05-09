using System;

namespace ProfessorClass
{
    public class Professor
    {
        private string lNumber;
        private string firstName;
        private string lastName;
        private string department;

        public Professor() { }

        public Professor(string profLNumber, string profFirstName, string profLastName, string profDepartment)
        {
            lNumber = profLNumber;
            firstName = profFirstName;
            lastName = profLastName;
            department = profDepartment;
        }

        public string LNumber { get { return lNumber; } set { lNumber = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Department { get { return department; } set { department = value; } }

        public override string ToString()
        {
            return String.Format("L number: {0}, First Name: {1}, Last name: {2}, department: {3}", lNumber, FirstName, LastName, Department);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Professor());
            Console.WriteLine(new Professor("L00000000", "Lindy", "Stewart", "Computer Science"));
        }
    }
}