using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
   
    public class Employee
    {
        int empId;
        public string empName;
        public void EmployeeDetails()
        {
            Console.WriteLine("\nEnter the Employee ID :");
            empId=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the Employee Name :");
            empName = Console.ReadLine();
        }
        
    }
}
