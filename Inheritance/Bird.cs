using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        {
            Legs = 2;
            MaleOrFemale = "Male";
            BodySize = "Small";
            Age = 5;
        }

        public string BeakSize { get; set; }
        public int WingSpan { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }


        public void Details()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Wing Span: {10}inches");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Height: {Height}inches");
            Console.WriteLine($"Beaksize: {BeakSize}");
            Console.WriteLine($"Legs: {Legs}");
            Console.WriteLine($"Male or Female: {MaleOrFemale}");
            Console.WriteLine($"Body size: {BodySize}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    
}
