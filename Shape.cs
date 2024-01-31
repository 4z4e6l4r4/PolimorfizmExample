using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmExample
{
    internal class Shape
    {
        public virtual void Ciz() 
        {
            Console.WriteLine("Bir Şekil Çiz");
        }
    }

    class Kare:Shape
    {
        public override void Ciz()
        {
            Console.WriteLine("Kare Çizildi");
        }
    }

    class Daire : Shape
    {
        public override void Ciz()
        {
            Console.WriteLine("Daire Çizildi");
        }
    }
}
