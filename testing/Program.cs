using System;
using University;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Major = "Biology";
            student1.NumberOfCredits = 12;
            student1.FirstName = "Bob";
            student1.LastName = "Gates";

            student1.DisplayInfo();
            student1.DisplayName();

            Student student2 = new Student();
            student2.Major = "Math";
            student2.NumberOfCredits = 15;
            student2.LastName = "Marks";

            student2.DisplayName();
           
        }



    }
}