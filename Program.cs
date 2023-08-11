using InheritanceExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car nissan = new Car("Nissan", "Gt-R", 2023, 12);
            Console.WriteLine(""+nissan.Topspeed(320));
            nissan.StartEngine();
            nissan.GearSystem();
            Console.WriteLine("------------------------------------------------");
            Car Ferrari = new Car("Ferrari", "FXX Evo", 2022, 5);
            Console.WriteLine("" + Ferrari.Topspeed(249));
            Ferrari.StartEngine();
            Ferrari.GearSystem();
            Console.WriteLine("------------------------------------------------");
            CarStructure structure = new CarStructure("Lamborgini", "Galardo", 2020, 8, 4, "2 seatd");
            Console.WriteLine(structure.Topspeed(400));
            structure.StartEngine();
            structure.GearSystem();
            Console.WriteLine("------------------------------------------------");
        }
    }
}
