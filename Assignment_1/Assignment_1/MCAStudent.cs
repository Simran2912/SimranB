﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    public class MCAStudent : Student
    {
        int sub1, sub2, sub3;
        public void getMarks()
        {
            Console.WriteLine("\nEnter the Subject 1 name marks:");
            sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the Subject 2 name marks:");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the Subject 3 name marks:");
            sub3 = Convert.ToInt32(Console.ReadLine());
        }
        public void Calculate()
        {
            int total;
            float result;
            total = sub1 + sub2 + sub3;
            result = total * 100 / 300;
            Console.WriteLine("\nTotal marks :" + total);
            Console.WriteLine("Percentage is :" + result);
        }
        public override void studentDetails()
        {
            getMarks();
            Calculate();
        }
    }
}
