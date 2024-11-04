using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230027
{
    // Abstraction: Abstract class that provides a base for different vehicle types
    abstract class Kendaraan
    {
        // Encapsulation (field): Using protected fields
        protected string Merek;
        protected int Tahun;

        // Constructor
        public Kendaraan(string merek, int tahun)
        {
            Merek = merek;
            Tahun = tahun;
        }

        // Encapsulation (property): Using properties to expose the fields
        public string GetMerek => Merek;
        public int GetTahun => Tahun;

        // Abstraction: Abstract method that must be implemented by subclasses
        public abstract string Suara();

        // General method for all vehicles
        public string Info()
        {
            return $"{Merek} keluaran tahun {Tahun}";
        }
    }

    // Inheritance: Class Mobil inherits Kendaraan
    class Mobil : Kendaraan
    {
        // Encapsulation (field)
        private string Tipe;

        // Constructor: Calls the base constructor
        public Mobil(string merek, int tahun, string tipe) : base(merek, tahun)
        {
            Tipe = tipe;
        }

        // Encapsulation (property): Using a property for the field
        public string GetTipe => Tipe;

        // Polymorphism: Implementing Suara method in Mobil
        public override string Suara()
        {
            return "Brum brum!";
        }
    }

    // Inheritance: Class Motor inherits Kendaraan
    class Motor : Kendaraan
    {
        // Encapsulation (field)
        private int Cc;

        // Constructor: Calls the base constructor
        public Motor(string merek, int tahun, int cc) : base(merek, tahun)
        {
            Cc = cc;
        }

        // Encapsulation (property): Using a property for the field
        public int GetCc => Cc;

        // Polymorphism: Implementing Suara method in Motor
        public override string Suara()
        {
            return "Ngeeeng!";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil = new Mobil("Toyota", 2020, "SUV");
            Motor motor = new Motor("Honda", 2018, 150);

            Console.WriteLine("Info Kendaraan:");
            Console.WriteLine(mobil.Info());
            Console.WriteLine($"Suara: {mobil.Suara()}");
            Console.WriteLine($"Tipe Mobil: {mobil.GetTipe}");
            Console.WriteLine();
            Console.WriteLine(motor.Info());
            Console.WriteLine($"Suara: {motor.Suara()}");
            Console.WriteLine($"Kapasitas CC: {motor.GetCc}");

            Console.ReadLine();
        }
    }
}
