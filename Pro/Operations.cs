using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public abstract class  Operations
    {
        public char op { get; set; }
        public abstract Bits addtion(Bits b);
        public abstract Bits sub(Bits b);
        public abstract Bits mul (Bits b);
        public abstract Bits div(Bits b);
        public abstract Bits and(Bits b);
        public abstract Bits or(Bits b);
        public abstract Bits xor(Bits b);
    }
}
