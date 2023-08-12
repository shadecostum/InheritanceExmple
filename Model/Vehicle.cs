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
       
       
    }
