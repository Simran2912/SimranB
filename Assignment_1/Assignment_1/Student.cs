using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class Student
    {
        public virtual void studentDetails()
        {
            Console.WriteLine("\nEnter the Roll No :");
            int rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the name :");
            string name = Console.ReadLine();
        }
    }
}
