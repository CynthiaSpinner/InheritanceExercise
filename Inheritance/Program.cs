using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            var blueBird = new Bird()
            {
                BeakSize = "1 inch",
                WingSpan = 5,
                Height = 5,
                Color = "blue",
               
            };

            var igwana = new Reptile()
            {
                HasClaws = true,
                HasScales = true,
                Weight = 10,
                ColdBlooded = "Yes",
                Legs = 4,
                BodySize = "Medium",
                MaleOrFemale = "Female",
                Age = 5
            };

            blueBird.Details();
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();
            igwana.Details();
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
