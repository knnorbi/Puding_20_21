using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány embernek szeretnél pudingot főzni?");
            int fo = int.Parse(Console.ReadLine());

            int adag = fo * 2;
            double kellPor = 0.25 * adag;
            double kellTej = 0.125 * adag;
            double kellCukor = 100.0 / 4 * adag;

            Console.WriteLine("Kell porból: " + kellPor);
            Console.WriteLine("Kell tejből: " + kellTej);
            Console.WriteLine("Kell cukorból: " + kellCukor);

            Console.WriteLine("Mennyi por van otthon?");
            double vanPor = double.Parse(Console.ReadLine());
            Console.WriteLine("Mennyi tej van otthon?");
            double vanTej = double.Parse(Console.ReadLine());
            Console.WriteLine("Mennyi cukor van otthon?");
            double vanCukor = double.Parse(Console.ReadLine());

            if (vanPor < kellPor)
            {
                double venniKell = kellPor - vanPor;
                Console.WriteLine("Kell venni port: " + venniKell);
            }
            if (vanTej < kellTej)
            {
                double venniKell = kellTej - vanTej;
                Console.WriteLine("Kell venni tejet: " + venniKell);
            }
            if (vanCukor < kellCukor)
            {
                double venniKell = kellCukor - vanCukor;
                Console.WriteLine("Kell venni cukrot: " + venniKell);
            }

            Console.ReadKey();
        }
    }
}
