using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    class Binary : Operations
    {
        public Bits aBits { get; set; }

        public Binary(Bits a)
        {
            this.aBits = a;
        }

        public override Bits addtion(Bits bBits)
        {
            bool carry = false;
            // char sum = '0'; ;
            char[] a = aBits.bits.ToCharArray();
            char[] b = bBits.bits.ToCharArray();
            int len;
            if (a.Length > b.Length)
            {
                len = a.Length;
            }
            else
            {
                len = b.Length;
            }
            if (a[0] == 1 && b[0] == 1)
            {
                len = len + 1;
            }
            char[] c = new char[len];//create a new array based on above codition. then i store my resilt here
            for (int i = 0; i < len; i++)
            {
                int aIndex = a.Length - 1 - i;
                int bIndex = b.Length - 1 - i;
                char bitA;
                char bitB;
                bitA = aIndex >= 0 ? a[aIndex] : '0';
                bitB = bIndex >= 0 ? b[bIndex] : '0';
                if (carry == false)

                {

                    if ((bitB == '1') && (bitA == '1'))
                    {
                        c[c.Length - 1 - i] = '0';
                        carry = true;
                    }
                    else if ((bitB == '0') && (bitA == '0'))
                    {
                        c[c.Length - 1 - i] = '0';
                        carry = false;
                    }
                    else if ((bitB == '1') && (bitA == '0'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = false;
                    }
                    else if ((bitB == '0') && (bitA == '1'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = false;
                    }
                }
                else
                {
                    if ((bitA == '1') && (bitB == '1'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = true;
                    }
                    else if ((bitA == '0') && (bitB == '1'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = true;
                    }
                    else if ((bitA == '1') && (bitB == '0'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = true;
                    }
                    else if ((bitA == '0') && (bitB == '0'))
                    {
                        c[c.Length - 1 - i] = '1';
                        carry = false;
                    }
                }

            }

            //string s = new string(c);
            return new Bits(String.Join("",c));

        }

        public override Bits sub()
        {
            throw new NotImplementedException();
        }
    }
}
