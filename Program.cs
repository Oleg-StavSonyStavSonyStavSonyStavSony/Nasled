using System;

namespace Nasled
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Worllld!");
            Cube cube = new Cube();
            Console.WriteLine($"{cube}");
            SuperCube superCube = new SuperCube();
            Console.WriteLine($"{superCube}");
        }
    }
}
 