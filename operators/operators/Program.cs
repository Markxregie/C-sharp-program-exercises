using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class program
    {
        static void Main(string[] args)
        {
            string english;
            string math;
            string science;
            string computer;

            Console.Write("English grade: ");
            english = Console.ReadLine();
            int eng = Convert.ToInt32(english);

            Console.Write("Math grade: ");
            math = Console.ReadLine();
            int math2 = Convert.ToInt32(math);

            Console.Write("Science grade: ");
            science = Console.ReadLine();
            int science2 = Convert.ToInt32(science);

            Console.Write("Computer grade: ");
            computer = Console.ReadLine();
            int comp2 = Convert.ToInt32(computer);


            float result = (eng + math2 + science2 + comp2) / 4;

            Console.WriteLine("Your grades are: " + "\n" +  eng + "\n" + math2 + "\n"  + science2 + "\n" + comp2);
            Console.WriteLine("_______________________________________");
            Console.WriteLine("Your GWA is: " +  result);


        }
    }
}
