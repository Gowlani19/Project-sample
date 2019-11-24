using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    class Screen
    {
        
        public Bits input()
        {
            return new Bits( Console.ReadLine());
        }

        public void output(Bits outputText)
        {
             Console.WriteLine(outputText);
        }
    }
}
