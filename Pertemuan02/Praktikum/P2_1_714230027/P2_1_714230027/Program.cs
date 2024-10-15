using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714230027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("angka pertama = ");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("angka kedua = ");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(input + "+" + input2 + "=" + (input + input2));
			Console.WriteLine(input + "-" + input2 + "=" + (input - input2));
			Console.WriteLine(input + "*" + input2 + "=" + (input * input2));
			Console.WriteLine(input + "/" + input2 + "=" + (input / input2));
		}
    }
}
