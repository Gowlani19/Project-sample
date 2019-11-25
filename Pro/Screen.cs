using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    class Screen
    {
        private NumType _numberType;
        public Number input()
        {
            if (_numberType == NumType.Binary)
            return new Bits( Console.ReadLine());
            
        }
        public NumType PromptForNumType()
        {
            NumType numType;
            if (!Enum.TryParse<NumType>("Oct", out numType))
            {
                Console.WriteLine("Invalid number type");
            }
            return numType;
        } 

        public void output(Bits outputText)
        {
             Console.WriteLine(outputText);
        }
    }
}
