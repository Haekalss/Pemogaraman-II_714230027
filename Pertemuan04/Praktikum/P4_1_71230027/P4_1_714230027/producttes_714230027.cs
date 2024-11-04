using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4_1_714230027;

namespace P4_1_714230027
{
    internal class producttes_714230027
    {
        static void Main(string[] args)
        {
            //Product_714230069 myProduct = new Product_714230069();

            //jawaban no 14 sehingga bisa running
            //Console.WriteLine(myProduct.GetMyType());

            //myProduct.MyType = "DVD";

            //Console.WriteLine(myProduct.MyType);

            book_714230027 product1 = new book_714230027("Book", "C# Object Oriented Solution", "300");
            DVD_714230027 product2 = new DVD_714230027("Ethernal Sunshine Of The Spotless Mind", "145");
            product1.DisplayInfo();
            product2.DisplayInfo();

        }
    }
}