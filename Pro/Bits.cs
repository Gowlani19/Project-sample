using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class Bits : Number
    {
        public string bits { get; }

        public Bits(string bits)
        {
            this.bits = bits;
        }

        public override string ToString()
        {
            return bits.ToString();
        }

        public string type()
        {
            if(bits.Contains("1") && bits.Contains("0"))
            {
                return "Binary";
            }
            return "Try";
        }
    }
}
