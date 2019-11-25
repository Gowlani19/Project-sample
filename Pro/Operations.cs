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
        public abstract Number addtion(Number b);
        public abstract Number sub(Number b);
        public abstract Number mul (Number b);
        public abstract Number div(Number b);
        public abstract Number and(Number b);
        public abstract Number or(Number b);
        public abstract Number xor(Number b);
    }
}
