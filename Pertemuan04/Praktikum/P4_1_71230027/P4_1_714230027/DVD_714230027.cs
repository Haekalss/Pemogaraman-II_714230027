using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P4_1_714230027;

namespace P4_1_714230027
{
    internal class DVD_714230027 : product_714230027
    {
        protected string duration;

        public DVD_714230027(string title, string duration)
        {
            MyType = "DVD";
            MyTitle = title;
            this.duration = duration;
            Console.WriteLine("ini dari class DVD");
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        //implementasi metode abstrak
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is  a {0} called \"{1}\" and has {2} minutes duration", MyType, MyTitle, Duration);
        }
    }
}