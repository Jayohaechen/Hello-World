using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hello hellO = new Hello("Hello");
            World worlD = new World("World");
            Console.WriteLine(hellO.hEllo() +" "+ worlD.wOrld());
        }
    }
}
