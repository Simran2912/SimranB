using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public static class ExtensionMethod
    {
        public static void Reverse(this Employee emp)
        {
            char[] chars = emp.empName.ToCharArray();
            for (int i = 0, j = emp.empName.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }

            //Reverse String
            string s = new string(chars);
            Console.WriteLine("\nReverse Name : " +s);

            //String Uppercase
            Console.WriteLine("\nUpper Case :" +s.ToString().ToUpper());
        }
    }
}
