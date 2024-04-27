using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            p1.firstname = "mark";
            p1.lastname = "regie";
            p1.age = 21;
            p1.sex = 'f';

            person p2 = new person();
            p2.firstname = "jason";
            p2.lastname = "cena";
            p2.age = 34;
            p2.sex = 'm';

            person p3 = new person();
            p3.firstname = "flash";
            p3.lastname = "drax";
            p3.age = 43;
            p3.sex = 'm';

            person p4 = new person();
            p4.firstname = "james";
            p4.lastname = "smith";
            p4.age = 34;
            p4.sex = 'f';

            person p5 = new person();
            p5.firstname = "luther";
            p5.lastname = "king";
            p5.age = 23;
            p5.sex = 'm';

            Console.WriteLine(p1.firstname + " " + p1.lastname);

        }
    }
}
