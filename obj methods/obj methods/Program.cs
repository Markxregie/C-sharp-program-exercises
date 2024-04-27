using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obj_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            character c = new character("mark", "hello world", 100, 50, 1);
            c.stats();
        }
    }


}
class character
{
    public string name, dialog;
    public int hp, mp, lvl;

    public character(string name, string dialog, int hp, int mp, int lvl)
    {
        this.name = name;
        this.dialog = dialog;
        this.hp = hp;
        this.mp = mp;
        this.lvl = lvl;
    }
    public void introduce()
    {
        Console.WriteLine("I am " + name);

    }
    public void saydialog()
    {
        Console.WriteLine(name + " : " + dialog);

    }
    public void stats() 
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("LVL: " + lvl);
        Console.WriteLine("HP: " + hp);
        Console.WriteLine("MP: " +  mp);
    }
}