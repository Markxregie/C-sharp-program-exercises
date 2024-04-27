using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
class student
{
    public void introduceSelf(string fullname, string course, int year, string section)
    {
        Console.WriteLine("Fullname: " + fullname);
        Console.WriteLine("Course: " +  course);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Section: " + section);
    }


    public void grade(int grade)
    {
        Console.WriteLine("Average: "+ grade);

        if (grade >= 90)
        {
            Console.WriteLine("With honors");
        }
        else if (grade >= 95)
        {
            Console.WriteLine("With High Honor");
        }
        else if (grade >= 98)
        {
            Console.WriteLine("With Highest Honor");
        }
        else if (grade >= 75)
        {
            Console.WriteLine("Passed");
        }

        else 
        {
            Console.WriteLine("Failed");
        }
    }

}