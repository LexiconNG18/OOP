using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            AClass a = new AClass();
            AClass b = new BClass();
            
            Console.WriteLine(a.Override());
            Console.WriteLine(b.Override());
            Console.WriteLine();

            Console.WriteLine(a.Hidden());
            Console.WriteLine(b.Hidden());
            Console.WriteLine(((BClass)b).Hidden());
            Console.WriteLine();

            Console.WriteLine(a.Abstract());
            Console.WriteLine(b.Abstract());
            Console.WriteLine();

            Console.WriteLine(a.Concrete());
            Console.WriteLine(b.Concrete());
            Console.WriteLine();

            CClass c = new CClass();

            Console.WriteLine(a.I1());
            Console.WriteLine(b.I1());
            Console.WriteLine(((Interface2)b).I1());
            Console.WriteLine(c.I1());
            Console.WriteLine();

            Console.WriteLine(((BClass)b).I2());
            Console.WriteLine(c.I2());
            Console.WriteLine();
        }
    }
}
