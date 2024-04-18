using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Facade_Muster
{
    public class DoZeichen
    {
            public IZeichen kreis;
            public IZeichen parallelogram;
            public IZeichen quadrat;

            public DoZeichen()
            {
               kreis = new Kreis();
               parallelogram = new Parallelogram();
               quadrat = new Quadrat();
            }

            public void ZeichneKreis()
            {
                kreis.draw();
            }
            public void ZeichneParallelogram()
            {
                parallelogram.draw();
            }
            public void ZeichneQuadrat()
            {
                quadrat.draw();
            }
        }
    }

