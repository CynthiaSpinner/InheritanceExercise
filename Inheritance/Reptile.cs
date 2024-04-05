using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
            Legs = 8;
            BodySize = "ginormous";
            MaleOrFemale = "Male";
            Age = 35;
        }
        public bool HasClaws { get; set; }
        public bool HasScales { get; set; }
        public int Weight { get; set; }
        public string ColdBlooded { get; set; }


        public void Details()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Has claws: {HasClaws}\n" +
                  $"Has Scales: {HasScales}\n" +
                  $"Weight: {Weight}\n" +
                  $"ColdBlooded: {ColdBlooded}\n" +
                  $"Legs: {Legs}\n" +
                  $"BodySize: {BodySize}\n" +
                  $"Male or Female: {MaleOrFemale}\n" +
                  $"Age: {Age}");

        }
    }

  
    

}
