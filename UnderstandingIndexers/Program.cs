using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitIndexer
{
    class Program
    {
        struct IntBits
        {
            private int bits;

            public IntBits(int initialBitValue)
            {
                bits = initialBitValue; // initializing the bits variable with the initialBitValue parameter upon creation of new IntBits variable
            }

            // Bit indexer defined by "this" keyword and square brackets[]
            public bool this [int index] // return type of bool because we deal with true or false, 1 or 0
            {
                get
                {
                    return (bits & (1 << index)) != 0; //
                }
                set
                {
                    if (value) // Turn the bit on if value is true (1); otherwise, turn it off
                        bits |= (1 << index); // left shifts index by 1 then uses OR operator to return a value containing 
                                               //a 1 in which either of the operands has a 1, and assings it to bits 
                    else
                        bits &= ~(1 << index); // left shifts index by 1 and uses the (~) NOT operator to reverse the values
                                                // such as 001 to 110, then uses the & AND operator to return and assign the value 1 if both operands have a 1
                }
            }

        }

        struct Wrapper
        {
            private int[] data;

            public int this [int i]
            {
                get { return this.data[i]; }
                set { this.data[i] = value; }
            }
        }
        static void Main(string[] args)
        {
            int adapted = 126; //126 has binary representation of 01111110
            IntBits bits = new IntBits(adapted); //creating new bits variable of type IntBits, and initializing the constructor with adapted variable
            bool peek = bits[6]; // retrieve bool at index 6; should be true
            Console.WriteLine(peek); // writing to console to confirm value
            bits[0] = true; // set the bit at index 0 to true (1) new value: 011111111
            bits[3] = false; // set the bit at index 3 to false (0) new value: 01110111

            Console.WriteLine(bits[3]);




        }
    }
}
