using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            int a= 10; // Declarasi variabel a,dg nilai awal 10;
            int b= 6; // Declarasi variabel b,dg nilai awal 6;

            Console.Write("Inputkan nilai a =);
                int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b =);
                int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();


            Console.WriteLine("Hasil penambahan" + a + "+" + b + "=" + Penambahan(a, b));
            Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("Hasil perkalian {0} * {1} ={2}", a, b, perkalian(a, b));
            Console.WriteLine("Hasil pembagian{0}/ {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("/nTekan sembarang key untuk keluar");
            Console.ReadKey();

        }
        static int Penambahan(int a,int b)
        {
            return a + b;

        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
    }
}
