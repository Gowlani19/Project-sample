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
            // 1. The first step is to prompt the user for a number type
            // 2. Create the appropriate Number based on the number type (e.g. Binary, Octal, or Hexadecimal); set the number into Number num1.
            // 3. Prompt for an op char; create an operator instance based on the input --> Operations operation based on the number type with the op char.
            // 4. Create the appropriate Number based on the number type (e.g. Binary, Octal, or Hexadecimal); set the number into Number num2.
            // 5. Invoke the appropriate operation.


            Screen screen = new Screen();
            Binary binary;
            NumType numType;
            if (!Enum.TryParse<NumType>("Oct", out numType))
            {
                Console.WriteLine("Invalid number type");
            }
            Bits a = screen.input();
            screen.output(a);
            Bits b = screen.input();
            screen.output(b);

            Bits c;

            Console.WriteLine($"Enter a Number Type:");
            NumType d = Console.ReadLine();

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
