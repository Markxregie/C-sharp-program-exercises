using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace methods
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine(add(5, 2,3));
        }
       static int add (int num1, int num2)
        {
            return num1 + num2;
        }
       static int add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
