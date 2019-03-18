using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo3
{
    class Program
    {
        static void sub(float a, float b)
        {
            Console.Clear();
            float x = a - b;
            Console.WriteLine("{1}", x);
            Console.ReadKey();
        }

        static void add(float a, float b)
        {
            Console.Clear();
            float x = a + b;
            Console.WriteLine("{1}", x);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            float a, b;
            int x;
            Console.WriteLine("Enter A and B: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Choose the operation:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    add(a, b);
                    break;
                case 2:
                    sub(a, b);
                    break;
                case 3:
                    mul(a, b);
                    break;
                case 4:
                    div(a, b);
                    break;
                default:
                    break;
            }
        }
    }
    }
}
