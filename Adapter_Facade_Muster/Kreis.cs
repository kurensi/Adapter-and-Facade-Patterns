using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Muster
{
    public class Kreis :IZeichen
    {
        double radius = 0;
        public void draw()
        {
            User_Radius(ref radius);
            Console.WriteLine($"Circle::draw()  mit den Radius {radius}");
        }
       public void User_Radius(ref double r)
        {
            try
            {
                Console.Write("Geben Sie den Radius ein :  ");
                r = Convert.ToDouble(Console.ReadLine());
            } 
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
