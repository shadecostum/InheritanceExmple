    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    namespace InheritanceExample.Model
    {
         public class Vehicle
        {
      
            public string Name { get; set; }
            public string Model { get; set; }
            public Vehicle(string name,string model) {
                this.Name = name;
                this.Model = model; 
        
            }
            public void StartEngine() {
                Console.WriteLine("engine Starting in vehicle");
            }
            public void GearSystem()
            {
                Console.WriteLine("Gears control the speed vehicle");
            }
        
        }
        public class Car : Vehicle
        {
            public int Year { get; set; }
            public int Milage { get; set; }
            public int Top { get; set; }

        
            public Car(string name, string model,int year, int milage) : base(name, model) // Call the base class constructor
            {
                this.Year = year;
                this.Milage = milage;
            }

       

            public string Topspeed(int number) {
           return $"Name : {Name} \nModel : {Model} \n" + $"Year Manufactored : {Year} \nMilage : {Milage} " + $"High speed : {number}";


            }
        }
        public class CarStructure :Car
    {
        public int Tyre { get; set;}
        public string Seat { get;set;}

        public CarStructure(string name, string model, int year, int milage,int tyre,string seat): base(name, model,year,milage) 
        {
            this.Tyre = tyre;
            this.Seat = seat;
        }
        public string Topspeed(int number)
        {
            return $"Name : {Name} \nModel : {Model} \n" + $"Year Manufactored : {Year} \nMilage : {Milage} " + $"High speed : {number}\n"+
                $"No of Tyre : {Tyre} , No of Seat : {Seat}";


        }
    }
    }
