using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Muster
{
   public class Quadrat :IZeichen
    {
        public void draw()
        {
            Console.WriteLine("Square::draw()");
        }
    }
}
