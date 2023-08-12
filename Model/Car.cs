using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Model
{
    public class Car : Vehicle
    {
        public int Year { get; set; }
        public int Milage { get; set; }
        public int Top { get; set; }


        public Car(string name, string model, int year, int milage) : base(name, model) // Call the base class constructor
        {
            this.Year = year;
            this.Milage = milage;
        }



        public string Topspeed(int number)
        {
            return $"Name : {Name} \nModel : {Model} \n" + $"Year Manufactored : {Year} \nMilage : {Milage} " + $"High speed : {number}";


        }
    }
}
