using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            Binary binary;


            Bits a = screen.input();
            screen.output(a);
            Bits b = screen.input();
            screen.output(b);

            Bits c;


            Operations op1 = new Binary(a);
            op1.op = Convert.ToChar(Console.ReadLine());
            if(op1.op.Equals('+'))
            {
                c = op1.addtion(b);
                Console.WriteLine(c);
            }

            Console.WriteLine(a.type());

            



        }
    }
}
