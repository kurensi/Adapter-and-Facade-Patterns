using System;

namespace Adapter_Facade_Muster
{
    class Program
    {
       public static void Main(string[] args)
        {
            DoZeichen my_Zeichen = new DoZeichen();

            my_Zeichen.ZeichneKreis();
            my_Zeichen.ZeichneParallelogram();
            my_Zeichen.ZeichneQuadrat();
            Console.ReadKey();
        }
    }
}
