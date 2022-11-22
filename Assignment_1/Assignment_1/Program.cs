using System;

namespace Assignment_1
{

    class Program
    {
       static void Main(string[] args)
       {
            Student std = new Student();
            std.studentDetails();
            MCAStudent MCA = new MCAStudent();
            BSCStudent BSC = new BSCStudent();

            Console.WriteLine("\nEnter the Stream MCA or BSC :");
            string stream = Console.ReadLine();
            if(stream=="mca")
            {
                MCA.getMarks();
                MCA.Calculate();
            }
            else
            {
                BSC.getmarks();
                BSC.calculate();
            }
        } 

    }
}
