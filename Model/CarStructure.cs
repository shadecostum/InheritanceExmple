using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample.Model
{
    public class CarStructure : Car
    {
        
            public int Tyre { get; set; }
            public string Seat { get; set; }

            public CarStructure(string name, string model, int year, int milage, int tyre, string seat) : base(name, model, year, milage)
            {
                this.Tyre = tyre;
                this.Seat = seat;
            }
            public string Topspeed(int number)
            {
                return $"Name : {Name} \nModel : {Model} \n" + $"Year Manufactored : {Year} \nMilage : {Milage} " + $"High speed : {number}\n" +
                    $"No of Tyre : {Tyre} , No of Seat : {Seat}";


            }
        }
    
}
