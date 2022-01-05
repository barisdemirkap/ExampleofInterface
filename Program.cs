using System;

namespace interfaceexample
{
    class program
    {
        static void Main (string [] args)
        {
            Focus focus = new Focus() ;
            Console.WriteLine(focus.WhichBrand().ToString());
            Console.WriteLine(focus.HowManyWheels().ToString());
            Console.WriteLine(focus.WhichColor().ToString());
            Civic civic = new Civic() ;
            
            Console.WriteLine(civic.WhichBrand().ToString());
            Console.WriteLine(civic.HowManyWheels().ToString());
            Console.WriteLine(civic.WhichColor().ToString());
        }
    }
}