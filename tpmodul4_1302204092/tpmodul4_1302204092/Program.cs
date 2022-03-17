using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204092
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Hazim;
            Console.Write("Nama kamu: ");
            Hazim = Console.ReadLine();
            HaloGeneric.SapaUser<string>(ref Hazim);
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<T>(ref T x)
        {
            Console.WriteLine("Halo user, " + x + "!");
        }
    }
}
