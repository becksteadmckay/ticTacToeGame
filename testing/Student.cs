using System;

namespace University
{
    class Student
    {
        public string Major;
        public int NumberOfCredits;
        public string FirstName;
        public string LastName;

        public Student()
        {
            Major = "unknown";
            NumberOfCredits = 0;
            FirstName = "student";
            LastName = "No Last Name";

        }
        public Student(string major, int numCredits, string fname, string lname)
        {
            Major = major;
            NumberOfCredits = numCredits;
            FirstName = fname;
            LastName = lname;
        }

        public void DisplayName()
        {
            Console.WriteLine($"Student's name is {FirstName} {LastName}");
        }
        public void DisplayInfo()
        {
                Console.WriteLine($"Student's name is {Major} {NumberOfCredits}");
        }

    }   
}