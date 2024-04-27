using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string x = "6.7";
            string y = "10.23";

            float num1 = Convert.ToSingle(x);
            float num2 = Convert.ToSingle(y);

            Console.WriteLine(x + y);
            Console.WriteLine(num1 + num2);
;           

        }
    }
}
