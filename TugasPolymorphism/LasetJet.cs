using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class LasetJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaseJet display dimention : 12*12");
        }

        public override void Print()
        {
            Console.WriteLine("LaseJet printer printing...");
        }
    }
}
