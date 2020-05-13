using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            IPrinterWindows printer;
            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");
            Console.WriteLine("Nomor Printer [1..3] : ");
            int printerNumber = Convert.ToInt32(Console.ReadLine());

            if(printerNumber == 1) {
                printer = new Epson();
            }else if(printerNumber == 2) {
                printer = new Canon();
            }else {
                printer = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
