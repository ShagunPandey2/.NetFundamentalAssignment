using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int c = Convert.ToInt32(a);
            string b=Console.ReadLine();
            int d = Convert.ToInt32(b);
            Console.WriteLine(a);   
            Console.WriteLine(b);
            Console.WriteLine(c+d);
            Console.ReadLine();
         
        }
    }
}
